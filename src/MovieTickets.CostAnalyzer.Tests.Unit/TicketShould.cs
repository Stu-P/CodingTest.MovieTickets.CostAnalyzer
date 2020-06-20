using FluentAssertions;
using MovieTickets.CostAnalyzer.Tests.Unit.Theories;
using Xunit;

namespace MovieTickets.CostAnalyzer.Tests.Unit
{
    public class TicketShould
    {
        [Theory]
        [ClassData(typeof(TicketTheories))]
        public void ApplyDiscountToPrice_GivenTicketDiscountAndEligibilityRules(string scenario, TicketTheoryData theory)
        {
            // Arrange
            var sut = theory.Input;

            // Act
            var actual = sut.ApplyDiscount(theory.QuantityPurchased);

            // Assert
            actual.Should().Be(theory.ExpectedDiscountPrice, because: scenario);
        }
    }
}