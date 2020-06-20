using System;
using FluentAssertions;
using MovieTickets.CostAnalyzer.Helpers;
using MovieTickets.CostAnalyzer.Models;
using Xunit;

namespace MovieTickets.CostAnalyzer.Tests.Unit
{
    public class CustomerShould
    {
        [Theory]
        [InlineData(0, typeof(ChildrenTicket))]
        [InlineData(5, typeof(ChildrenTicket))]
        [InlineData(10, typeof(ChildrenTicket))]
        [InlineData(11, typeof(TeenTicket))]
        [InlineData(15, typeof(TeenTicket))]
        [InlineData(18, typeof(AdultTicket))]
        [InlineData(19, typeof(AdultTicket))]
        [InlineData(35, typeof(AdultTicket))]
        [InlineData(64, typeof(AdultTicket))]
        [InlineData(65, typeof(SeniorTicket))]
        [InlineData(110, typeof(SeniorTicket))]
        public void ReturnCorrectTicketType_GivenAgeOfCustomer(int age, Type expectedTicketType)
        {
            // Arrange
            var sut = new Customer { Age = age };

            // Act
            var actual = sut.GetTicketType();

            // Assert
            actual.Should().BeOfType(expectedTicketType);
        }

        [Fact]
        public void ThrowException_GivenInvalidInput()
        {
            // Arrange
            var sut = new Customer { Age = -19 };

            // Act + Assert
            var actual = Assert.Throws<Exception>(() => sut.GetTicketType());
            actual.Message.Should().Contain("Customer age cannot be less than 0 years old");
        }
    }
}