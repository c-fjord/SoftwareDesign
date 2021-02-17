using System;
using System.Collections.Generic;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {   
            Player p1 = new Player("John");
            Player p2 = new Player("Jane");
            WeakPlayer p3 = new WeakPlayer("Simon");

            Deck d1 = new Deck();

            Game g1 = new Game(d1, 4);
            g1.add_player(p1);
            g1.add_player(p2);
            g1.add_player(p3);

            g1.deal_cards();
            
            p1.show_hand();
            p2.show_hand();
            p3.show_hand();

            g1.announce_winner();

            Game g2 = new Game(d1, 4);
            g2.add_player(p1);
            g2.add_player(p2);
            g2.add_player(p3);

            g2.deal_cards();

            p1.show_hand();
            p2.show_hand();
            p3.show_hand();
            
            g2.announce_winner();
        }
    }
}
