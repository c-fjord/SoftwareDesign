using System.Collections.Generic;

namespace StockTradingSystem
{
    public interface IPriceChange
    {
        void Run(List<Stock> StockPool);
    }
}