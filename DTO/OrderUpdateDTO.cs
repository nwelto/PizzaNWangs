using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaNWangs.Models
{
    public class OrderUpdateDTO
    {
        [Required(ErrorMessage = "Customer phone is required.")]
        public string CustomerPhone { get; set; }

        [Required(ErrorMessage = "Customer email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string CustomerEmail { get; set; }

        public string OrderType { get; set; }
        public string OrderStatusString { get; set; }
        public List<OrderItemUpdateDTO> OrderItems { get; set; }
    }

    public class OrderItemUpdateDTO
    {
        [Required]
        public int MenuItemId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }
    }
}
