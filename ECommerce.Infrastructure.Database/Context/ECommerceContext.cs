using ECommerce.Domain.Core.Catalogs.Categories;
using ECommerce.Domain.Core.Catalogs.Features;
using ECommerce.Domain.Core.Catalogs.Products;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Database.Context;

public  class ECommerceContext:DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Product> Products { get; set; }

    public ECommerceContext(DbContextOptions<ECommerceContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ECommerceContext).Assembly);
    }
}
