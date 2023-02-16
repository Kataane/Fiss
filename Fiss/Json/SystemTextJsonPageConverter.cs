using System.Text.Json;
using Fiss.Response;

namespace Fiss.Json;

public class SystemTextJsonPageConverter : IssJsonConverter<Page>
{
    public static SystemTextJsonPageConverter Instance = new();

    private static readonly JsonSerializerOptions options = new()
    {
        Converters = { PageJsonConverter.Instance }
    };

    public override async Task<Page?> ReadJson(IIssResponse issResponse)
    {
        await using var stream = await issResponse.Read();
        using var streamReader = new StreamReader(stream);

        return await JsonSerializer.DeserializeAsync<Page>(stream, options);
    }
}