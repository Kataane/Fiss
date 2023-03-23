namespace Fiss;

public sealed record IssRequestOptions
{
    public CleanBehavior CleanBehaviorForPaths { get; set; }
    public CleanBehavior CleanBehaviorForQueries { get; set; }

    public Format Format { get; set; }
}