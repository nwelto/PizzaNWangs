using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaNWangs.Migrations
{
    public partial class OrderRevUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1719), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1719), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1719), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1719), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1922), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1926), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1929), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1933), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1936), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1962), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1965), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1968), new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1969) });
        }
    }
}
