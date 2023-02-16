using Fiss.Extensions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fiss.Json;

internal class CursorConverter : JsonConverter<Dictionary<string, List<List<int>>>>
{
    public static CursorConverter Instance = new();

    public override Dictionary<string, List<List<int>>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var cursors = new Dictionary<string, List<List<int>>>();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject) continue;

            var header = reader.GetString()?.ToPascalCase() ?? string.Empty;

            if (!header.Contains(Constants.Cursor, StringComparison.OrdinalIgnoreCase))
            {
                reader.Skip();
                continue;
            }

            var cursor = JsonElement.ParseValue(ref reader).GetProperty(Constants.Data).Deserialize<List<List<int>>>();
            ArgumentNullException.ThrowIfNull(cursor);
            cursors.Add(header, cursor);
        }

        return cursors;
    }

    public override void Write(Utf8JsonWriter writer, Dictionary<string, List<List<int>>> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}