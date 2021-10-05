using System.Collections.Generic;

namespace StockTradingSystem
{
    public class Portfolio : IObserver
    {
        private Dictionary<Stock, int> _Portfolio = new Dictionary<Stock, int>();
        private Dictionary<Stock, double> _CurrentValue = new Dictionary<Stock, double>();

        public string name;
        private IDisplay _display;

        public Portfolio(string name, IDisplay display)
        {
            this.name = name;
            _display = display;
        }

        public void Buy(Stock stock, int amount)
        {
            stock.Attach(this);

            if (_Portfolio.ContainsKey(stock))
            {
                _Portfolio[stock] += amount;
            }
            else
            {
                _Portfolio.Add(stock, amount);
            }

            _CurrentValue[stock] = _Portfolio[stock] * stock.value;
        }

        public void Sell(Stock stock)
        {
            _Portfolio.Remove(stock);
        }

        public void Update(Stock stock)
        {
            _CurrentValue[stock] = _Portfolio[stock] * stock.value;
            _display.DisplayPortfolio(_Portfolio, _CurrentValue);
        }

        public void Print()
        {
            _display.DisplayPortfolio(_Portfolio, _CurrentValue);
        }
    }
}