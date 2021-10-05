using System.Collections.Generic;

namespace OverTheHillsAndFarAway
{
    public class BigTelephone : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private Activities CurrentActivity;

        public void Attach(IObserver obs)
        {
            observers.Add(obs);
        }

        public void Detach(IObserver obs)
        {
            // Be careful using Remove, Equals or operator== must be implemented
            observers.Remove(obs);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(CurrentActivity);
            }
        }

        public void ChangeCurrentActivity(Activities act)
        {
            if (act != CurrentActivity)
            {
                CurrentActivity = act;
                Notify();
            }
        }
    }
}