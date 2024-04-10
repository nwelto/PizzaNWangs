using Microsoft.EntityFrameworkCore;
using PizzaNWangs.Data;
using PizzaNWangs.Models;
using System;

namespace PizzaNWangs.API
{
    public static class OrderAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapPost("/orders", (PizzaNWangsDbContext db, Order order) =>
            {


                if (string.IsNullOrEmpty(order.CustomerPhone) || string.IsNullOrEmpty(order.CustomerEmail) || string.IsNullOrEmpty(order.OrderType))
                {
                    return Results.BadRequest("Missing required order details.");
                }

                order.CreatedAt = DateTime.Now;
                order.UpdatedAt = DateTime.Now;
                order.OrderStatus = OrderStatus.Open; 

                db.Orders.Add(order);
                db.SaveChanges();
                return Results.Created($"/orders/{order.Id}", order);
            });

            app.MapGet("/orders/{id}", (PizzaNWangsDbContext db, int id) =>
            {
                var order = db.Orders.Include(o => o.OrderItems)
                                     .ThenInclude(oi => oi.MenuItem)
                                     .FirstOrDefault(o => o.Id == id);

                if (order == null) return Results.NotFound();

                return Results.Ok(order);
            });
            app.MapGet("/orders", (PizzaNWangsDbContext db) =>
            {
                var orders = db.Orders.Include(o => o.OrderItems)
                                      .ThenInclude(oi => oi.MenuItem)
                                      .ToList();
                return Results.Ok(orders);
            });
            app.MapPatch("/orders/{id}", (PizzaNWangsDbContext db, int id, string customerPhone, string customerEmail, string? orderType, string? orderStatusString) =>
            {
                var orderToUpdate = db.Orders.FirstOrDefault(o => o.Id == id);

                if (orderToUpdate == null)
                {
                    return Results.NotFound($"Order with ID {id} not found.");
                }

                orderToUpdate.CustomerPhone = customerPhone;
                orderToUpdate.CustomerEmail = customerEmail;

                if (!string.IsNullOrWhiteSpace(orderType))
                {
                    orderToUpdate.OrderType = orderType;
                }

                if (!string.IsNullOrWhiteSpace(orderStatusString) && Enum.TryParse<OrderStatus>(orderStatusString, out var orderStatus))
                {
                    orderToUpdate.OrderStatus = orderStatus;
                }

                db.SaveChanges();
                return Results.Ok(orderToUpdate);
            });

            app.MapDelete("/orders/{id}", (PizzaNWangsDbContext db, int id) =>
            {
                var orderToDelete = db.Orders.FirstOrDefault(o => o.Id == id);
                if (orderToDelete == null)
                {
                    return Results.NotFound($"Order with ID {id} not found.");
                }

                db.Orders.Remove(orderToDelete);
                db.SaveChanges();

                return Results.Ok($"Order with ID {id} has been successfully deleted.");
            });



        }
    }
}

