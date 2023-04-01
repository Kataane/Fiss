using System.Reflection;
using System.Text.Json;
using Fiss.Json;
using System.Runtime.CompilerServices;
using Fiss;

[assembly: InternalsVisibleTo("Fiss.Tests")]
[assembly: InternalsVisibleTo("Fiss.Generator")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

public static class IssSettings
{
    public static string CurrentVersion
    {
        get
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString(3);
            ArgumentException.ThrowIfNullOrEmpty(version);
            return version;
        }
    }

    public static string FormattedCurrentVersion => $"Fiss/{CurrentVersion}";

    internal static readonly JsonSerializerOptions CursorCompactJsonSerializerOptions = new() { Converters = { CompactCursorConverter.Instance }, };

    internal static readonly JsonSerializerOptions CursorExtendedJsonSerializerOptions = new() { Converters = { ExtendedCursorConverter.Instance } };

    internal static readonly JsonSerializerOptions PageCompactJsonSerializerOptions = new() { Converters = { CompactPageJsonConverter.Instance } };

    internal static readonly JsonSerializerOptions PageExtendedJsonSerializerOptions = new() { Converters = { ExtendedPageConverter.Instance } };

    internal static readonly SystemTextJsonConverter PageExtendedJsonSerializerInstance = new(PageExtendedJsonSerializerOptions);

    internal static readonly SystemTextJsonConverter PageCompactJsonSerializerInstance = new(PageCompactJsonSerializerOptions);

    internal static readonly SystemTextJsonConverter CursorCompactJsonSerializerInstance = new(CursorCompactJsonSerializerOptions);

    internal static readonly SystemTextJsonConverter CursorExtendedJsonSerializerInstance = new(CursorExtendedJsonSerializerOptions);

    internal static readonly HttpClient HttpClient = new(new SocketsHttpHandler { PooledConnectionLifetime = TimeSpan.FromMinutes(2) });

    internal static readonly Dictionary<string, string> QueriesForPageCursor = new(new List<KeyValuePair<string, string>>(new[]
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
