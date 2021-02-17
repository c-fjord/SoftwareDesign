using System;
using System.Collections.Generic;

namespace Card_Game
{
    class Game
    {
        private int deal_amount;
        private Deck deck;
        protected List<Player> players = new List<Player>();
        protected bool start = false;

        public Game(Deck deck, int deal_amount)
        {
            this.deck = deck;
            this.deal_amount = deal_amount;
        }

        public void add_player(Player player)
        {
            if (!start)
            {
                players.Add(player);
            }
            else
            {
                Console.WriteLine("The game has begun");
            }
        }

        public void deal_cards()
        {
            start = true;
            foreach (var p in players)
            {
                deck.deal(deal_amount, p);
            }
        }

        public virtual void announce_winner()
        {   
            Player winner = players[0];
            foreach (var p in players)
            {
                if (p.total_value() > winner.total_value())
                {
                    winner = p;
                }
            }
            Console.WriteLine("The winner is {0}", winner.name);
            start = false; 
        }
    }
}