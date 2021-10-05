namespace SuperSorter
{
    public abstract class Algorithm
    {
        protected void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        public abstract int[] Sort(int[] data);
    }
}