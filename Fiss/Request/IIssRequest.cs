namespace Fiss.Request;

public interface IIssRequest
{
    public IDictionary<string, string> Queries { get; }

    public List<string> Paths { get; }

    public string Host { get; }

    public string Extension { get; }

    public void AddPath(string path);

    public void AddPaths(IEnumerable<string> paths);

    public void AddQuery(KeyValuePair<string, string> query);

    public void RemoveQuery(string key);

    public void UpdateQuery(KeyValuePair<string, string> query);

    public void AddQueries(IEnumerable<KeyValuePair<string, string>> queries);

    public void ChangeExtension(Extension extension);

    public void CleanUp();
}
