using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Threading.Tasks;


namespace Pipelines
{
    class PipelineStringCompression
    {
        private readonly string _charsInString;
        private readonly int _nStrings;
        private readonly int _stringLength;

        double _avgCompressionRatio = 0;

        public PipelineStringCompression(string charsInString, int nStrings, int stringLength)
        {
            _charsInString = charsInString;
            _nStrings = nStrings;
            _stringLength = stringLength;
        }

        public void Run()
        {
            var inputStrings = new BlockingCollection<string>();
            var compressedStrings = new BlockingCollection<Tuple<string, string>>();

            var generateStringsTask = Task.Run(() => GenerateStrings(_stringLength, inputStrings));
            var compressStringsTask = Task.Run(() => Compress(inputStrings, compressedStrings));
            var updateCompressionTask = Task.Run(() => UpdateCompressionStatsPar(compressedStrings, ref _avgCompressionRatio));

        }

        private void GenerateStrings(int stringLength, BlockingCollection<string> output)
        {
            try
            {
                for (int i = 0; i < _nStrings; i++)
                {
                    var random = new Random();
                    var result = new string(Enumerable.Repeat(_charsInString, stringLength).Select(s => s[random.Next(s.Length)]).ToArray());
                    output.Add(result);
                }
            }
            finally
            {
                output.CompleteAdding();
            }
        }

        private void Compress(BlockingCollection<string> input, BlockingCollection<Tuple<string, string>> output)
        {
            try
            {
                foreach (var str in input.GetConsumingEnumerable())
                {
                    var result = "";
                    for (var i = 0; i < str.Length; i++)
                    {
                        var j = i;
                        result += str[i];
                        while ((j < str.Length) && (str[i] == str[j]))
                            j++;

                        if (j > i + 1)
                        {
                            result += (j - i);
                            i = j - 1;
                        }
                    }
                    output.Add(Tuple.Create(str, result));
                }
            }
            finally
            {
                output.CompleteAdding();
            }
        }

        private void UpdateCompressionStatsPar(BlockingCollection<Tuple<string, string>> input, ref double compression)
        {
            foreach (var tuple in input.GetConsumingEnumerable())
            {
                compression = UpdateCompressionStats(0, tuple.Item1, tuple.Item2);
            }
        }

        private double UpdateCompressionStats(int i, string str, string compressedStr)
        {
            return ((i * _avgCompressionRatio) + ((double)(compressedStr.Length) / str.Length)) / (i + 1);
        }

    }
}