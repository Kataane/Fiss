using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fiss.Json;

internal class ExtendedPageConverter : JsonConverter<Page>
{
    public static readonly ExtendedPageConverter Instance = new();

    public override Page Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var responses = new Dictionary<string, Table>();

        var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;

        foreach (var jsonProperty in root.EnumerateArray().SelectMany(static jsonElement => jsonElement.EnumerateObject()))
        {
            var header = jsonProperty.Name;
            if (header.Equals(Constants.CharsetInfo, StringComparison.OrdinalIgnoreCase)) continue;

            var metadataExist = MetadataExist(jsonProperty);

            var jsonElement = metadataExist ? jsonProperty.Value.EnumerateArray().Skip(1).FirstOrDefault() : jsonProperty.Value;

            var objects = jsonElement.Deserialize<List<Dictionary<string, JsonElement?>>>() ?? new List<Dictionary<string, JsonElement?>>();

            var columns = GetColumns(objects).ToList();

            var rows = EnumerableUtilities.CreateRows(objects, columns);

            var response = new Table(columns, rows);
            responses[header] = response;
        }

        return new Page(responses);
    }

    private static bool MetadataExist(JsonProperty jsonProperty)
    {
        return jsonProperty.Value
            .EnumerateArray().FirstOrDefault()
            .EnumerateObject().FirstOrDefault()
            .NameEquals(Constants.Metadata.AsSpan());
    }

    private static IEnumerable<Header> GetColumns(IEnumerable<Dictionary<string, JsonElement?>> objects)
    {
        var keys = objects.FirstOrDefault()?.Keys;
        if (keys is null) yield break;

        foreach (var key in keys)
        {
            var column = StringUtilities.ToPascalCaseInvariant(key.AsSpan());
            yield return new Header(column);
        }
    }

    public override void Write(Utf8JsonWriter writer, Page value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}