namespace PizzaNWangs.Models
{
    public class OrderRevDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}

