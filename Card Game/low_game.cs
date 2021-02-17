using System;

namespace Card_Game
{
    class LowGame : Game
    {
        public LowGame(Deck deck, int deal_amount) : base(deck, deal_amount)
        {

        }

        public override void announce_winner()
        {
            Player winner = base.players[0];
            foreach (var p in base.players)
            {
                if (winner.total_value() > p.total_value())
                {
                    winner = p;
                }
            }
            Console.WriteLine("The winner is {0}", winner.name);
            base.start = false; 
        }

    }
}