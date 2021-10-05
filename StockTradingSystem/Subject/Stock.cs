using System.Collections.Generic;

namespace StockTradingSystem
{
    public class Stock : ISubject
    {
        private HashSet<IObserver> observers = new HashSet<IObserver>();
        public string name { get; private set; }
        public double value;

        public Stock(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        public void Attach(IObserver obs)
        {
            observers.Add(obs);
        }

        public void Detach(IObserver obs)
        {
            observers.Remove(obs);
        }

        public void Notify()
        {
            foreach (var obs in observers)
            {
                obs.Update(this);
            }
        }

        public void ChangeValue(double value)
        {
            this.value = value;
            Notify();
        }
    }
}