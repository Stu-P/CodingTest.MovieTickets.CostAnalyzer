using System;
using System.Collections.Generic;
using System.IO;
using MovieTickets.CostAnalyzer.Models;
using MovieTickets.CostAnalyzer.Services;
using Newtonsoft.Json;
using static System.Console;

namespace MovieTickets.CostAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string input = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}/transactions.json");
                var transactions = JsonConvert.DeserializeObject<List<Transaction>>(input);

                foreach (var txn in transactions)
                {
                    var estimate = CostCalculator.EstimateTransactionCost(txn);
                    WriteLine(estimate);
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Fatal error, unable to process input. Exiting... | {ex.GetType()} {ex.Message}");
            }
        }
    }
}