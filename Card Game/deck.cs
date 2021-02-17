using System;
using System.Collections.Generic;

namespace Card_Game
{
    class Deck
    {
        private List<Card> cards;
        
        public Deck()
        {
            cards = create_deck();
        }

        public List<Card> card_deck
        {
            get {return cards; }
        }

        private List<Card> create_deck()
        {   
            List<Card> deck = new List<Card>();
            foreach (var color in Enum.GetValues<Colors>())
            {
                for (uint i = 1; i < 9; i++) // 9 in card class?
                {
                    deck.Add(new Card(color, i));
                }
            }
            return deck;
        }

        public void deal(int amount, Player p)
        {
            Random shuffler = new Random();
            for (int i = 0; i < amount; i++)
            {
                int nr = shuffler.Next(cards.Count);
                p.receive_card(cards[nr]);
                cards.Remove(cards[nr]);
            }
        }
    }
}