namespace MovieTickets.CostAnalyzer.Models
{
    public class AdultTicket : Ticket
    {
        public override TicketType TicketType => TicketType.Adult;

        public override decimal Price { get; set; } = TicketPriceConstants.AdultTicketPrice;
        public override decimal Discount { get; set; } = TicketPriceConstants.StandardTicketDiscount;
    }
}