using Microsoft.EntityFrameworkCore;
using PizzaNWangs.Data;
using PizzaNWangs.Models;
using System;

namespace PizzaNWangs.API
{
    public static class MenuItemAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapPost("/menuitems", (PizzaNWangsDbContext db, MenuItem menuItem) =>
            {
                if (string.IsNullOrEmpty(menuItem.Name) || menuItem.Price <= 0)
                {
                    return Results.BadRequest("Missing required menu item details.");
                }

                db.MenuItems.Add(menuItem);
                db.SaveChanges();
                return Results.Created($"/menuitems/{menuItem.Id}", menuItem);
            });

            app.MapGet("/menuitems/{id}", (PizzaNWangsDbContext db, int id) =>
            {
                var menuItem = db.MenuItems.Find(id);

                if (menuItem == null) return Results.NotFound();

                return Results.Ok(menuItem);
            });

            app.MapGet("/menuitems", (PizzaNWangsDbContext db) =>
            {
                var menuItems = db.MenuItems.ToList();
                return Results.Ok(menuItems);
            });

            app.MapPut("/menuitems/{id}", (PizzaNWangsDbContext db, int id, MenuItem updatedMenuItem) =>
            {
                var menuItem = db.MenuItems.Find(id);
                if (menuItem == null) return Results.NotFound($"MenuItem with ID {id} not found.");

                menuItem.Name = updatedMenuItem.Name;
                menuItem.Price = updatedMenuItem.Price;
                menuItem.Description = updatedMenuItem.Description;
                menuItem.Available = updatedMenuItem.Available;

                db.SaveChanges();
                return Results.Ok(menuItem);
            });

            app.MapDelete("/menuitems/{id}", (PizzaNWangsDbContext db, int id) =>
            {
                var menuItem = db.MenuItems.Find(id);
                if (menuItem == null)
                {
                    return Results.NotFound($"MenuItem with ID {id} not found.");
                }

                db.MenuItems.Remove(menuItem);
                db.SaveChanges();

                return Results.Ok($"MenuItem with ID {id} has been successfully deleted.");
            });



        }
    }
}

