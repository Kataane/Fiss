namespace Fiss.Request;

public class IssRequest : IIssRequest
{
    public string Host { get; } = "https://iss.moex.com/iss/";

    public string Extension { get; private set; } = ".json";

    public IDictionary<string, string> Queries { get; } = 
        new Dictionary<string, string>();

    public List<string> Paths { get; } = new();

    public IssRequest() { }

    public IssRequest(string extension, string host)
    {
        Extension = extension;
        Host = host;
    }

    public virtual void AddPath(string path)
    {
        if (Paths.Contains(path) || string.IsNullOrEmpty(path)) throw new Exception("");
        Paths.Add(path);
    }

    /// <summary>
    /// Добавляет путь в массив путей. 
    /// Если передаваемый путь уже был добавлен 
    /// или он пустой, он будет проигнорирован.
    /// </summary>
    public virtual void AddPaths(IEnumerable<string> paths)
    {
        foreach (var path in paths)
        {
            AddPath(path);
        }
    }

    public virtual void AddQuery(KeyValuePair<string, string> query)
    {
        if (string.IsNullOrEmpty(query.Key) || 
            string.IsNullOrEmpty(query.Value) || 
            Queries.ContainsKey(query.Key)) throw new Exception("");

        Queries.Add(query);
    }

    public virtual void RemoveQuery(string key)
    {
        Queries.Remove(key);
    }

    public void UpdateQuery(KeyValuePair<string, string> query)
    {
        if (string.IsNullOrEmpty(query.Key) ||
            string.IsNullOrEmpty(query.Value) ||
            !Queries.ContainsKey(query.Key)) throw new Exception("");

        Queries[query.Key] = query.Value;
    }

    public virtual void AddQueries(IEnumerable<KeyValuePair<string, string>> queries)
    {
        if (queries is null) throw new NullReferenceException(nameof(queries));
        foreach (var query in queries) AddQuery(query);
    }

    public virtual void ChangeExtension(Extension extension)
    {
        Extension = "." + extension.ToString().ToLower();
    }

    public virtual void CleanUp()
    {
        Queries.Clear();
        Paths.Clear();
    }
}