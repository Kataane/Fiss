using System.Runtime.CompilerServices;
using Fiss.Json;

namespace Fiss;

/// <summary>
///     This class contains some methods that enhance the capabilities of <see cref="IIssRequest" />.
/// </summary>
public static partial class IssRequestExtension
{
    /// <summary>
    ///     Inserts a path into the <see cref="IIssRequest" /> based on the specified <see cref="IssQuery" /> and parameters.
    /// </summary>
    /// <remarks>
    ///     This method clears all existing paths in the specified <see cref="IIssRequest" /> object before adding the new path
    ///     based on the specified <see cref="IssQuery" /> and parameters.
    /// </remarks>
    /// <param name="request">The <see cref="IIssRequest" /> object to modify.</param>
    /// <param name="issQuery">The <see cref="IssQuery" /> to use as a basis for the path insertion.</param>
    /// <param name="parameters">The parameters to use for formatting the path.</param>
    /// <returns>The modified <see cref="IIssRequest" /> object.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest AddPathFromFormattedQuery(
        this IIssRequest request, 
        IssQuery issQuery,
        params object?[] parameters)
    {
        request.ClearPaths();

        var description = EnumUtilities<IssQuery>.GetDescription(issQuery);
        var result = string.Format(description, parameters);
        request.AddPaths(result.Split(Constants.Slash));

        return request;
    }

    /// <summary>
    ///     Converts the <see cref="IIssRequest" /> to the specified type asynchronously using the specified converter.
    /// </summary>
    /// <typeparam name="TResult">The type to convert the request to.</typeparam>
    /// <param name="request">The <see cref="IIssRequest" /> object to convert.</param>
    /// <param name="serializer">The converter to use for the conversion.</param>
    /// <returns>The converted object of type <typeparamref name="TResult" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static async Task<TResult?> ConvertToAsync<TResult>(
        this IIssRequest request,
        IHttpContentSerializer serializer, 
        HttpClient? client = null, 
        CancellationToken cancellationToken = default)
    {
        client ??= IssSettings.HttpClient;
        var response = await client.GetAsync(request.ToString(), cancellationToken).ConfigureAwait(false);
        return await serializer.Deserialize<TResult>(response.Content, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    ///     Converts the <see cref="IIssRequest" /> to a cursor of pages asynchronously using the
    ///     <see cref="SystemTextJsonConverter" /> page converter.
    /// </summary>
    /// <param name="request">The <see cref="IIssRequest" /> object to convert.</param>
    /// <param name="cursorTitle">The title of the cursor to use.</param>
    /// <param name="index">The index of the cursor to use.</param>
    /// <param name="pageSize">The size of the pages to use.</param>
    /// <returns>A cursor of pages.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static async Task<PagedCursor<Page>> ToCursor(
        this IIssRequest request,
        string? cursorTitle = null,
        int? index = null,
        int? total = null,
        PageSize pageSize = PageSize.Twenty,
        HttpClient? client = null,
        CancellationToken cancellationToken = default)
    {
        var jsonFormat = request.GetQueryValue(Constants.IssJson);

        var extendedJson = !string.IsNullOrEmpty(jsonFormat) && jsonFormat.Equals(Constants.Extended, StringComparison.OrdinalIgnoreCase);

        var serializer = extendedJson
            ? IssSettings.PageExtendedJsonSerializerInstance
            : IssSettings.PageCompactJsonSerializerInstance;

        return await request.ToCursor<Page>(serializer, cursorTitle, index, total, pageSize, client, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    ///     Converts the <see cref="IIssRequest" /> to a cursor of the specified type asynchronously using the specified
    ///     converter.
    /// </summary>
    /// <typeparam name="TResult">The type of object to convert the request to.</typeparam>
    /// <param name="request">The <see cref="IIssRequest" /> object to convert.</param>
    /// <param name="serializer">The converter to use for the conversion.</param>
    /// <param name="cursorTitle">The title of the cursor to use.</param>
    /// <param name="index">The index of the cursor to use.</param>
    /// <param name="pageSize">The size of the pages to use.</param>
    /// <returns>A cursor of objects of type <typeparamref name="TResult" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static async Task<PagedCursor<TResult>> ToCursor<TResult>(
        this IIssRequest request,
        IHttpContentSerializer serializer,
        string? cursorTitle = null,
        int? index = null,
        int? total = null,
        PageSize pageSize = PageSize.Twenty,
        HttpClient? client = null,
        CancellationToken cancellationToken = default)
    {
        var jsonFormat = request.GetQueryValue(Constants.IssJson);
        var cursorConverter = IssSettings.CursorCompactJsonSerializerInstance;

        if (!string.IsNullOrEmpty(jsonFormat) &&
            jsonFormat.Equals(Constants.Extended, StringComparison.OrdinalIgnoreCase))
        {
            cursorConverter = IssSettings.CursorExtendedJsonSerializerInstance;
        }

        var cursors = await request.ConvertToAsync<Dictionary<string, Cursor>>(cursorConverter, client, cancellationToken).ConfigureAwait(false);

        ArgumentNullException.ThrowIfNull(cursors);

        var cursor = string.IsNullOrEmpty(cursorTitle)
            ? cursors.FirstOrDefault().Value
            : cursors.FirstOrDefault(kvp => kvp.Key.Equals(cursorTitle, StringComparison.OrdinalIgnoreCase)).Value;

        var _index = index ?? cursor.Index;
        var _total = total ?? cursor.Total;
        var url = request.ToString() ?? string.Empty;

        return new PagedCursor<TResult>( _index, _total, pageSize, url, serializer, client);
    }
}