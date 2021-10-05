namespace SuperSorter
{
    public abstract class TestFactory
    {
        public abstract ArrayGenerator[] CreateArray(int n, int max, int seed);
        public abstract Algorithm CreateAlgorithm();
    }

    public class TestBubbleSort : TestFactory
    {
        public override ArrayGenerator[] CreateArray(int n, int max, int seed)
        {
            return new ArrayGenerator[] { new ArrayGenerator(n, max, seed), new ArrayGeneratorNearlySorted(n, max, seed), new ArrayGeneratorReverse(n, max, seed) };
        }

        public override Algorithm CreateAlgorithm()
        {
            return new BubbleSort();
        }
    }

}