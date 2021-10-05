using System.Collections.Generic;

namespace StockTradingSystem
{
    public interface IDisplay
    {
        void DisplayPortfolio(Dictionary<Stock, int> portfolio, Dictionary<Stock, double> current_value);
        void DisplayChange();
    }
}