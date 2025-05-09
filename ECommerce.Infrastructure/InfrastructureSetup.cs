using ECommerce.Domain.Core.Catalogs.Features;
using ECommerce.Infrastructure.Patterns;
using ECommerce.Infrastructure.Repositories.Catalog;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Infrastructure;

public static  class InfrastructureSetup
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IFeatureRepository, FeatureRepository>();
    }
}
