using System.Text.Json;
using Fiss.Enums;
using Fiss.Json;
using Fiss.Request;
using Fiss.Response;

namespace Fiss.Extensions;

public static class IssRequestExtension
{
    public static async Task<TResult?> ConvertToAsync<TResult>(this IIssRequest request, IssJsonConverter<TResult> converter)
    {
        using var response = await request.Fetch();
        return await converter.ReadJson(response);
    }

    public static async Task<ICursor<Page>> ToCursor(this IIssRequest request,
        string? cursorTitle = null,
        int index = 0,
        PageSize pageSize = PageSize.Twenty)
    {
        return await request.ToCursor(SystemTextJsonPageConverter.Instance, cursorTitle, index, pageSize);
    }

    public static async Task<ICursor<TResult>> ToCursor<TResult>(this IIssRequest request,
        IssJsonConverter <TResult> converter,
        string? cursorTitle = null,
        int index = 0,
        PageSize pageSize = PageSize.Twenty)
    {
        await using var stream = await (await request.Fetch()).Read();

        var cursors = await JsonSerializer.DeserializeAsync<Dictionary<string, List<List<int>>>>(stream, IssSettings.CursorConverterOptions);

        ArgumentNullException.ThrowIfNull(cursors);

        var cursor = cursorTitle is null
            ? cursors.FirstOrDefault()
            : cursors.FirstOrDefault(kvp => kvp.Key.Equals(cursorTitle, StringComparison.OrdinalIgnoreCase));

        var data = cursor.Value[0];
        index = index > 0 ? index : data[0];
        var total = data[1];

        return new CursorRequest<TResult>(request, converter, index, total, pageSize);
    }
}