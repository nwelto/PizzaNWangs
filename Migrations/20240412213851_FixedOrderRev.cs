using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaNWangs.Migrations
{
    public partial class FixedOrderRev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "CustomerEmail", "CustomerPhone", "OrderStatus", "OrderType", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1936), "user5@pizzanwangs.com", "567-890-1234", 2, "Takeout", new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1936), null },
                    { 6, new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1962), "user6@pizzanwangs.com", "678-901-2345", 1, "Delivery", new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1962), null },
                    { 7, new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1965), "user7@pizzanwangs.com", "789-012-3456", 2, "Takeout", new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1965), null },
                    { 8, new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1968), "user8@pizzanwangs.com", "890-123-4567", 0, "Delivery", new DateTime(2024, 4, 12, 21, 38, 51, 288, DateTimeKind.Utc).AddTicks(1969), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862), new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862), new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862), new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862), new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862), new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862), new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862), new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862), new DateTime(2024, 4, 11, 1, 8, 39, 54, DateTimeKind.Utc).AddTicks(3862) });
        }
    }
}
