using System.Collections.Generic;

namespace MovieTickets.CostAnalyzer.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public IEnumerable<Customer> Customers { get; set; } = new List<Customer>();
    }
}