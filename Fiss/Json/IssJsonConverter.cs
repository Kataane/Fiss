using Fiss.Response;

namespace Fiss.Json;

public abstract class IssJsonConverter<TResult>
{
    /// <summary>
    /// Reads the JSON representation of the object.
    /// </summary>
    /// <returns>The object value.</returns>
    public abstract Task<TResult?> ReadJson(IIssResponse issResponse);
}