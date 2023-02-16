using Fiss.Enums;
using Fiss.Response;
using System.Runtime.CompilerServices;

namespace Fiss.Request;

public class IssRequest : IIssRequest
{
    private Guid g = Guid.NewGuid();

    private readonly HttpClient httpClient;
    private readonly string extension  = ".json";

    private readonly IDictionary<string, string> queriesStorage = new Dictionary<string, string>();

    private readonly HashSet<string> pathsStorage = new(Constants.MaxPathCount);

    public IssRequest()
    {
        httpClient = IssSettings.HttpClient;
    }

    public IssRequest(Format format, HttpClient? httpClient)
    {
        this.httpClient = httpClient ?? IssSettings.HttpClient;

        var defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
        defaultInterpolatedStringHandler.AppendFormatted(Constants.Dot);
        defaultInterpolatedStringHandler.AppendFormatted(format);
        extension = defaultInterpolatedStringHandler.ToStringAndClear();
    }

    public virtual void AddPath(string path)
    {
        pathsStorage.Add(path);
    }

    public virtual void AddPaths(IEnumerable<string> paths)
    {
        foreach (var path in paths)
        {
            AddPath(path);
        }
    }

    public void AddQuery(string key, string value)
    {
        queriesStorage.Add(key, value);
    }

    public virtual void AddQuery(KeyValuePair<string, string> query)
    {
        ArgumentException.ThrowIfNullOrEmpty(query.Key);
        ArgumentException.ThrowIfNullOrEmpty(query.Value);

        queriesStorage.Add(query);
    }

    public bool ContainsQuery(string key)
    {
        return queriesStorage.ContainsKey(key);
    }

    public virtual void RemoveQuery(string key)
    {
        queriesStorage.Remove(key);
    }

    public void UpdateQuery(KeyValuePair<string, string> query)
    {
        ArgumentException.ThrowIfNullOrEmpty(query.Key);
        ArgumentException.ThrowIfNullOrEmpty(query.Value);

        queriesStorage[query.Key] = query.Value;
    }

    public virtual void AddQueries(IEnumerable<KeyValuePair<string, string>> queries)
    {
        ArgumentNullException.ThrowIfNull(queries);

        foreach (var query in queries) AddQuery(query);
    }

    public async Task<IIssResponse> Fetch()
    {
        var response = await httpClient.GetAsync(ToString());
        return new IssResponse(response);
    }

    public override string ToString()
    {
        var defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
        defaultInterpolatedStringHandler.AppendFormatted(Constants.Host);

        if (!pathsStorage.Any()) goto queries;

        foreach (var path in pathsStorage)
        {
            defaultInterpolatedStringHandler.AppendFormatted(Constants.Slash);
            defaultInterpolatedStringHandler.AppendFormatted(path);
        }

    queries:
        defaultInterpolatedStringHandler.AppendFormatted(extension);

        if (!queriesStorage.Any()) goto @string;

        defaultInterpolatedStringHandler.AppendFormatted(Constants.Question);

        var firstQuery = queriesStorage.First();

        defaultInterpolatedStringHandler.AppendFormatted(firstQuery.Key);
        defaultInterpolatedStringHandler.AppendFormatted(Constants.Equals);
        defaultInterpolatedStringHandler.AppendFormatted(firstQuery.Value);

        foreach (var query in queriesStorage.Skip(1))
        {
            defaultInterpolatedStringHandler.AppendFormatted(Constants.Ampersand);
            defaultInterpolatedStringHandler.AppendFormatted(query.Key);
            defaultInterpolatedStringHandler.AppendFormatted(Constants.Equals);
            defaultInterpolatedStringHandler.AppendFormatted(query.Value);
        }
        
    @string:
        return defaultInterpolatedStringHandler.ToStringAndClear();
    }
}