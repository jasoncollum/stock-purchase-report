using System;
using System.Collections.Generic;
using System.Linq;

namespace stocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");

            var purchases = new Dictionary<string, List<double>>();
            purchases.Add("AAPL", new List<double> { 1214.90, 2881.95 });
            purchases.Add("GM", new List<double> { 4892.12 });
            purchases.Add("CAT", new List<double> { 934.21, 9025.23, 4013.89 });

            foreach (KeyValuePair<string, List<double>> purchase in purchases)
            {
                Console.WriteLine($"Investor has spent a total of {purchase.Value.Sum()} on the stock for {stocks[purchase.Key]}");
            }
        }
    }
}
