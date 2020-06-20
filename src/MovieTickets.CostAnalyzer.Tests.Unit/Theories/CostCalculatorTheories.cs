using System.Collections.Generic;
using MovieTickets.CostAnalyzer.Models;

namespace MovieTickets.CostAnalyzer.Tests.Unit.Theories
{
    public class CostCalculatorTheories : Xunit.TheoryData<string, CostCalculatorTheoryData>
    {
        public CostCalculatorTheories()
        {
            TransactionWithAllCustomerTypes();
        }

        private void TransactionWithAllCustomerTypes()
        {
            Add(nameof(TransactionWithAllCustomerTypes), new CostCalculatorTheoryData
            {
                Input = new Transaction
                {
                    TransactionId = 1,
                    Customers = new List<Customer>
                        {
                        new Customer{ Name="A", Age=15 },
                        new Customer{ Name="B", Age=98 },
                        new Customer{ Name="C", Age=5 },
                        new Customer{ Name="D", Age=5 },
                        new Customer{ Name="E", Age=5 },
                        new Customer{ Name="F", Age=45 },
                    }
                },
                Estimates = new TransactionCostEstimate
                {
                    TransactionId = 1,
                    TicketEstimates = new List<TicketCostEstimate>
                    {
                        new TicketCostEstimate(TicketType.Adult, 1, 25.00m),
                        new TicketCostEstimate(TicketType.Children, 3, 11.25m),
                        new TicketCostEstimate(TicketType.Senior, 1, 17.50m),
                        new TicketCostEstimate(TicketType.Teen, 1, 12),
                    },
                    TotalPriceEstimate = 65.75m
                }
            });
        }
    }

    public class CostCalculatorTheoryData
    {
        public Transaction Input { get; set; }
        public TransactionCostEstimate Estimates { get; set; }
    }
}