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
    ///     Converts HTTP response content into the specified type asynchronously.
    /// </summary>
    /// <typeparam name="TResult">The type to which the response content will be converted.</typeparam>
    /// <param name="request">The <see cref="IIssRequest" /> instance to use for the HTTP request.</param>
    /// <param name="serializer">The serializer to use for converting the response content into the specified type.</param>
    /// <param name="client">
    ///     The <see cref="HttpClient" /> instance to use for the HTTP request. If not provided, uses the
    ///     default <see cref="IssSettings.HttpClient" /> instance.
    /// </param>
    /// <param name="cancellationToken">
    ///     The <see cref="CancellationToken" /> to use for the HTTP request. Default is
    ///     <see cref="CancellationToken.None" />.
    /// </param>
    /// <returns>The response content converted into the specified type.</returns>
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
    ///     Converts HTTP response content into a <see cref="PagedCursor{T}" /> of <see cref="Page" /> objects asynchronously.
    /// </summary>
    /// <param name="request">The <see cref="IIssRequest" /> instance to use for the HTTP request.</param>
    /// <param name="cursorTitle">
    ///     The title of the cursor to use for pagination. Default is null, in which case the first
    ///     cursor in the response will be used.
    /// </param>
    /// <param name="index">
    ///     The index of the page to retrieve. Default is null, in which case the index from the cursor will be
    ///     used.
    /// </param>
    /// <param name="total">
    ///     The total number of pages to retrieve. Default is null, in which case the total from the cursor
    ///     will be used.
    /// </param>
    /// <param name="pageSize">The page size to use for pagination. Default is <see cref="PageSize.Twenty" />.</param>
    /// <param name="client">
    ///     The <see cref="HttpClient" /> instance to use for the HTTP request. If not provided, uses the
    ///     default <see cref="IssSettings.HttpClient" /> instance.
    /// </param>
    /// <param name="cancellationToken">
    ///     The <see cref="CancellationToken" /> to use for the HTTP request. Default is
    ///     <see cref="CancellationToken.None" />.
    /// </param>
    /// <returns>A <see cref="PagedCursor{T}" /> of <see cref="Page" /> object.</returns>
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

        var extendedJson = !string.IsNullOrEmpty(jsonFormat) &&
                           jsonFormat.Equals(Constants.Extended, StringComparison.OrdinalIgnoreCase);

        var serializer = extendedJson
            ? IssSettings.PageExtendedJsonSerializerInstance
            : IssSettings.PageCompactJsonSerializerInstance;

        return await request.ToCursor<Page>(serializer, cursorTitle, index, total, pageSize, client, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    ///     Converts an IIssRequest object to a PagedCursor object, which can be used to iterate through a collection of items
    ///     in a paged manner.
    /// </summary>
    /// <typeparam name="TResult">The type of the items in the paged collection.</typeparam>
    /// <param name="request">The <see cref="IIssRequest" /> instance to use for the HTTP request.</param>
    /// <param name="serializer">The IHttpContentSerializer used to deserialize the response content.</param>
    /// <param name="cursorTitle">
    ///     The title of the cursor to use for pagination. Default is null, in which case the first
    ///     cursor in the response will be used.
    /// </param>
    /// <param name="index">
    ///     The index of the page to retrieve. Default is null, in which case the index from the cursor will be
    ///     used.
    /// </param>
    /// <param name="total">
    ///     The total number of pages to retrieve. Default is null, in which case the total from the cursor
    ///     will be used.
    /// </param>
    /// <param name="pageSize">The page size to use for pagination. Default is <see cref="PageSize.Twenty" />.</param>
    /// <param name="client">
    ///     The <see cref="HttpClient" /> instance to use for the HTTP request. If not provided, uses the
    ///     default <see cref="IssSettings.HttpClient" /> instance.
    /// </param>
    /// <param name="cancellationToken">
    ///     The <see cref="CancellationToken" /> to use for the HTTP request. Default is
    ///     <see cref="CancellationToken.None" />.
    /// </param>
    /// <returns>A <see cref="PagedCursor{T}" /> object.</returns>
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

        var cursors = await request
            .ConvertToAsync<Dictionary<string, Cursor>>(cursorConverter, client, cancellationToken)
            .ConfigureAwait(false);

        ArgumentNullException.ThrowIfNull(cursors);

        var cursor = string.IsNullOrEmpty(cursorTitle)
            ? cursors.FirstOrDefault().Value
            : cursors.FirstOrDefault(kvp => kvp.Key.Equals(cursorTitle, StringComparison.OrdinalIgnoreCase)).Value;

        var cursorIndex = index ?? cursor.Index;
        var cursorTotal = total ?? cursor.Total;
        var url = request.ToString() ?? string.Empty;

        return new PagedCursor<TResult>(cursorIndex, cursorTotal, pageSize, url, serializer, client);
    }
}