using System;

namespace RomanNuerals
{
    class Program
    {
        static void Main(string[] args)
        {
            var arabic = new Arabic(9);
            Console.WriteLine(arabic.FuncToRoman());
        }
    }
}
