﻿// <auto-generated />
using System;
using ECommerce.Infrastructure.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.Infrastructure.Database.Migrations.ECommerceMigrations
{
    [DbContext(typeof(ECommerceContext))]
    partial class ECommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECommerce.Domain.Core.Catalogs.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories", "Catalog");
                });

            modelBuilder.Entity("ECommerce.Domain.Core.Catalogs.Features.Feature", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Features", "Catalog");
                });

            modelBuilder.Entity("ECommerce.Domain.Core.Catalogs.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Products", "Catalog");
                });

            modelBuilder.Entity("ECommerce.Domain.Core.Catalogs.Categories.Category", b =>
                {
                    b.OwnsMany("ECommerce.Domain.Core.Catalogs.Categories.CategoryFeature", "CategoryFeatures", b1 =>
                        {
                            b1.Property<Guid>("CategoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("FeatureId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("CategoryId", "FeatureId");

                            b1.ToTable("CategoryFeatures", "Catalog");

                            b1.WithOwner()
                                .HasForeignKey("CategoryId");
                        });

                    b.Navigation("CategoryFeatures");
                });

            modelBuilder.Entity("ECommerce.Domain.Core.Catalogs.Products.Product", b =>
                {
                    b.OwnsMany("ECommerce.Domain.Core.Catalogs.Products.ProductFeatureValue", "ProductFeatureValues", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("FeatureId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ProductId", "FeatureId");

                            b1.ToTable("ProductFeatureValues", "Catalog");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("ProductFeatureValues");
                });
#pragma warning restore 612, 618
        }
    }
}
