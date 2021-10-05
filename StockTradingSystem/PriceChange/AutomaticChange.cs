using System;
using System.Threading;
using System.Collections.Generic;

namespace StockTradingSystem
{
    public class AutomaticChange : IPriceChange
    {
        private Random rand = new Random();

        public void Run(List<Stock> StockPool)
        {
            while (true)
            {
                int idx = rand.Next(0, StockPool.Count);
                double diff = rand.Next(-5, 5);
                StockPool[idx].ChangeValue(StockPool[idx].value * ((100 + diff) / 100));
                Thread.Sleep(5000);
            }
        }
    }
}