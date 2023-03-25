using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Fiss;

/// <inheritdoc cref="IIssRequest" />
public class IssRequest : IIssRequest
{
    private readonly IssRequestOptions issRequestOptions;
    private volatile bool disposed;

    internal int PathsCountAfterSnapshot { get; private set; }
    internal int QueriesCountAfterSnapshot { get; private set; }

    private List<string> pathsStorage = new();
    private Dictionary<string, string> queriesStorage = new();

    private readonly string extension;

    /// <summary>
    ///     Initializes a new instance of the <see cref="IssRequest" /> class with the specified options or use default options
    ///     <see cref="IssSettings.DefaultIssRequestOptions" />
    /// </summary>
    /// <param name="issRequestOptions">The options for the request.</param>
    public IssRequest(IssRequestOptions? issRequestOptions = null)
    {
        this.issRequestOptions = issRequestOptions ?? IssSettings.DefaultIssRequestOptions;
        extension = Constants.Dot + this.issRequestOptions.Format.ToString().ToLowerInvariant();
    }

    /// <summary>
    ///     Takes a snapshot of the current state of the paths and queries.
    /// </summary>
    public void TakeSnapshot()
    {
        PathsCountAfterSnapshot = pathsStorage.Count;
        QueriesCountAfterSnapshot = queriesStorage.Count;
    }

    /// <inheritdoc />
    public void AddPath(string path)
    {
        ArgumentException.ThrowIfNullOrEmpty(path);

        pathsStorage.Add(path);
    }

    /// <inheritdoc />
    public void AddPaths(IEnumerable<string> paths)
    {
        ArgumentNullException.ThrowIfNull(paths);

        foreach (var path in paths) AddPath(path);
    }

    /// <inheritdoc />
    public void AddQuery(string key, string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(key);
        ArgumentException.ThrowIfNullOrEmpty(value);

        ref var @default = ref CollectionsMarshal.GetValueRefOrAddDefault(queriesStorage, key, out var exist);

        if (!exist) @default = value;
    }

    /// <inheritdoc />
    public void AddQueries(IEnumerable<KeyValuePair<string, string>> queries)
    {
        ArgumentNullException.ThrowIfNull(queries);

        foreach (var (key, value) in queries)
        {
            AddQuery(key, value);
        }
    }

    /// <inheritdoc />
    public string GetQueryValue(string key)
    {
        ArgumentException.ThrowIfNullOrEmpty(key);

        var result = queriesStorage.TryGetValue(key, out var value);

        if (!result || string.IsNullOrEmpty(value)) return string.Empty;
        return value;
    }

    /// <inheritdoc />
    public bool ContainsQuery(string key)
    {
        return queriesStorage.ContainsKey(key);
    }

    /// <inheritdoc />
    public bool ContainsPath(string key)
    {
        return pathsStorage.Contains(key);
    }

    /// <inheritdoc />
    public void UpdateQuery(string key, string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(key);
        ArgumentException.ThrowIfNullOrEmpty(value);

        ref var @ref = ref CollectionsMarshal.GetValueRefOrNullRef(queriesStorage, key);

        if (!Unsafe.IsNullRef(ref @ref)) @ref = value;
    }

    /// <inheritdoc />
    void IIssRequest.ClearPaths()
    {
        pathsStorage.Clear();
    }

    /// <inheritdoc />
    void IIssRequest.ClearQueries()
    {
        queriesStorage.Clear();
    }

    /// <summary>
    ///     Returns a string representation of the current object in the form of a URL.
    /// </summary>
    /// <returns>A string that represents the current object in the form of a URL.</returns>
    /// <remarks>
    ///     This method constructs a URL string by concatenating the various components of the URL,
    ///     including the host, path(s), query parameter(s), and extension. The constructed URL is then
    ///     returned as a string.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    {
        var defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 256);
        defaultInterpolatedStringHandler.AppendLiteral(Constants.Host);

        if (!pathsStorage.Any()) goto extension;

        foreach (var path in pathsStorage)
        {
            defaultInterpolatedStringHandler.AppendFormatted(Constants.Slash);
            defaultInterpolatedStringHandler.AppendLiteral(path);
        }

    extension:
        defaultInterpolatedStringHandler.AppendLiteral(extension);

        if (!queriesStorage.Any()) goto @return;

        defaultInterpolatedStringHandler.AppendFormatted(Constants.Question);

        var keyValuePair = queriesStorage.First();
        defaultInterpolatedStringHandler.AppendLiteral(keyValuePair.Key);
        defaultInterpolatedStringHandler.AppendFormatted(Constants.Equals);
        defaultInterpolatedStringHandler.AppendLiteral(keyValuePair.Value);

        foreach (var kvp in queriesStorage.Skip(1))
        {
            defaultInterpolatedStringHandler.AppendFormatted(Constants.Ampersand);
            defaultInterpolatedStringHandler.AppendLiteral(kvp.Key);
            defaultInterpolatedStringHandler.AppendFormatted(Constants.Equals);
            defaultInterpolatedStringHandler.AppendLiteral(kvp.Value);
        }

    @return:
        return defaultInterpolatedStringHandler.ToStringAndClear();
    }

    public void Dispose()
    {
        DisposeCore(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void DisposeCore(bool disposing)
    {
        if (!disposing || disposed) return;

        disposed = true;

        ResetPaths();
        ResetQueries();

        disposed = false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ResetPaths()
    {
        switch (issRequestOptions.CleanBehaviorForPaths)
        {
            case CleanBehavior.Clean:
                pathsStorage.Clear();
                break;
            case CleanBehavior.RevertSnapshotState:
                pathsStorage = new List<string>(pathsStorage.Take(PathsCountAfterSnapshot));
                break;
            case CleanBehavior.NotClean:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(issRequestOptions.CleanBehaviorForPaths), issRequestOptions.CleanBehaviorForPaths, null);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ResetQueries()
    {
        switch (issRequestOptions.CleanBehaviorForQueries)
        {
            case CleanBehavior.Clean:
                queriesStorage.Clear();
                break;
            case CleanBehavior.RevertSnapshotState:
                queriesStorage = new Dictionary<string, string>(queriesStorage.Take(QueriesCountAfterSnapshot));
                break;
            case CleanBehavior.NotClean:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(issRequestOptions.CleanBehaviorForQueries), issRequestOptions.CleanBehaviorForQueries, null);
        }
    }
}