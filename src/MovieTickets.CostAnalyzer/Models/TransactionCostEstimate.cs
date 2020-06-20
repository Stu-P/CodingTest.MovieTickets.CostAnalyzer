using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTickets.CostAnalyzer.Models
{
    public class TransactionCostEstimate
    {
        public int TransactionId { get; set; }
        public IEnumerable<TicketCostEstimate> TicketEstimates { get; set; } = new List<TicketCostEstimate>();
        public decimal TotalPriceEstimate { get; set; }

        public override string ToString()
        {
            return string.Join(Environment.NewLine,
                $"## Transaction {TransactionId} ##",
                string.Join(Environment.NewLine, TicketEstimates) + Environment.NewLine,
                $"Projected total cost: {TicketEstimates?.Sum(x => x.Price):$0.00}" + Environment.NewLine);
        }
    }
}