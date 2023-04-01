using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fiss.Json;

/// <summary>
///     Converts a JSON response from an ISS request into a dictionary of cursors.
/// </summary>
internal class ExtendedCursorConverter : JsonConverter<Dictionary<string, Cursor>>
{
    private static ReadOnlySpan<char> indexSpan => "INDEX";
    private static ReadOnlySpan<char> totalSpan => "TOTAL";
    private static ReadOnlySpan<char> pageSizeSpan => "PAGESIZE";

    /// <summary>
    ///     Gets an default instance of the <see cref="ExtendedCursorConverter" /> class.
    /// </summary>
    public static readonly ExtendedCursorConverter Instance = new();

    /// <inheritdoc />
    public override Dictionary<string, Cursor> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var cursors = new Dictionary<string, Cursor>();

        var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;

        foreach (var property in GetCursorProperty(root))
        {
            var header = property.Name;
            Cursor? cursor = null;

            using var arrayEnumerator = property.Value.EnumerateArray();

            // If the iss.json query is set to "extended", there are two possible structures for the Cursor.
            // 1. If iss.json=extended and iss.meta=off, the JSON structure for the page will be {"INDEX": 0, "TOTAL": 0, "PAGESIZE": 0}.
            // 2. If iss.json=extended and iss.meta=on, the JSON structure for the page will be [{"INDEX": 0, "TOTAL": 0, "PAGESIZE": 0}].
            while (arrayEnumerator.MoveNext())
            {
                var currentValueKind = arrayEnumerator.Current.ValueKind;

                // If metadata is present, skip the current value and move on to the next one.
                // Otherwise, deserialize the current value as a Cursor object.
                if (currentValueKind is JsonValueKind.Object)
                {
                    if (arrayEnumerator.Current.EnumerateObject().All(static jsonProperty =>
                            jsonProperty.NameEquals(Constants.Metadata.AsSpan()))) continue;

                    //cursor = arrayEnumerator.Current.Deserialize<Cursor>(options);
                    cursor = GetCursor(arrayEnumerator.Current);
                    break;
                }

                if (currentValueKind is not JsonValueKind.Array) continue;

                var jsonElement = arrayEnumerator.Current.EnumerateArray().First();
                cursor = GetCursor(jsonElement);

                break;
            }

            ArgumentNullException.ThrowIfNull(cursor);
            cursors[header] = cursor.Value;
        }

        return cursors;
    }

    private static Cursor GetCursor(JsonElement jsonElement)
    {
        var indexJsonElements = jsonElement.GetProperty(indexSpan);
        var totalJsonElement = jsonElement.GetProperty(totalSpan);
        var pageSizeJsonElement = jsonElement.GetProperty(pageSizeSpan);

        return new Cursor
        {
            Index = indexJsonElements.GetInt32(),
            PageSize = pageSizeJsonElement.GetInt32(),
            Total = totalJsonElement.GetInt32()
        };
    }

    private static IEnumerable<JsonProperty> GetCursorProperty(JsonElement root)
    {
        return root.EnumerateArray().SelectMany(static jsonElement =>
            jsonElement.EnumerateObject().Where(static property =>
                property.Name.Contains(Constants.Cursor, StringComparison.OrdinalIgnoreCase)));
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, Dictionary<string, Cursor> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
