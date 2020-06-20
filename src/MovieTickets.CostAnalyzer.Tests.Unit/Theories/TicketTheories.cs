using MovieTickets.CostAnalyzer.Models;

namespace MovieTickets.CostAnalyzer.Tests.Unit.Theories
{
    public class TicketTheories : Xunit.TheoryData<string, TicketTheoryData>
    {
        public TicketTheories()
        {
            ManyAdultTickets_NoDiscount();
            SingleTeenTickets_NoDiscount();
            SingleSeniorTickets_HasDiscount();
            ChildrenTicketsUnderMinQuantityForDiscount_NoDiscount();
            ChildrenTicketsAtMinQuantityForDiscount_HasDiscount();
        }

        private void ManyAdultTickets_NoDiscount()
        {
            Add(nameof(ManyAdultTickets_NoDiscount), new TicketTheoryData
            {
                Input = new AdultTicket(),
                ExpectedDiscountPrice = TicketPriceConstants.AdultTicketPrice,
                QuantityPurchased = 2
            });
        }

        private void SingleTeenTickets_NoDiscount()
        {
            Add(nameof(SingleTeenTickets_NoDiscount), new TicketTheoryData
            {
                Input = new AdultTicket(),
                ExpectedDiscountPrice = TicketPriceConstants.AdultTicketPrice,
                QuantityPurchased = 1
            });
        }

        private void SingleSeniorTickets_HasDiscount()
        {
            Add(nameof(SingleSeniorTickets_HasDiscount), new TicketTheoryData
            {
                Input = new SeniorTicket { Price = 5, Discount = 0.2m },
                ExpectedDiscountPrice = 4,
                QuantityPurchased = 1
            });
        }

        private void ChildrenTicketsUnderMinQuantityForDiscount_NoDiscount()
        {
            Add(nameof(ChildrenTicketsUnderMinQuantityForDiscount_NoDiscount), new TicketTheoryData
            {
                Input = new ChildrenTicket { Price = 4, Discount = 0.25m },
                ExpectedDiscountPrice = 4,
                QuantityPurchased = 2
            });
        }

        private void ChildrenTicketsAtMinQuantityForDiscount_HasDiscount()
        {
            Add(nameof(ChildrenTicketsAtMinQuantityForDiscount_HasDiscount), new TicketTheoryData
            {
                Input = new ChildrenTicket { Price = 4, Discount = 0.25m },
                ExpectedDiscountPrice = 3,
                QuantityPurchased = 3
            });
        }
    }

    public class TicketTheoryData
    {
        public Ticket Input { get; set; }
        public int QuantityPurchased { get; set; }
        public decimal ExpectedDiscountPrice { get; set; }
    }
}