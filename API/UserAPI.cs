using PizzaNWangs.Models; 
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using PizzaNWangs.Data;

namespace PizzaNWangs.API 
{
    public static class UserAPI
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/checkuser/{uid}", (PizzaNWangsDbContext db, string uid) =>
            {
                var user = db.Users.Where(user => user.Uid == uid).ToList();

                if (user == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(user);
                }
            });


            app.MapPost("/user", (PizzaNWangsDbContext db, User newUser) => 
            {
                db.Users.Add(newUser);
                db.SaveChanges();
                return Results.Created($"/user/{newUser.Id}", newUser);
            });

        }
    }
}

