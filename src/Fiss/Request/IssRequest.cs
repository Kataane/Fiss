using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Fiss;

public class IssRequest : IIssRequest
{
    private readonly IssRequestOptions issRequestOptions;
    private volatile bool disposed;

    internal int PathsCountAfterSnapshot { get; private set; }

    internal int QueriesCountAfterSnapshot { get; private set; }

    private HashSet<string?> pathsStorage = new();
    private Dictionary<string, string> queriesStorage = new();

    private readonly string extension;

    public IssRequest(IssRequestOptions? issRequestOptions = null)
    {
        this.issRequestOptions = issRequestOptions ?? IssSettings.DefaultIssRequestOptions;
        extension = Constants.Dot + this.issRequestOptions.Format.ToString().ToLowerInvariant();
    }

    public void TakeSnapshot()
    {
        PathsCountAfterSnapshot = pathsStorage.Count;
        QueriesCountAfterSnapshot = queriesStorage.Count;
    }

    public void AddPath(string? path)
    {
        ArgumentException.ThrowIfNullOrEmpty(path);

        pathsStorage.Add(path);
    }

    public void AddPaths(IEnumerable<string?> paths)
    {
        ArgumentNullException.ThrowIfNull(paths);

        foreach (var path in paths) AddPath(path);
    }

    public void AddQuery(string key, string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(key);
        ArgumentException.ThrowIfNullOrEmpty(value);

        ref var _value = ref CollectionsMarshal.GetValueRefOrAddDefault(queriesStorage, key, out var exist);

        if (!exist) _value = value;
    }

    public void AddQueries(IEnumerable<KeyValuePair<string, string>> queries)
    {
        ArgumentNullException.ThrowIfNull(queries);

        foreach (var (key, value) in queries)
        {
            AddQuery(key, value);
        }
    }

    public string GetQueryValue(string key)
    {
        ArgumentException.ThrowIfNullOrEmpty(key);

        var result = queriesStorage.TryGetValue(key, out var value);

        if (!result || string.IsNullOrEmpty(value)) return string.Empty;
        return value;
    }

    public bool ContainsQuery(string key)
    {
        return queriesStorage.ContainsKey(key);
    }

    public bool ContainsPath(string key)
    {
        return pathsStorage.Contains(key);
    }

    public void UpdateQuery(string key, string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(key);
        ArgumentException.ThrowIfNullOrEmpty(value);

        ref var _value = ref CollectionsMarshal.GetValueRefOrNullRef(queriesStorage, key);

        if (!Unsafe.IsNullRef(ref _value)) _value = value;
    }

    void IIssRequest.ClearPaths()
    {
        pathsStorage.Clear();
    }

    void IIssRequest.ClearQueries()
    {
        queriesStorage.Clear();
    }

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

        var _kvp = queriesStorage.First();
        defaultInterpolatedStringHandler.AppendLiteral(_kvp.Key);
        defaultInterpolatedStringHandler.AppendFormatted(Constants.Equals);
        defaultInterpolatedStringHandler.AppendLiteral(_kvp.Value);

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

        CleanPaths();
        CleanQueries();

        disposed = false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void CleanPaths()
    {
        switch (issRequestOptions.CleanBehaviorForPaths)
        {
            case CleanBehavior.Clean:
                pathsStorage.Clear();
                break;
            case CleanBehavior.RevertSnapshotState:
                pathsStorage = new HashSet<string?>(pathsStorage.Take(PathsCountAfterSnapshot));
                break;
            case CleanBehavior.NotClean:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(issRequestOptions.CleanBehaviorForPaths),
                    issRequestOptions.CleanBehaviorForPaths, null);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void CleanQueries()
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
                throw new ArgumentOutOfRangeException(nameof(issRequestOptions.CleanBehaviorForQueries),
                    issRequestOptions.CleanBehaviorForQueries, null);
        }
    }
}