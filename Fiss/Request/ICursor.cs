namespace Fiss.Request;

public interface ICursor<TResult>: IAsyncEnumerable<TResult>
{
    public bool TryNext();

    public bool TryToPage(int page);

    public bool TrySkipPages(int count);

    public Task<TResult?> Current();
}