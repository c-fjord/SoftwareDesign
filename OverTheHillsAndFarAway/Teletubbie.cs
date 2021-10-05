using System;

namespace OverTheHillsAndFarAway
{
    public class Teletubbie : IObserver
    {
        public string name;

        public Teletubbie(string name, ISubject sub)
        {
            this.name = name;
            sub.Attach(this);
        }

        public void Update(Activities act)
        {
            Console.WriteLine("{0} says {1}", name, act.ToString("G"));
        }
    }
}