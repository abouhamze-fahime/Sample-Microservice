using ECommerce.Domain.Core.Catalogs.Features;
using ECommerce.Domain.Core.Catalogs.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infrastructure.Database.Configurations.Catalog;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products", "Catalog");
        builder.HasKey(e => e.Id);
        builder.Property(f => f.Id).
            HasConversion(v => v.Value,
                v => new ProductId(v));
        builder.Property(e => e.Title)
            .HasMaxLength(256).IsRequired();

        builder.Property(e => e.Code)
         .HasMaxLength(16).IsRequired();

        builder.OwnsMany(p => p.ProductFeatureValues, y =>
        {
            y.WithOwner().HasForeignKey("ProductId");
            y.ToTable("ProductFeatureValues", "Catalog");
            y.Property(x => x.ProductId)
               .HasConversion(
                   v => v.Value,
                   v => new ProductId(v));
            y.Property(x => x.FeatureId)
            .HasConversion(
                v => v.Value,
                v => new FeatureId(v));
            y.HasKey("ProductId", "FeatureId");
        });
    }
}
