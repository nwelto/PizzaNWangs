using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaNWangs.Migrations
{
    public partial class AddedGetOrderItemsCall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
