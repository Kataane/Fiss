#nullable enable
namespace Fiss.Query;

public record IssQueryWrap(
    string Path,
    string[]? Params,
    List<KeyValuePair<string, string>>? Queries);

