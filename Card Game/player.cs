using System;
using System.Collections.Generic;

namespace Card_Game
{
    class Player
    {   
        public string name {get; }
        protected List<Card> cards = new List<Card>(); 

        public Player(string first_name)
        {
            this.name = first_name;
        }

        public virtual void receive_card(Card card) {
            cards.Add(card);
        }

        public uint total_value()
        {   
            uint total_sum = 0;
            foreach (var card in cards)
            {
                total_sum += card.number * (uint) card.color;
            }
            return total_sum;
        }

        public void show_hand() {
            foreach (var card in cards)
            {
                Console.WriteLine("Name: {0} Number: {1} Suit: {2}", name, card.number, card.color);   
            };
        }
    }
}