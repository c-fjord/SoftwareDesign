using System;

namespace SuperSorter
{
    public class ArrayGenerator
    {
        protected int n;
        protected int max;
        protected int seed;
        public String name { private set; get; } = "Random";

        public ArrayGenerator(int n, int max, int seed)
        {
            this.n = n;
            this.max = max;
            this.seed = seed;
        }

        public ArrayGenerator(int n, int max, int seed, String name)
        {
            this.n = n;
            this.max = max;
            this.seed = seed;
            this.name = name;
        }

        public virtual int[] Generate()
        {
            int[] rnd_list = new int[n];
            Random rnd = new Random(seed);

            for (int i = 0; i < n; i++)
            {
                rnd_list[i] = (rnd.Next(0, max));
            }

            return rnd_list;
        }
        public override string ToString()
        {
            return name;
        }
    }
}