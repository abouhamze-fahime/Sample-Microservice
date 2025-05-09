using ECommerce.Domain.Core.Catalogs.Features;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Database.Configurations.Catalog;

internal sealed class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Feature> builder)
    {
        builder.ToTable("Features", "Catalog");
        builder.HasKey(e => e.Id);
        builder.Property(f=>f.Id).
            HasConversion(v => v.Value,
                v => new FeatureId(v));
        builder.Property(e => e.Title).HasMaxLength(128).IsRequired();

        builder.Property(e => e.Description).HasMaxLength(1024);
    }
}
