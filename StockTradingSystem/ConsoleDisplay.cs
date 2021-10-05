using System;
using System.Collections.Generic;

namespace StockTradingSystem
{
    public class ConsoleDisplay : IDisplay
    {
        public void DisplayPortfolio(Dictionary<Stock, int> portfolio, Dictionary<Stock, double> current_value)
        {
            foreach (var key in portfolio.Keys)
            {
                Console.WriteLine("Stock: {0} Amount: {1} value: {2}", key.name, portfolio[key], current_value[key]);
            }
        }

        public void DisplayChange()
        {

        }
    }
}