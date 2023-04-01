namespace Fiss;

public sealed record IssRequestOptions
{
    public CleanBehavior CleanBehaviorForPaths { get; init; }
    public CleanBehavior CleanBehaviorForQueries { get; init; }

    public Format Format { get; init; }
}