using System;

namespace SuperSorter
{
    public class ArrayGeneratorReverse : ArrayGenerator
    {
        public ArrayGeneratorReverse(int n, int max, int seed) : base(n, max, seed, "Reverse")
        {

        }

        public override int[] Generate()
        {
            // Generate random array using base class
            var rnd_array = base.Generate();
            Array.Sort(rnd_array);
            Array.Reverse(rnd_array);
            return rnd_array;
        }
    }
}