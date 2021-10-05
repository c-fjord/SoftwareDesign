using System;
using System.Collections.Generic;

namespace StockTradingSystem
{
    public class StockExchange
    {
        private List<Stock> StockPool = new List<Stock>();
        private IPriceChange changer;

        public StockExchange(IPriceChange changer)
        {
            this.changer = changer;
        }

        public void Add(Stock stock)
        {
            StockPool.Add(stock);
        }

        public void Run()
        {
            changer.Run(StockPool);
        }
    }
}