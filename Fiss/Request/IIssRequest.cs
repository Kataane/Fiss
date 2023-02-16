using Fiss.Response;

namespace Fiss.Request;

public interface IIssRequest
{
    public void AddPath(string path);

    public void AddPaths(IEnumerable<string> paths);

    public void AddQuery(string key, string value);

    public void AddQuery(KeyValuePair<string, string> query);

    public bool ContainsQuery(string key);

    public void RemoveQuery(string key);

    public void UpdateQuery(KeyValuePair<string, string> query);

    public void AddQueries(IEnumerable<KeyValuePair<string, string>> queries);

    public Task<IIssResponse> Fetch();

    public string ToString();
}
