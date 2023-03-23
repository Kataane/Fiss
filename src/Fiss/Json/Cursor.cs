using System.Text.Json.Serialization;

namespace Fiss.Json;

internal record struct Cursor
{
    [JsonInclude]
    [JsonPropertyName("INDEX")]
    public int Index { get; init; }

    [JsonInclude]
    [JsonPropertyName("TOTAL")]
    public int Total { get; init; }

    [JsonInclude]
    [JsonPropertyName("PAGESIZE")]
    public int PageSize { get; init; }
}