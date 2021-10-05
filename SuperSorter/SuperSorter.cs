using System;
using System.Diagnostics;

namespace SuperSorter
{
    public class SuperSorter
    {
        private Algorithm algorithm;
        private ArrayGenerator generator;
        private Stopwatch watch = new Stopwatch();

        public int[] Sort()
        {
            if (algorithm == null) throw new System.NullReferenceException("The SuperSorter has no Algorithm assigned");
            if (generator == null) throw new System.NullReferenceException("The SuperSorter has no ArrayGenerator assigned");

            int[] input = generator.Generate();
            watch.Start();
            var output = algorithm.Sort(input);
            Console.WriteLine("-------[Elapsed Time " + watch.ElapsedMilliseconds + " ms]-------");
            watch.Reset();
            return output;
        }

        public void SetAlgorithm(Algorithm algo)
        {
            algorithm = algo;
        }

        public void SetGenerator(ArrayGenerator gen)
        {
            generator = gen;
        }
    }
}