namespace Fiss.Json;

/// <summary>
/// Converts an content from <see cref="HttpContent"/>.
/// </summary>
public interface IHttpContentSerializer
{
    /// <summary>
    ///     Converts a JSON response from the HTTP response into a object.
    /// </summary>
    /// <param name="content">HttpContent object to deserialize.</param>
    /// <param name="cancellationToken">CancellationToken to abort the deserialization.</param>
    /// <returns>A object representing the JSON response.</returns>
    public Task<T?> Deserialize<T>(HttpContent content, CancellationToken cancellationToken = default);
}
