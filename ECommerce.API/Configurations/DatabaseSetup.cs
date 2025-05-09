using ECommerce.Infrastructure.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Configurations;

public static class DatabaseSetup
{
    public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
    {
        if (services == null)
            throw new ArgumentNullException(nameof(services));

        string connString = configuration.GetConnectionString("ECommerceDbConnectionString");

        services.AddDbContext<ECommerceContext>(options =>
        {
            options.UseSqlServer(connString,
            sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure();
            });
        });
    }
}
