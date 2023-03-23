using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fiss.Json;

/// <summary>
/// Converts a JSON response from an ISS request into a dictionary of cursors.
/// </summary>
internal class CompactCursorConverter : JsonConverter<Dictionary<string, Cursor>>
{
    /// <summary>
    /// Gets an default instance of the <see cref="CompactCursorConverter"/> class.
    /// </summary>
    public static CompactCursorConverter Instance = new();

    /// <inheritdoc/>
    public override Dictionary<string, Cursor> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var cursors = new Dictionary<string, Cursor>();

        var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;

        foreach (var @object in root.EnumerateObject().Where(static property => property.Name.Contains(Constants.Cursor)))
        {
            var header = @object.Name;

            var data = @object.Value.GetProperty(Constants.Data.AsSpan()).EnumerateArray().First();

            var cursor = data.Deserialize<List<int>>(options);
            ArgumentNullException.ThrowIfNull(cursor);

            cursors[header] = new Cursor
            {
                Index = cursor[0],
                Total = cursor[1],
                PageSize = cursor[2]
            };
        }

        return cursors;
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, Dictionary<string, Cursor> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}