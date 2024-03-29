﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RSSFeed.Migrations
{
    [DbContext(typeof(NewsDbContext))]
    [Migration("20240128023127_Testing2")]
    partial class Testing2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NewsItem", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("NewsItems");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("756d12e5-2d8a-4d8a-8385-e9c1ab724304"),
                            Description = "This is a dummy news entry 1",
                            ImageUrl = "https://example.com/image1.jpg",
                            Link = "https://example.com",
                            Title = "Dummy News 1"
                        },
                        new
                        {
                            Guid = new Guid("2b8f2053-1d8a-40d9-a362-4a341ddbdf9c"),
                            Description = "This is a dummy news entry 2",
                            ImageUrl = "https://example.com/image2.jpg",
                            Link = "https://example.com",
                            Title = "Dummy News 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
