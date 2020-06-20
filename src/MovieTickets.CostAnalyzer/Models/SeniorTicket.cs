namespace MovieTickets.CostAnalyzer.Models
{
    public class SeniorTicket : Ticket
    {
        public override TicketType TicketType => TicketType.Senior;
        public override decimal Price { get; set; } = TicketPriceConstants.SeniorTicketPrice;
        public override decimal Discount { get; set; } = TicketPriceConstants.SeniorTicketDiscount;
    }
}