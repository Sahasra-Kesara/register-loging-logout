using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoginPage.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a9d76ff-745d-4b58-bff0-f44a82f45625", null, "seller", "seller" },
                    { "b8b772c4-1073-4be9-ad7d-2140d7194f8a", null, "admin", "admin" },
                    { "fb7d3c8f-4abb-4821-9a1e-df24d865b868", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a9d76ff-745d-4b58-bff0-f44a82f45625");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8b772c4-1073-4be9-ad7d-2140d7194f8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb7d3c8f-4abb-4821-9a1e-df24d865b868");
        }
    }
}
