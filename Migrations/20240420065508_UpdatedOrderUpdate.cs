using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaNWangs.Migrations
{
    public partial class UpdatedOrderUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderItems");

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3579), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3584), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3587), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3590), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3593), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3596), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3599), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3601), new DateTime(2024, 4, 16, 3, 16, 11, 656, DateTimeKind.Utc).AddTicks(3602) });
        }
    }
}
