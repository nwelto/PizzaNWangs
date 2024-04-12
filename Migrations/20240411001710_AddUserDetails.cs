using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaNWangs.Migrations
{
    public partial class AddUserDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePic",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 4, 11, 0, 17, 10, 824, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "ProfilePic" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "ProfilePic" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "ProfilePic" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "ProfilePic" },
                values: new object[] { "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 4, 10, 0, 10, 47, 48, DateTimeKind.Utc).AddTicks(1023) });
        }
    }
}
