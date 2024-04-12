using Microsoft.EntityFrameworkCore;
using PizzaNWangs.Data;
using PizzaNWangs.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace PizzaNWangs.API
{
    public static class RevenueAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/revenue", async (PizzaNWangsDbContext db, DateTime? start, DateTime? end) =>
            {
                var query = db.Orders.AsQueryable();

                if (start.HasValue && end.HasValue)
                {
                    query = query.Where(o => o.CreatedAt >= start.Value && o.CreatedAt <= end.Value);
                }

                var totalRevenue = await query
                    .Where(o => o.OrderStatus == OrderStatus.Paid)
                    .SumAsync(o => o.OrderItems.Sum(oi => oi.MenuItem.Price));

                var closedOrdersCount = await query
                    .CountAsync(o => o.OrderStatus == OrderStatus.Closed);

                var openOrdersCount = await query
                    .CountAsync(o => o.OrderStatus == OrderStatus.Open);

                var revenueData = new OrderRevDTO
                {
                    StartDate = start ?? DateTime.MinValue,
                    EndDate = end ?? DateTime.MaxValue,
                    TotalRevenue = totalRevenue,
                    ClosedOrdersCount = closedOrdersCount,
                    OpenOrdersCount = openOrdersCount
                };

                return Results.Ok(revenueData);
            });
        }
    }
}

