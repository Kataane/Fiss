using System.Runtime.CompilerServices;
using System.Text.Json;
using Fiss.Json;

#if DEBUG
[assembly: InternalsVisibleTo("Fiss.Tests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif

namespace Fiss;

internal class IssSettings
{
    public static readonly JsonSerializerOptions CursorCompactJsonSerializerOptions = new() { Converters = { CompactCursorConverter.Instance }, };

    public static readonly JsonSerializerOptions CursorExtendedJsonSerializerOptions = new() { Converters = { ExtendedCursorConverter.Instance }};

    public static readonly JsonSerializerOptions PageCompactJsonSerializerOptions = new() { Converters = { CompactPageJsonConverter.Instance }};

    public static readonly JsonSerializerOptions PageExtendedJsonSerializerOptions = new() { Converters = { ExtendedPageConverter.Instance }};

    public static HttpClient HttpClient = new(new SocketsHttpHandler { PooledConnectionLifetime = TimeSpan.FromMinutes(2) });

    public static SystemTextJsonConverter PageExtendedJsonSerializerInstance = new(PageExtendedJsonSerializerOptions);

    public static SystemTextJsonConverter PageCompactJsonSerializerInstance = new(PageCompactJsonSerializerOptions);

    public static SystemTextJsonConverter CursorCompactJsonSerializerInstance = new(CursorCompactJsonSerializerOptions);

    public static SystemTextJsonConverter CursorExtendedJsonSerializerInstance =
        new(CursorExtendedJsonSerializerOptions);

    public static Dictionary<string, string> QueriesForPageCursor = new(new List<KeyValuePair<string, string>>(new[]
    {
        new KeyValuePair<string, string>(Constants.Limit, string.Empty),
        new KeyValuePair<string, string>(Constants.Start, string.Empty)
    }));

    public static readonly IssRequestOptions DefaultIssRequestOptions = new()
    {
        CleanBehaviorForPaths = CleanBehavior.RevertSnapshotState, 
        CleanBehaviorForQueries = CleanBehavior.RevertSnapshotState
    };
}