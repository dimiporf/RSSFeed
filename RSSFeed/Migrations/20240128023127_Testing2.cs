using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RSSFeed.Migrations
{
    /// <inheritdoc />
    public partial class Testing2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Guid",
                keyValue: new Guid("8a7b8f00-86ef-4896-b803-d70f697eb9f2"));

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Guid",
                keyValue: new Guid("e87afd29-5967-4a85-84b2-2e0ff53eb443"));

            migrationBuilder.InsertData(
                table: "NewsItems",
                columns: new[] { "Guid", "Description", "ImageUrl", "Link", "Title" },
                values: new object[,]
                {
                    { new Guid("2b8f2053-1d8a-40d9-a362-4a341ddbdf9c"), "This is a dummy news entry 2", "https://example.com/image2.jpg", "https://example.com", "Dummy News 2" },
                    { new Guid("756d12e5-2d8a-4d8a-8385-e9c1ab724304"), "This is a dummy news entry 1", "https://example.com/image1.jpg", "https://example.com", "Dummy News 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("8a7b8f00-86ef-4896-b803-d70f697eb9f2"), "This is a dummy news entry 2", "https://example.com/image2.jpg", "https://example.com", "Dummy News 2" },
                    { new Guid("e87afd29-5967-4a85-84b2-2e0ff53eb443"), "This is a dummy news entry 1", "https://example.com/image1.jpg", "https://example.com", "Dummy News 1" }
                });
        }
    }
}
