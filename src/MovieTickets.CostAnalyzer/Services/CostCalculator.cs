using System.Collections.Generic;
using System.Linq;
using MovieTickets.CostAnalyzer.Helpers;
using MovieTickets.CostAnalyzer.Models;

namespace MovieTickets.CostAnalyzer.Services
{
    public static class CostCalculator
    {
        public static TransactionCostEstimate EstimateTransactionCost(Transaction transaction)
        {
            var tickets = EstimateTickets(transaction.Customers);

            return new TransactionCostEstimate
            {
                TransactionId = transaction.TransactionId,
                TicketEstimates = tickets,
                TotalPriceEstimate = tickets.Sum(x => x.Price)
            };
        }

        private static IEnumerable<TicketCostEstimate> EstimateTickets(IEnumerable<Customer> customers) =>
                customers
                    .Select(x => x.GetTicketType())
                    .GroupBy(x => x.TicketType)
                    .Select(group =>
                        new TicketCostEstimate(
                            group.Key,
                            group.Count(),
                            group.Sum(i => i.ApplyDiscount(group.Count()))))
                    .OrderBy(x => x.TicketType);
    }
}