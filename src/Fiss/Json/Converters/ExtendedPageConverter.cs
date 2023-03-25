using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fiss.Json;

/// <summary>
///     Provides methods to convert a JSON representation of a <see cref="Page" />.
/// </summary>
internal class ExtendedPageConverter : JsonConverter<Page>
{
    /// <summary>
    ///     Gets an default instance of the <see cref="ExtendedPageConverter" /> class.
    /// </summary>
    public static ExtendedPageConverter Instance = new();

    /// <inheritdoc />
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

            var objects = jsonElement.Deserialize<Dictionary<string, JsonElement>[]>() ?? Enumerable.Empty<Dictionary<string, JsonElement>>();

            var columns = GetColumns(objects).ToList();

            var rows = EnumerableUtilities.CreateRows(objects.Select(static dictionary => dictionary.Values), columns);

            var response = new Table(columns, rows);
            responses[header] = response;
        }

        return new Page(responses);
    }

    private static bool MetadataExist(JsonProperty jsonProperty)
    {
        return jsonProperty.Value.EnumerateArray().FirstOrDefault().EnumerateObject().FirstOrDefault()
            .NameEquals(Constants.Metadata.AsSpan());
    }

    private static IEnumerable<Header> GetColumns(IEnumerable<Dictionary<string, JsonElement>> objects)
    {
        foreach (var key in objects.FirstOrDefault()?.Keys ?? Enumerable.Empty<string>())
        {
            var readOnlySpan = key.AsSpan();
            var column = StringUtilities.ToPascalCaseInvariant(ref readOnlySpan);
            yield return new Header(column);
        }
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, Page value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}