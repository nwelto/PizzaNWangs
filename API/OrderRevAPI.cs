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
            app.MapGet("/revenue", async (PizzaNWangsDbContext db) =>
            {
                var query = db.Orders
                              .Include(o => o.OrderItems)
                              .ThenInclude(oi => oi.MenuItem)
                              .AsQueryable();

                var paidOrders = await query
                    .Where(o => o.OrderStatus == OrderStatus.Paid)
                    .ToListAsync();
                var totalRevenue = paidOrders.Sum(o => o.OrderItems.Sum(oi => oi.MenuItem.Price));
                var paidOrdersCount = paidOrders.Count;


                var closedOrders = await query
                    .Where(o => o.OrderStatus == OrderStatus.Closed)
                    .ToListAsync();
                var lostSales = closedOrders.Sum(o => o.OrderItems.Sum(oi => oi.MenuItem.Price));
                var closedOrdersCount = closedOrders.Count;

                var openOrders = await query
                    .Where(o => o.OrderStatus == OrderStatus.Open)
                    .ToListAsync();
                var potentialRevenue = openOrders.Sum(o => o.OrderItems.Sum(oi => oi.MenuItem.Price));
                var openOrdersCount = openOrders.Count;

                var revenueData = new OrderRevDTO
                {
                    TotalRevenue = totalRevenue,
                    ClosedOrdersCount = closedOrdersCount,
                    LostSales = lostSales,
                    OpenOrdersCount = openOrdersCount,
                    PotentialRevenue = potentialRevenue,
                    PaidOrdersCount = paidOrdersCount
                };

                return Results.Ok(revenueData);
            });
        }

    }
}


