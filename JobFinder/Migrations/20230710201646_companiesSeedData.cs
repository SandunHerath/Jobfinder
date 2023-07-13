using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class companiesSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "ID", "CreatedAt", "IsActive", "Name", "Size", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2630), true, "MIT", "Largeer", new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2642) },
                    { 2L, new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2645), true, "HasthiyaIT", "Small", new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2646) },
                    { 3L, new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2648), true, "Creative Software", "Large", new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2648) },
                    { 4L, new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2649), true, "GTN", "Medium", new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2650) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4L);
        }
    }
}
