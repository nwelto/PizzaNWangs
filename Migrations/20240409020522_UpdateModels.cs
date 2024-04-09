using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PizzaNWangs.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Available = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CustomerPhone = table.Column<string>(type: "text", nullable: false),
                    CustomerEmail = table.Column<string>(type: "text", nullable: false),
                    OrderType = table.Column<string>(type: "text", nullable: false),
                    OrderStatus = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    MenuItemId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Available", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, true, "A delicious classic pizza with cheese and tomato sauce.", "Classic Pizza", 10.99m },
                    { 2, true, "Smokey BBQ wings.", "BBQ Wings", 7.99m },
                    { 3, true, "Loaded with fresh vegetables.", "Veggie Pizza", 11.99m },
                    { 4, true, "Wings with a spicy kick.", "Spicy Wings", 8.99m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email" },
                values: new object[,]
                {
                    { 1, "user1@pizzanwangs.com" },
                    { 2, "user2@pizzanwangs.com" },
                    { 3, "user3@pizzanwangs.com" },
                    { 4, "user4@pizzanwangs.com" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "CustomerEmail", "CustomerPhone", "OrderStatus", "OrderType", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), "user1@pizzanwangs.com", "123-456-7890", 1, "Takeout", new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), 1 },
                    { 2, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), "user2@pizzanwangs.com", "234-567-8901", 1, "Delivery", new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), 2 },
                    { 3, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), "user3@pizzanwangs.com", "345-678-9012", 1, "Takeout", new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), 3 },
                    { 4, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), "user4@pizzanwangs.com", "456-789-0123", 2, "Delivery", new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), 4 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "MenuItemId", "OrderId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), 1, 1, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718) },
                    { 2, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), 2, 2, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718) },
                    { 3, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), 3, 3, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718) },
                    { 4, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718), 4, 4, new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_MenuItemId",
                table: "OrderItems",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
