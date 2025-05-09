using ECommerce.Application.Contract.Interfaces.Catalog;
using ECommerce.Application.Services.Catalog;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Application;

public static class ApplicationServiceSetup
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IFeatureService, FeatureService>();
    }
}
