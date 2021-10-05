using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cards
{
    internal static class MapReduceCards
    {
        public static ParallelQuery<TResult> MapReduce<TSource, TMapped, TKey, TResult>(
            this ParallelQuery<TSource> source,
            Func<TSource, IEnumerable<TMapped>> map,
            Func<TMapped, TKey> keySelector,
            Func<IGrouping<TKey, TMapped>, IEnumerable<TResult>> reduce)
        {
            return source
                  .SelectMany(map)
                  .GroupBy(keySelector)
                  .SelectMany(reduce);
        }

        private static void Main(string[] args)
        {
            var files =
                Directory.EnumerateFiles(@"cards", "*.txt")
                    .AsParallel();

            var cardCount = files.MapReduce(
                path => Source(path),
                map => Map(map),
                group => Reduce(group));

            var cc = cardCount.ToList();

            foreach (var pair in cc)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }

        private static IEnumerable<Tuple<string, int>> Source(string path)
        {
            var lines = File.ReadLines(path); // Read all lines in the path
            foreach (var line in lines)
            {
                var items = line.Split(',');
                yield return new Tuple<string, int>(items[0], int.Parse(items[1]));
            }
        }

        private static string Map(Tuple<string, int> card)
        {
            return card.Item1;
        }

        private static IEnumerable<KeyValuePair<string, int>> Reduce(IGrouping<string, Tuple<string, int>> group)
        {
            int sum = group.Sum(tuple => tuple.Item2);

            var retVal = new KeyValuePair<string, int>[]
            {
                    new KeyValuePair<string,int>(group.Key, sum)
            };

            return retVal;
        }
    }
}
