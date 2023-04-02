using System.Net;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides extension methods to add MoexPassportClient to IServiceCollection.
/// </summary>
public static class ServiceCollectionExtensions
{
    private static readonly Uri passportMoexUri = new("https://passport.moex.com");

    /// <summary>
    /// Adds a named HTTP client for MoexPassport authentication to the <see cref="IServiceCollection"/> with the provided <paramref name="clientName"/> and <paramref name="authenticationSection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the client to.</param>
    /// <param name="clientName">The name of the client to add.</param>
    /// <param name="authenticationSection">The configuration section containing the email and password for authentication.</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> that can be used to further configure the HTTP client.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="services"/> or <paramref name="authenticationSection"/> is null.</exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="clientName"/> is null or empty.</exception>
    public static IHttpClientBuilder AddMoexPassportClient(this IServiceCollection services, string clientName, IConfigurationSection authenticationSection)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentException.ThrowIfNullOrEmpty(clientName);
        ArgumentNullException.ThrowIfNull(authenticationSection);

        var credentials = new NetworkCredential(authenticationSection["email"], authenticationSection["password"]);
        var handler = new HttpClientHandler { Credentials = credentials };
        var passportClient = new HttpClient(handler) { BaseAddress = passportMoexUri };

        var webRequest = new HttpRequestMessage(HttpMethod.Get, "/authenticate");
        var loginResponse = passportClient.Send(webRequest);
        loginResponse.EnsureSuccessStatusCode();
        var headers = loginResponse.Headers;

        return services.AddHttpClient(clientName, client =>
        {
            client.DefaultRequestHeaders.Add("User-Agent", IssSettings.FormattedCurrentVersion);
            foreach (var header in headers)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }
        });
    }

    /// <summary>
    /// Adds a named HTTP client for MoexPassport authentication to the <see cref="IServiceCollection"/> with the provided <paramref name="clientName"/>, <paramref name="authenticationSection"/>, and <paramref name="configureClient"/> delegate.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the client to.</param>
    /// <param name="clientName">The name of the client to add.</param>
    /// <param name="authenticationSection">The configuration section containing the email and password for authentication.</param>
    /// <param name="configureClient">The delegate used to configure the <see cref="HttpClient"/> instance.</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> that can be used to further configure the HTTP client.</returns>
    public static IHttpClientBuilder AddMoexPassportClient(this IServiceCollection services, string clientName, IConfigurationSection authenticationSection, Action<HttpClient> configureClient)
    {
        return services.AddMoexPassportClient(clientName, authenticationSection).ConfigureHttpClient(configureClient);
    }
}
