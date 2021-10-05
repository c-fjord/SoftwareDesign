using System.Diagnostics;
using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            GameOfLife gol = new GameOfLife(1000);
            stopwatch.Start();
            gol.Run(100);
            stopwatch.Stop();
            Console.WriteLine("Serialized exercise: {0}", stopwatch.ElapsedMilliseconds);

            GameOfLife golfor = new ForEachGameOfLife(1000);
            stopwatch.Restart();
            golfor.Run(100);
            stopwatch.Stop();
            Console.WriteLine("Parallel For-loop: {0}", stopwatch.ElapsedMilliseconds);
        }
    }
}
