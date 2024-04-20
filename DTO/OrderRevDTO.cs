namespace PizzaNWangs.Models
{
    public class OrderRevDTO
    {

        public decimal TotalRevenue { get; set; }
        public int ClosedOrdersCount { get; set; }
        public decimal LostSales { get; set; } 
        public int OpenOrdersCount { get; set; }
        public decimal PotentialRevenue { get; set; } 
        public int PaidOrdersCount { get; set; } 
    }
}



