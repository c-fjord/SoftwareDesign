namespace Card_Game
{
    class WeakPlayer : Player
    {
        public WeakPlayer(string first_name) : base(first_name)
        {

        }

        public override void receive_card(Card card) {
            if (base.cards.Count < 3)
            {
                base.cards.Add(card);
            }
        }
    }
}