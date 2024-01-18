using RainfallApi.Services.Implementation;
using RainfallApi.Services.Interface;
using RainfallApi.Services.Model;

namespace Rainfall_Api.Infrastructure;
public static class RainfallApiExtention
{
    public static IServiceCollection AddConfig(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<RainFallSettings>(config.GetSection(RainFallSettings.Key));
        return services;
    }

    public static IServiceCollection AddDependencyGroup(this IServiceCollection services)
    {
       services.AddHttpClient<IFloodService, FloodService>();
        return services;
    }

    public static IApplicationBuilder UseClientTracking(this IApplicationBuilder app)
    {
        if (app == null)
        {
            throw new ArgumentException(nameof(app));
        }
        return app;
    }
}