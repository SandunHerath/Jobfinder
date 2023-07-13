using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class changeType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JobType",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 14, 20, 40, 29, DateTimeKind.Local).AddTicks(8834), new DateTime(2023, 7, 11, 14, 20, 40, 29, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 14, 20, 40, 29, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 7, 11, 14, 20, 40, 29, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 14, 20, 40, 29, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 7, 11, 14, 20, 40, 29, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 14, 20, 40, 29, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 7, 11, 14, 20, 40, 29, DateTimeKind.Local).AddTicks(8850) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "JobType",
                table: "Jobs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2645), new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2648), new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 7, 11, 1, 46, 46, 240, DateTimeKind.Local).AddTicks(2650) });
        }
    }
}
