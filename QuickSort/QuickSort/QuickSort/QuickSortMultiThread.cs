using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSortMultiThread
    {
        public static void SerialQuicksort(long[] elements, long left, long right)
        {
            long i = left, j = right;
            var pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0) i++;
                while (elements[j].CompareTo(pivot) > 0) j--;

                if (i <= j)
                {
                    // Swap
                    var tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            List<Task> tasks = new List<Task>();
            if (left < j) tasks.Add(Task.Run(() => SerialQuicksort(elements, left, j)));
            if (i < right) tasks.Add(Task.Run(() => SerialQuicksort(elements, i, right)));
            Task.WaitAll(tasks.ToArray());
        }
    }
}
