namespace MovieTickets.CostAnalyzer.Models
{
    public class TicketCostEstimate
    {
        public TicketCostEstimate(TicketType ticketType, int quantity, decimal price)
        {
            TicketType = ticketType;
            Quantity = quantity;
            Price = price;
        }

        public TicketType TicketType { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public override string ToString()
        {
            return $"{TicketType} ticket x {Quantity}: {Price:$0.00}";
        }
    }
}