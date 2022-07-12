namespace Fiss.Request;

/// <summary>
/// Обертка для IIssRequst 
/// которая предоставляет возможность пагинации
/// </summary>
/// <example>
/// <code>
/// var cursor = new IssRequest().Engines().Fetch().ToCursor();
/// cursor.TryNext();
/// var response = cursor.Current.ToList();
/// </code>
/// </example>
public class CursorRequest<TResult> : ICursor
{
    private IIssRequest Request { get; }

    private int index;

    private readonly int pageSize;

    private readonly long total;

    private readonly Func<IIssRequest, TResult> converter;
    private readonly Func<IIssRequest, Task<IIssRequest>> fetch;

    public long CountPages => total / pageSize;

    public int CurrentPage => index / pageSize;

    public CursorRequest(IIssRequest request, int index, long total, PageSize pageSize, Func<IIssRequest, TResult> converter, Func<IIssRequest, Task<IIssRequest>> fetch)
    {
        Request = request;

        this.index = index;
        this.total = total;
        this.pageSize = (int)pageSize;
        this.converter = converter;
        this.fetch = fetch;

        request.AddQuery(new KeyValuePair<string, string>("limit", this.pageSize.ToString()));
    }

    /// <summary>
    /// Пробует перейти на следующую страницу
    /// с ответами
    /// </summary>
    public bool TryNext()
    {
        if (index + pageSize >= total) return false;
        index += pageSize;
        return true;    
    }

    /// <summary>
    /// Пробует перейти на конкретную страницу
    /// </summary>
    public bool TryToPage(int page)
    {
        var fakeIndex = page * pageSize;
        if (fakeIndex > CountPages) return false;
        index = fakeIndex;
        return true;
    }

    /// <summary>
    /// Пробует пропустить n количество страниц
    /// </summary>
    public bool TrySkipPages(int count)
    {
        for (var i = 0; i <= count; i++)
        {
            var can = TryNext();
            if (!can) break;
        }

        return true;
    }

    /// <summary>
    /// Передает ответ с текущей страницы
    /// </summary>
    public async Task<TResult> Current()
    {
        var query = new KeyValuePair<string, string>("start", index.ToString());

        if (Request.Queries.ContainsKey(query.Key)) Request.UpdateQuery(query);
        else Request.AddQuery(query);

        await fetch(Request);
        return converter(Request);
    }

    /// <summary>
    /// Передает итератор
    /// </summary>
    public async IAsyncEnumerable<TResult> Iterator()
    {
        do
        {
            yield return await Current();
        } while (TryNext());
    }
}