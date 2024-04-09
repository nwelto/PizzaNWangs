﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PizzaNWangs.Data;

#nullable disable

namespace PizzaNWangs.Migrations
{
    [DbContext(typeof(PizzaNWangsDbContext))]
    [Migration("20240409020522_UpdateModels")]
    partial class UpdateModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PizzaNWangs.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Available")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Available = true,
                            Description = "A delicious classic pizza with cheese and tomato sauce.",
                            Name = "Classic Pizza",
                            Price = 10.99m
                        },
                        new
                        {
                            Id = 2,
                            Available = true,
                            Description = "Smokey BBQ wings.",
                            Name = "BBQ Wings",
                            Price = 7.99m
                        },
                        new
                        {
                            Id = 3,
                            Available = true,
                            Description = "Loaded with fresh vegetables.",
                            Name = "Veggie Pizza",
                            Price = 11.99m
                        },
                        new
                        {
                            Id = 4,
                            Available = true,
                            Description = "Wings with a spicy kick.",
                            Name = "Spicy Wings",
                            Price = 8.99m
                        });
                });

            modelBuilder.Entity("PizzaNWangs.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("integer");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            CustomerEmail = "user1@pizzanwangs.com",
                            CustomerPhone = "123-456-7890",
                            OrderStatus = 1,
                            OrderType = "Takeout",
                            UpdatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            CustomerEmail = "user2@pizzanwangs.com",
                            CustomerPhone = "234-567-8901",
                            OrderStatus = 1,
                            OrderType = "Delivery",
                            UpdatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            CustomerEmail = "user3@pizzanwangs.com",
                            CustomerPhone = "345-678-9012",
                            OrderStatus = 1,
                            OrderType = "Takeout",
                            UpdatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            CustomerEmail = "user4@pizzanwangs.com",
                            CustomerPhone = "456-789-0123",
                            OrderStatus = 2,
                            OrderType = "Delivery",
                            UpdatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            UserId = 4
                        });
                });

            modelBuilder.Entity("PizzaNWangs.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MenuItemId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            MenuItemId = 1,
                            OrderId = 1,
                            UpdatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            MenuItemId = 2,
                            OrderId = 2,
                            UpdatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            MenuItemId = 3,
                            OrderId = 3,
                            UpdatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718),
                            MenuItemId = 4,
                            OrderId = 4,
                            UpdatedAt = new DateTime(2024, 4, 9, 2, 5, 22, 624, DateTimeKind.Utc).AddTicks(9718)
                        });
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "user1@pizzanwangs.com"
                        },
                        new
                        {
                            Id = 2,
                            Email = "user2@pizzanwangs.com"
                        },
                        new
                        {
                            Id = 3,
                            Email = "user3@pizzanwangs.com"
                        },
                        new
                        {
                            Id = 4,
                            Email = "user4@pizzanwangs.com"
                        });
                });

            modelBuilder.Entity("PizzaNWangs.Models.Order", b =>
                {
                    b.HasOne("User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PizzaNWangs.Models.OrderItem", b =>
                {
                    b.HasOne("PizzaNWangs.Models.MenuItem", "MenuItem")
                        .WithMany("OrderItems")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaNWangs.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("PizzaNWangs.Models.MenuItem", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("PizzaNWangs.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
