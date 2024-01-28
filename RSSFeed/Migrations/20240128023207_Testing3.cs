using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RSSFeed.Migrations
{
    /// <inheritdoc />
    public partial class Testing3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Guid",
                keyValue: new Guid("2b8f2053-1d8a-40d9-a362-4a341ddbdf9c"));

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Guid",
                keyValue: new Guid("756d12e5-2d8a-4d8a-8385-e9c1ab724304"));

            migrationBuilder.InsertData(
                table: "NewsItems",
                columns: new[] { "Guid", "Description", "ImageUrl", "Link", "Title" },
                values: new object[,]
                {
                    { new Guid("5eb65932-f0c3-4e5c-85b7-be5008ed3028"), "This is a dummy news entry 1", "https://example.com/image1.jpg", "https://example.com", "Dummy News 1" },
                    { new Guid("fab65128-b585-4324-b737-e8db56fa8fd5"), "This is a dummy news entry 2", "https://example.com/image2.jpg", "https://example.com", "Dummy News 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Guid",
                keyValue: new Guid("5eb65932-f0c3-4e5c-85b7-be5008ed3028"));

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Guid",
                keyValue: new Guid("fab65128-b585-4324-b737-e8db56fa8fd5"));

            migrationBuilder.InsertData(
                table: "NewsItems",
                columns: new[] { "Guid", "Description", "ImageUrl", "Link", "Title" },
                values: new object[,]
                {
                    { new Guid("2b8f2053-1d8a-40d9-a362-4a341ddbdf9c"), "This is a dummy news entry 2", "https://example.com/image2.jpg", "https://example.com", "Dummy News 2" },
                    { new Guid("756d12e5-2d8a-4d8a-8385-e9c1ab724304"), "This is a dummy news entry 1", "https://example.com/image1.jpg", "https://example.com", "Dummy News 1" }
                });
        }
    }
}
