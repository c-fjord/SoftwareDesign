using System;

namespace SuperSorter
{
    public class ArrayGeneratorNearlySorted : ArrayGenerator
    {
        public ArrayGeneratorNearlySorted(int n, int max, int seed) : base(n, max, seed, "NearlySorted")
        {

        }

        public override int[] Generate()
        {
            // Generate random array using base class
            var rnd_array = base.Generate();
            Array.Sort(rnd_array);

            // Pickout random numbers in array
            int[] idx = new ArrayGenerator((int)Math.Ceiling(n * 0.1), rnd_array.Length, seed, "temp").Generate();

            if (idx.Length > 1)
            {
                for (int i = 0; i < idx.Length; i += 2)
                {
                    var temp = rnd_array[idx[i]];
                    rnd_array[idx[i]] = rnd_array[idx[i + 1]];
                    rnd_array[idx[i + 1]] = temp;
                }
            }
            return rnd_array;
        }
    }
}