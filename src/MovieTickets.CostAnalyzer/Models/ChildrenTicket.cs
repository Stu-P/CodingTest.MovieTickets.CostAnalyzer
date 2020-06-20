namespace MovieTickets.CostAnalyzer.Models
{
    public class ChildrenTicket : Ticket
    {
        public override TicketType TicketType => TicketType.Children;
        public override decimal Price { get; set; } = TicketPriceConstants.ChildTicketPrice;
        public override decimal Discount { get; set; } = TicketPriceConstants.ChildTicketDiscount;
        public override int QuantityNeededForDiscount => 3;
    }
}