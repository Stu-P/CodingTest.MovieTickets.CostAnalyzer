namespace MovieTickets.CostAnalyzer.Models
{
    public abstract class Ticket
    {
        public abstract TicketType TicketType { get; }
        public abstract decimal Price { get; set; }
        public abstract decimal Discount { get; set; }

        public virtual int QuantityNeededForDiscount => 0;

        public decimal ApplyDiscount(int quantityPurchased) => Discount > 0 && quantityPurchased >= QuantityNeededForDiscount ? Price - (Price * Discount) : Price;
    }
}