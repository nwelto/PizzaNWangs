using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaNWangs.Migrations
{
    public partial class OrderUpdateDTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8526), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8526), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8526), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8526), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8774), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8778), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8782), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8785), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8792), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8795), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8798), new DateTime(2024, 4, 20, 7, 33, 53, 210, DateTimeKind.Utc).AddTicks(8798) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(6915), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(6915), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(6915), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(6915), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7143), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7147), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7150), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7153), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7156), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7159), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7162), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7165), new DateTime(2024, 4, 20, 6, 55, 8, 180, DateTimeKind.Utc).AddTicks(7166) });
        }
    }
}
