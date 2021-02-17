namespace Card_Game
{
    enum Colors : uint
    {
        Red = 1,
        Blue = 2,
        Green = 3,
        Yellow = 4,
        Gold = 5
    }

    class Card
    {
        public Colors color {get;}
        public uint number {get;}

        public Card(Colors c, uint num)
        {
            this.color = c;
            this.number = num;
        }
    }
}