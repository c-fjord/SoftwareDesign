using System;

namespace OverTheHillsAndFarAway
{
    class Program
    {
        static void Main(string[] args)
        {
            BigTelephone BigTelePhone = new BigTelephone();

            IObserver TinkyWinky = new Teletubbie("TinkyWinky", BigTelePhone);
            IObserver Dipsy = new Teletubbie("Dipsy", BigTelePhone);
            IObserver La_la = new Teletubbie("La-la", BigTelePhone);
            IObserver Po = new Teletubbie("Po", BigTelePhone);

            BigTelePhone.ChangeCurrentActivity(Activities.ByeBye);
        }
    }
}
