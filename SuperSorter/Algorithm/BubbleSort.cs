namespace SuperSorter
{
    public class BubbleSort : Algorithm
    {
        public BubbleSort() : base()
        {

        }

        public override int[] Sort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                }
            }
            return data;
        }
    }
}