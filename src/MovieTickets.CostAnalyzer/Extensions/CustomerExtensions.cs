using System;
using MovieTickets.CostAnalyzer.Models;

namespace MovieTickets.CostAnalyzer.Helpers
{
    public static class CustomerExtensions
    {
        public static Ticket GetTicketType(this Customer customer) =>
            customer.Age switch
            {
                int age when age >= 0 && age < 11 => new ChildrenTicket(),
                int age when age >= 11 && age < 18 => new TeenTicket(),
                int age when age >= 18 && age < 65 => new AdultTicket(),
                int age when age >= 65 => new SeniorTicket(),
                _ => throw new Exception("Customer age cannot be less than 0 years old")
            };
    }
}