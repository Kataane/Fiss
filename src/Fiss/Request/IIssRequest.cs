namespace Fiss;

/// <summary>
///     Represents a request builder to the Informational & Statistical Server (ISS) that provides access to market data
///     from the Moscow Exchange markets.
/// </summary>
public interface IIssRequest : IDisposable
{
    /// <summary>
    ///     Adds a path to the request.
    /// </summary>
    /// <param name="path">The path to add.</param>
    public void AddPath(string path);

    /// <summary>
    ///     Adds multiple paths to the request.
    /// </summary>
    /// <param name="paths">The paths to add.</param>
    public void AddPaths(IEnumerable<string> paths);

    /// <summary>
    ///     Adds a query parameter to the request.
    /// </summary>
    /// <param name="key">The key of the query parameter.</param>
    /// <param name="value">The value of the query parameter.</param>
    public void AddQuery(string key, string value);

    /// <summary>
    ///     Adds multiple query parameters to the request.
    /// </summary>
    /// <param name="queries">The query parameters to add.</param>
    public void AddQueries(IEnumerable<KeyValuePair<string, string>> queries);

    /// <summary>
    ///     Gets the value of a query parameter by its key.
    /// </summary>
    /// <param name="key">The key of the query parameter.</param>
    /// <returns>The value of the query parameter. </returns>
    public string GetQueryValue(string key);

    /// <summary>
    ///     Determines whether the request contains a query parameter with the specified key.
    /// </summary>
    /// <param name="key">The key of the query parameter.</param>
    /// <returns><c>true</c> if the request contains a query parameter with the specified key; otherwise, <c>false</c>.</returns>
    public bool ContainsQuery(string key);

    /// <summary>
    ///     Determines whether the request contains the specified path.
    /// </summary>
    /// <param name="key">The path to search for.</param>
    /// <returns><c>true</c> if the request contains the specified path; otherwise, <c>false</c>.</returns>
    public bool ContainsPath(string key);

    /// <summary>
    ///     Updates the value of a query parameter by its key.
    /// </summary>
    /// <param name="key">The key of the query parameter to update.</param>
    /// <param name="value">The new value of the query parameter.</param>
    public void UpdateQuery(string key, string value);

    /// <summary>
    ///     Clears all paths from the request.
    /// </summary>
    internal void ClearPaths();

    /// <summary>
    ///     Clears all query parameters from the request.
    /// </summary>
    internal void ClearQueries();
}