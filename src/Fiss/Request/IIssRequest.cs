namespace Fiss;

/// <summary>
///     Represents a request builder to the Informational & Statistical Server (ISS) that provides access to market data
///     from all the Moscow Exchange markets.
/// </summary>
public interface IIssRequest : IDisposable
{
    public void AddPath(string path);

    public void AddPaths(IEnumerable<string> paths);

    public void AddQuery(string key, string value);

    public void AddQueries(IEnumerable<KeyValuePair<string, string>> queries);

    public string GetQueryValue(string key);

    public bool ContainsQuery(string key);

    public bool ContainsPath(string key);

    public void UpdateQuery(string key, string value);

    internal void ClearPaths();

    internal void ClearQueries();
}