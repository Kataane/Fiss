﻿using System.Text.Json;

namespace Fiss.Json;

/// <summary>
///     Converts a JSON response into a object using the System.Text.Json library.
/// </summary>
public class SystemTextJsonConverter : IHttpContentSerializer
{
    public JsonSerializerOptions? JsonSerializerOptions { get; }

    public SystemTextJsonConverter() : this(JsonSerializerOptions.Default)
    {
    }

    public SystemTextJsonConverter(JsonSerializerOptions jsonOptionsResolver)
    {
        JsonSerializerOptions = jsonOptionsResolver;
    }

    /// <inheritdoc />
    public async Task<T?> Deserialize<T>(HttpContent content, CancellationToken cancellationToken = default)
    {
        await using var stream = await content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
        return await JsonSerializer.DeserializeAsync<T>(stream, JsonSerializerOptions, cancellationToken).ConfigureAwait(false);
    }
}
