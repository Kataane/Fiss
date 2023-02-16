using Fiss.Enums;
using Fiss.Extensions;
using Fiss.Json;

namespace Fiss.Request;

public class CursorRequest<TResult> : ICursor<TResult>
{
    private readonly IIssRequest request;

    private readonly IssJsonConverter<TResult> converter;
    private int index;

    private readonly int pageSize;

    private readonly long total;

    public long CountPages => total / pageSize;

    public int CurrentPage => index / pageSize;

    public CursorRequest(IIssRequest request, IssJsonConverter<TResult> converter, int index, int total, PageSize pageSize)
    {
        this.request = request;

        this.converter = converter;
        this.index = index;
        this.total = total;
        this.pageSize = (int)pageSize;

        if (index > total) throw new ArgumentOutOfRangeException($"{index} cannot be more than {total}");
        var query = new KeyValuePair<string, string>(Constants.Limit.ToString(), this.pageSize.ToString());
        if (!this.request.ContainsQuery(query.Key)) this.request.AddQuery(query);
    }

    public bool TryNext()
    {
        if (index + pageSize >= total) return false;
        index += pageSize;
        return true;    
    }

    public bool TryToPage(int page)
    {
        var fakeIndex = page * pageSize;
        if (fakeIndex > CountPages) return false;
        index = fakeIndex;
        return true;
    }

    public bool TrySkipPages(int count)
    {
        for (var i = 0; i <= count; i++)
        {
            var can = TryNext();
            if (!can) return false;
        }

        return true;
    }

    public async Task<TResult?> Current()
    {
        return await request.ConvertToAsync(converter);
    }

    public async IAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = new())
    {
        do
        {
            var query = new KeyValuePair<string, string>(Constants.Start.ToString(), index.ToString());

            if (request.ContainsQuery(query.Key)) request.UpdateQuery(query);
            else request.AddQuery(query);

           var result = await Current();
           ArgumentNullException.ThrowIfNull(result);

           yield return result;
        } while (TryNext());
    }
}