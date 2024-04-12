using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaNWangs.Migrations
{
    public partial class FixedUidIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "ProfilePic", "Uid" },
                values: new object[] { "amuro@whitebase.com", "Amuro", "Ray", "url-to-amuro-pic", "amuro-ray-uid" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "ProfilePic", "Uid" },
                values: new object[] { "char@zeon.com", "Char", "Aznable", "url-to-char-pic", "char-aznable-uid" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "ProfilePic", "Uid" },
                values: new object[] { "kamille@aeug.com", "Kamille", "Bidan", "url-to-kamille-pic", "kamille-bidan-uid" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "ProfilePic", "Uid" },
                values: new object[] { "judau@junkyard.com", "Judau", "Ashta", "url-to-judau-pic", "judau-ashta-uid" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Users");

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
                columns: new[] { "Email", "FirstName", "LastName", "ProfilePic" },
                values: new object[] { "user1@pizzanwangs.com", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "ProfilePic" },
                values: new object[] { "user2@pizzanwangs.com", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "ProfilePic" },
                values: new object[] { "user3@pizzanwangs.com", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "ProfilePic" },
                values: new object[] { "user4@pizzanwangs.com", "", "", "" });
        }
    }
}
