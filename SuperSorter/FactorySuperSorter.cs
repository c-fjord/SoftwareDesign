using System;
using System.Diagnostics;

namespace SuperSorter
{
    public class FatorySuperSorter
    {
        private Algorithm _algorithm;
        private ArrayGenerator[] _generator;
        private Stopwatch watch = new Stopwatch();

        public FatorySuperSorter(TestFactory factory)
        {
            _algorithm = factory.CreateAlgorithm();
            _generator = factory.CreateArray(1000, 10000000, 42);
        }

        public void RunAlgorithmTest()
        {

            foreach (var generator in _generator)
            {
                watch.Start();
                _algorithm.Sort(generator.Generate());
                Console.WriteLine("-------{0} ms -------\nArray Type: {1}", watch.ElapsedMilliseconds, generator.ToString());
                watch.Reset();
            }
        }
    }
}