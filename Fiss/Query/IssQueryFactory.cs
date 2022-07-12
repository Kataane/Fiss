namespace Fiss.Query;

public static class IssQueryFactory
{
    public static IssQueryWrap Create(IssQuery query, string[] @params = default, IEnumerable<KeyValuePair<string, string>> queries = default)
    {
        queries ??= new List<KeyValuePair<string, string>>();
        return new IssQueryWrap(query.GetDescription(), @params, queries.ToList());
    }

    public static IssQueryWrap Create(Enum query, string[] @params = default, IEnumerable<KeyValuePair<string, string>> queries = default)
    {
        queries ??= new List<KeyValuePair<string, string>>();
        return new IssQueryWrap(query.GetDescription(), @params, queries.ToList());
    }

    public static IssQueryWrap Create(int query, string[] @params = default, IEnumerable<KeyValuePair<string, string>> queries = default)
    {
        var @enum = (IssQuery) Enum.ToObject(typeof(IssQuery), query);
        return Create(@enum, @params, queries);
    }
}