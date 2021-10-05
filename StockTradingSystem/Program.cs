using System;

namespace StockTradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock AAPL = new Stock("AAPL", 100);
            Stock MSFT = new Stock("MSFT", 170);
            Stock GOOG = new Stock("GOOG", 150);

            // IPriceChange changer = new UserChange();
            IPriceChange changer = new AutomaticChange();

            StockExchange exchange = new StockExchange(changer);
            exchange.Add(AAPL);
            exchange.Add(MSFT);
            exchange.Add(GOOG);

            IDisplay display = new ConsoleDisplay();
            Portfolio myPort = new Portfolio("Retirement Fund", display);
            myPort.Buy(AAPL, 5);
            myPort.Buy(GOOG, 2);

            exchange.Run();
        }
    }
}
