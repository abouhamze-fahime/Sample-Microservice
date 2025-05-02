using ECommerce.Domain.Core.Catalogs.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infrastructure.Database.Configurations.Catalog;

internal sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories", "Catalog");
        builder.HasKey(c => c.Id);
        builder.Property(x => x.Id)
            .HasConversion(
            v => v.Value,
            v => new CategoryId(v));

        builder.Property(e => e.CategoryName)
            .HasMaxLength(128)
            .IsRequired();
        builder.Property(e => e.Description)
            .HasMaxLength(1024);
        builder.OwnsMany(s => s.CategoryFeatures, v =>
        {
            v.WithOwner().HasForeignKey("CategoryId");

        });
    }
}
