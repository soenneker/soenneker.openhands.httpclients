using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.OpenHands.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.OpenHands.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class OpenHandsOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="OpenHandsOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddOpenHandsOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IOpenHandsOpenApiHttpClient, OpenHandsOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="OpenHandsOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddOpenHandsOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IOpenHandsOpenApiHttpClient, OpenHandsOpenApiHttpClient>();

        return services;
    }
}
