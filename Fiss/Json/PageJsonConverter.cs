using System.Text.Json;
using System.Text.Json.Serialization;
using Fiss.Extensions;
using Fiss.Response;

namespace Fiss.Json;

public class PageJsonConverter : JsonConverter<Page>
{
    public static PageJsonConverter Instance = new();

    public override Page Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var responses = new Dictionary<string, Table>();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject) continue;

            var header = reader.GetString()?.ToPascalCase() ?? string.Empty;
            var y = reader.Read();
            reader.Read();

            reader.Skip();
            reader.Read();

            var columns = JsonElement.ParseValue(ref reader).Deserialize<IEnumerable<string>>()?.Select(item => new Header(item.ToPascalCase()));
            reader.Read();

            var data = JsonElement.ParseValue(ref reader).Deserialize<IEnumerable<IEnumerable<object>>>();
            reader.Read();

            ArgumentNullException.ThrowIfNull(columns);
            ArgumentNullException.ThrowIfNull(data);

            var rows = data.Select(_data => _data
                    .Zip(columns, (value, column) => new { value, column })
                    .ToDictionary(item => item.column.Name, item => item.value))
                .Select(task => new Row(task));

            var response = new Table(columns, rows);
            responses[header] = response;
        }

        return new Page(responses);
    }

    public override void Write(Utf8JsonWriter writer, Page value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}