using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace Fiss;

internal static class EnumerableUtilities
{
    internal static List<Row> CreateRows(IEnumerable<Dictionary<string, JsonElement?>> data, IEnumerable<Header?> columns)
    {
        return CreateRows(data.Select(static dictionary => dictionary.Values.ToList()).ToList(), columns.ToList());
    }

    internal static List<Row> CreateRows(List<List<JsonElement?>> data, List<Header?> columns)
    {
        var rows = new List<Row>(data.Count);

        foreach (var row in data)
        {
            if (row.Count == 0) continue;

            if (row.Count != columns.Count)
            {
                throw new InvalidOperationException("The number of elements in the row does not match the number of columns.");
            }

            var dictionary = new Dictionary<string, (string Type, string Value)>();

            for (var i = 0; i < row.Count; i++)
            {
                var header = columns[i];
                var element = row[i];

                if (header is null) continue;

                ref var @default = ref CollectionsMarshal.GetValueRefOrAddDefault(dictionary, header.Name, out var exist);
                if (!exist) @default = ConvertJsonElementToTuple(element);
            }

            var newRow = new Row(dictionary);
            rows.Add(newRow);
        }

        return rows;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static (string Type, string Value) ConvertJsonElementToTuple(JsonElement? element)
    {
        if (!element.HasValue)
        {
            return (Type: "Null", Value: "null");
        }

        var value = element.Value;
        return (Type: ValueKindToString(value.ValueKind), Value: value.GetRawText());
    }

    private static string ValueKindToString(JsonValueKind valueKind)
    {
        return valueKind switch
        {
            JsonValueKind.Array => "Array",
            JsonValueKind.String => "String",
            JsonValueKind.Number => "Number",
            JsonValueKind.True => "True",
            JsonValueKind.Object => "Object",
            JsonValueKind.False => "False",
            JsonValueKind.Null => "Null",
            JsonValueKind.Undefined => "Undefined",
            _ => throw new ArgumentOutOfRangeException(nameof(valueKind), valueKind, null)
        };
    }
}
