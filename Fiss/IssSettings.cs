using System.Text.Json;
using Fiss.Json;

namespace Fiss;

internal class IssSettings
{
    public static readonly JsonSerializerOptions CursorConverterOptions = new()
    {
        Converters = { CursorConverter.Instance }
    };

    public static HttpClient HttpClient = new();
}