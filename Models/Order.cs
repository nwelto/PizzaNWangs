namespace PizzaNWangs.Models
{
    public enum OrderStatus
    {
        Open, // Active, not yet paid
        Paid, // Completed transaction
        Closed // Canceled or unfulfilled orders
    }

    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public User User { get; set; } 
        public string CustomerPhone { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string OrderType { get; set; } = string.Empty;
        public OrderStatus OrderStatus { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }


}

