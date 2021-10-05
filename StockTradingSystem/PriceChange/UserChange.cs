using System;
using System.Collections.Generic;

namespace StockTradingSystem
{
    public class UserChange : IPriceChange
    {
        public void Run(List<Stock> StockPool)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                foreach (var stock in StockPool)
                {
                    if (stock.name.ToUpper() == input[0])
                    {
                        stock.ChangeValue(Convert.ToDouble(input[1]));
                    }
                }
            }
        }
    }
}