using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaNWangs.Migrations
{
    public partial class AnotherOrderRev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8602), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8602), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8602), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8602), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8804), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8808), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8811), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8814), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8817), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8820), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8823), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 4, 12, 22, 37, 31, 525, DateTimeKind.Utc).AddTicks(8827) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(4925), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(4925), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(4925), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(4925), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5126), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5130), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5133), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5136), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5139), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5142), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5145), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5148), new DateTime(2024, 4, 12, 22, 23, 8, 137, DateTimeKind.Utc).AddTicks(5148) });
        }
    }
}
