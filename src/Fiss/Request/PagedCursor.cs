using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fiss.Exceptions;
using Fiss.Json;

namespace Fiss;

/// <summary>
///     Provides a cursor to iterate through a paged set of data obtained from an ISS request.
/// </summary>
/// <typeparam name="TEntity">The type of the entities returned by the cursor.</typeparam>
public struct PagedCursor<TEntity>
{
    private int index;
    private readonly int total;
    private readonly int pageSize;

    private readonly string url;
    private readonly IHttpContentSerializer serializer;
    private readonly HttpClient client;

    private int countPages => total / pageSize;

    [SkipLocalsInit]
    public PagedCursor(
        int index, int total,
        PageSize pageSize,
        string url,
        IHttpContentSerializer serializer,
        HttpClient? client = null)
    {
        ArgumentException.ThrowIfNullOrEmpty(url);
        FissArgumentException.ThrowIfLessZero(index);
        FissArgumentException.ThrowIfLessZero(total);
        FissArgumentException.ThrowIfMoreThan(index, total);
        ArgumentNullException.ThrowIfNull(serializer);

        this.serializer = serializer;
        this.index = index;  
        this.total = total;
        this.client = client ?? IssSettings.HttpClient;
        this.pageSize = (int)pageSize;

        var bufferSize = GetBufferSize(this.pageSize, this.total, url.Length);

        Debug.Assert(IssSettings.QueriesForPageCursor.ContainsKey(Constants.Limit));
        IssSettings.QueriesForPageCursor[Constants.Limit] = this.pageSize.ToString();
        this.url = QueryOperator.AddQuery(stackalloc char[bufferSize], url, IssSettings.QueriesForPageCursor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static int GetBufferSize(int pageSize, int total, int urlLength)
    {
        var limitQuerySize = Constants.LimitQuerySize + pageSize.ToString().Length;
        var startQuerySize = Constants.StartQuerySize + total.ToString().Length;
        return Utilities.GetMaxSizeForStackAlloc(urlLength + limitQuerySize + startQuerySize);
    }

    /// <summary>
    /// Attempts to move the cursor to the next page of results.
    /// </summary>
    /// <returns><Columns>true</Columns> if the cursor was successfully moved to the next page; otherwise, <Columns>false</Columns>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryNext()
    {
        if (total == 0) return false;

        if (index + pageSize >= total) return false;

        index += pageSize;
        return true;
    }

    /// <summary>
    /// Attempts to move to a specific page in the paged data.
    /// </summary>
    /// <param name="page">The index of the page to move to.</param>
    /// <returns><Columns>true</Columns> if the cursor was successfully moved to the specified page; otherwise, <Columns>false</Columns>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryToPage(int page)
    {
        if (total == 0) return false;

        if (page < 0 || page > countPages) return false;

        var start = page * pageSize;
        if (start >= total) return false;

        index = start;
        return true;
    }

    /// <summary>
    /// Asynchronously retrieves the entities of the current page.
    /// </summary>
    /// <param name="cancellationToken">CancellationToken to abort the deserialization.</param>
    /// <returns>The results of the current page.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public async ValueTask<TEntity?> GetPageResult(CancellationToken cancellationToken = default)
    {
        if (total == 0) return default;

        var response = await client.GetAsync(ToString(), cancellationToken).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await serializer.Deserialize<TEntity>(response.Content, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    ///     Returns an asynchronous enumerator that iterates through the pages in the data set.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token to use.</param>
    /// <returns>An asynchronous enumerator that can be used to iterate through the pages in the data set.</returns>
    public async IAsyncEnumerator<TEntity> GetAsyncEnumerator(CancellationToken cancellationToken = default)
    {
        if (total == 0) yield break;

        do
        {
            var result = await GetPageResult(cancellationToken).ConfigureAwait(false);
            ArgumentNullException.ThrowIfNull(result);
            yield return result;
        } while (TryNext());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString() => string.Concat(url, index);
}
