﻿using PizzaNWangs.Models;

public class User
{
    public int Id { get; set; } 
    public string Email { get; set; } = string.Empty; 
    public List<Order> Orders { get; set; } = new List<Order>(); 
}



