using System;

namespace SuperSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFactory bubble = new TestBubbleSort();
            FatorySuperSorter tester = new FatorySuperSorter(bubble);

            tester.RunAlgorithmTest();

        }
    }
}
