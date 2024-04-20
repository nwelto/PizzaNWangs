using Microsoft.EntityFrameworkCore;
using PizzaNWangs.Data;
using PizzaNWangs.Models;
using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaNWangs.API
{
    public static class OrderAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapPost("/orders", async (PizzaNWangsDbContext db, Order order) =>
            {
                if (string.IsNullOrEmpty(order.CustomerPhone) || string.IsNullOrEmpty(order.CustomerEmail) || string.IsNullOrEmpty(order.OrderType))
                {
                    return Results.BadRequest("Missing required order details.");
                }

                order.OrderStatus = OrderStatus.Open;

                foreach (var item in order.OrderItems)
                {
                    var menuItem = await db.MenuItems.FindAsync(item.MenuItemId);
                    if (menuItem == null)
                    {
                        return Results.BadRequest($"MenuItem with ID {item.MenuItemId} not found.");
                    }
                    db.OrderItems.Add(item);
                }

                db.Orders.Add(order);
                await db.SaveChangesAsync();
                return Results.Created($"/orders/{order.Id}", order);
            });

            app.MapGet("/orders/{id}", async (PizzaNWangsDbContext db, int id) =>
            {
                var order = await db.Orders.Include(o => o.OrderItems)
                                           .ThenInclude(oi => oi.MenuItem)
                                           .FirstOrDefaultAsync(o => o.Id == id);

                if (order == null) return Results.NotFound();

                return Results.Ok(order);
            });

            app.MapGet("/orders", async (PizzaNWangsDbContext db) =>
            {
                var orders = await db.Orders.Include(o => o.OrderItems)
                                            .ThenInclude(oi => oi.MenuItem)
                                            .ToListAsync();
                return Results.Ok(orders);
            });

            app.MapPatch("/orders/{id}", async (PizzaNWangsDbContext db, int id, OrderUpdateDTO updateDTO) =>
            {
                Console.WriteLine($"Received PATCH request for order with ID: {id}");

                var orderToUpdate = await db.Orders
                    .Include(o => o.OrderItems)
                        .ThenInclude(oi => oi.MenuItem)
                    .FirstOrDefaultAsync(o => o.Id == id);

                if (orderToUpdate == null)
                {
                    Console.WriteLine($"Order with ID {id} not found.");
                    return Results.NotFound($"Order with ID {id} not found.");
                }
                else
                {
                    Console.WriteLine($"Found order with ID {id}.");
                }

                Console.WriteLine($"Request data: {JsonSerializer.Serialize(updateDTO)}");

                orderToUpdate.CustomerPhone = updateDTO.CustomerPhone;
                orderToUpdate.CustomerEmail = updateDTO.CustomerEmail;

                if (!string.IsNullOrWhiteSpace(updateDTO.OrderType))
                {
                    orderToUpdate.OrderType = updateDTO.OrderType;
                }

                if (!string.IsNullOrWhiteSpace(updateDTO.OrderStatusString) && Enum.TryParse<OrderStatus>(updateDTO.OrderStatusString, out var orderStatus))
                {
                    orderToUpdate.OrderStatus = orderStatus;
                }


                foreach (var itemDto in updateDTO.OrderItems)
                {
                    var item = orderToUpdate.OrderItems.FirstOrDefault(oi => oi.MenuItemId == itemDto.MenuItemId);
                    if (item != null)
                    {
                        item.Quantity = itemDto.Quantity;
                    }
                    else
                    {
                        if (await db.MenuItems.AnyAsync(mi => mi.Id == itemDto.MenuItemId))
                        {
                            orderToUpdate.OrderItems.Add(new OrderItem { OrderId = id, MenuItemId = itemDto.MenuItemId, Quantity = itemDto.Quantity });
                        }
                        else
                        {
                            return Results.BadRequest($"MenuItem with ID {itemDto.MenuItemId} does not exist.");
                        }
                    }
                }

                await db.SaveChangesAsync();

                return Results.Ok(orderToUpdate);
            });



            app.MapDelete("/orders/{id}", async (PizzaNWangsDbContext db, int id) =>
            {
                var orderToDelete = await db.Orders.FindAsync(id);
                if (orderToDelete == null)
                {
                    return Results.NotFound($"Order with ID {id} not found.");
                }

                db.Orders.Remove(orderToDelete);
                await db.SaveChangesAsync();

                return Results.Ok($"Order with ID {id} has been successfully deleted.");
            });
        }
    }
}


