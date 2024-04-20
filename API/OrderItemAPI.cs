using Microsoft.EntityFrameworkCore;
using PizzaNWangs.Data;
using PizzaNWangs.Models;
using System;

namespace PizzaNWangs.API
{
    public static class OrderItemAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapPost("/orderItems", (PizzaNWangsDbContext db, int orderId, int menuItemId) =>
            {
                var orderExists = db.Orders.Any(o => o.Id == orderId);
                if (!orderExists)
                {
                    return Results.NotFound($"Order with ID {orderId} not found.");
                }

                var menuItemExists = db.MenuItems.Any(mi => mi.Id == menuItemId);
                if (!menuItemExists)
                {
                    return Results.NotFound($"MenuItem with ID {menuItemId} not found.");
                }

                var orderItem = new OrderItem
                {
                    OrderId = orderId,
                    MenuItemId = menuItemId
                };

                db.OrderItems.Add(orderItem);
                db.SaveChanges();

                return Results.Created($"/orderItems/{orderItem.Id}", orderItem);
            });

            app.MapDelete("/orderItems/{id}", (PizzaNWangsDbContext db, int id) =>
            {
                var orderItemToDelete = db.OrderItems.FirstOrDefault(oi => oi.Id == id);
                if (orderItemToDelete == null)
                {
                    return Results.NotFound($"OrderItem with ID {id} not found.");
                }

                db.OrderItems.Remove(orderItemToDelete);
                db.SaveChanges();

                return Results.Ok($"OrderItem with ID {id} has been successfully deleted.");
            });

            app.MapGet("/orderItems/order/{orderId}", async (PizzaNWangsDbContext db, int orderId) =>
            {
                var orderItems = await db.OrderItems
                                         .Where(oi => oi.OrderId == orderId)
                                         .Include(oi => oi.MenuItem)
                                         .ToListAsync();

                if (!orderItems.Any())
                {
                    return Results.NotFound($"No items found for Order ID {orderId}.");
                }

                return Results.Ok(orderItems);
            });

        }
    }
}



