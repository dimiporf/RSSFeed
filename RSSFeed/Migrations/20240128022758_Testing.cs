using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RSSFeed.Migrations
{
    /// <inheritdoc />
    public partial class Testing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "NewsItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsItems",
                table: "NewsItems",
                column: "Guid");

            migrationBuilder.InsertData(
                table: "NewsItems",
                columns: new[] { "Guid", "Description", "ImageUrl", "Link", "Title" },
                values: new object[,]
                {
                    { new Guid("8a7b8f00-86ef-4896-b803-d70f697eb9f2"), "This is a dummy news entry 2", "https://example.com/image2.jpg", "https://example.com", "Dummy News 2" },
                    { new Guid("e87afd29-5967-4a85-84b2-2e0ff53eb443"), "This is a dummy news entry 1", "https://example.com/image1.jpg", "https://example.com", "Dummy News 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsItems",
                table: "NewsItems");

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Guid",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("8a7b8f00-86ef-4896-b803-d70f697eb9f2"));

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Guid",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("e87afd29-5967-4a85-84b2-2e0ff53eb443"));

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "NewsItems");
        }
    }
}
