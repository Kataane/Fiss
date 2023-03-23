using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fiss.Json;

/// <summary>
///     Provides methods to convert a JSON representation of a <see cref="Page" />.
/// </summary>
internal class CompactPageJsonConverter : JsonConverter<Page>
{
    /// <summary>
    ///     Gets an default instance of the <see cref="CompactPageJsonConverter" /> class.
    /// </summary>
    public static CompactPageJsonConverter Instance = new();

    /// <inheritdoc />
    public override Page Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var responses = new Dictionary<string, Table>();
        var columns = new List<Header>();
        var data = new List<List<JsonElement>>();

        var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;

        foreach (var @object in root.EnumerateObject())
        {
            var header = @object.Name;

            foreach (var property in @object.Value.EnumerateObject())
            {
                if (property.Name.Equals(Constants.Metadata)) continue;

                if (property.NameEquals(Constants.Columns))
                {
                    foreach (var jsonElement in property.Value.EnumerateArray())
                    {
                        var readOnlySpan = jsonElement.GetString().AsSpan();
                        var s = StringUtilities.ToPascalCaseInvariant(ref readOnlySpan);
                        columns.Add(new Header(s));
                    }
                }

                else if (property.NameEquals(Constants.Data))
                {
                    data = property.Value.Deserialize<List<List<JsonElement>>>(options) ?? Enumerable.Empty<List<JsonElement>>().ToList();
                }
            }

            var rows = EnumerableUtilities.CreateRows(data, columns);

            var response = new Table(columns, rows);
            ref var _value = ref CollectionsMarshal.GetValueRefOrAddDefault(responses, header, out var exist);
            if (!exist) _value = response;
        }

        return new Page(responses);
    }

    public override void Write(Utf8JsonWriter writer, Page value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}