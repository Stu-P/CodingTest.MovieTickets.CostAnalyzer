namespace MovieTickets.CostAnalyzer.Models
{
    public class TeenTicket : Ticket
    {
        public override TicketType TicketType => TicketType.Teen;
        public override decimal Price { get; set; } = TicketPriceConstants.TeenTicketPrice;
        public override decimal Discount { get; set; } = TicketPriceConstants.StandardTicketDiscount;
    }
}