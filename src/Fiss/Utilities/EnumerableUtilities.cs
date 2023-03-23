using System.Text.Json;

namespace Fiss;

internal static class EnumerableUtilities
{
    internal static IEnumerable<Row> CreateRows(IEnumerable<IEnumerable<JsonElement>> data, IEnumerable<Header> columns)
    {
        return data.Select(row => row
                .Zip(columns, static (value, header) => new KeyValuePair<string, JsonElement>(header.Name, value)))
            .Select(static keyValuePairs =>
                new Row(keyValuePairs.ToDictionary(static kvp => kvp.Key, 
                    ConvertJsonElementToTuple)));
    }

    private static (string Type, string Value) ConvertJsonElementToTuple(KeyValuePair<string, JsonElement> kvp)
    {
        return (Type: kvp.Value.ValueKind.ToString(), Value: kvp.Value.GetRawText());
    }
}