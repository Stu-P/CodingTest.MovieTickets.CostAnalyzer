using FluentAssertions;
using MovieTickets.CostAnalyzer.Services;
using MovieTickets.CostAnalyzer.Tests.Unit.Theories;
using Xunit;

namespace MovieTickets.CostAnalyzer.Tests.Unit
{
    public class CostCalculatorShould
    {
        [Theory]
        [ClassData(typeof(CostCalculatorTheories))]
        public void GenerateAndSortCollectionOfEstimates_GivenInputOfCustomerTransaction(string scenario, CostCalculatorTheoryData theory)
        {
            // Arrange + Act
            var actual = CostCalculator.EstimateTransactionCost(theory.Input);

            // Assert
            actual.Should().NotBeNull();
            actual.Should().BeEquivalentTo(theory.Estimates, because: scenario);
            actual.TicketEstimates.Should().BeInAscendingOrder(x => x.TicketType);
        }
    }
}