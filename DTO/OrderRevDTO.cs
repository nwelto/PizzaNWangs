namespace PizzaNWangs.Models
{
    public class OrderRevDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalRevenue { get; set; }
        public int ClosedOrdersCount { get; set; }
        public int OpenOrdersCount { get; set; }
    }
}


