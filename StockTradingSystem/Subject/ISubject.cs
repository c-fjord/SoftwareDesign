namespace StockTradingSystem
{
    public interface ISubject
    {
        void Attach(IObserver obs);
        void Detach(IObserver obs);
        void Notify();
    }
}