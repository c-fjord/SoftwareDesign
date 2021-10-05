using System;
using System.Diagnostics;

namespace Pipelines
{
    class Program
    {
        static void Main(string[] args)
        {
            string charsInString = "ABC";
            int nStrings = 100000;
            int stringLength = 25000;

            var s1 = new Stopwatch();
            var sequential = new SequentialStringCompression(charsInString, nStrings, stringLength);
            var pipeline = new PipelineStringCompression(charsInString, nStrings, stringLength);

            s1.Start();
            sequential.Run();
            s1.Stop();
            System.Console.WriteLine("Squential: {0}", s1.ElapsedMilliseconds);

            s1.Reset();
            s1.Start();
            pipeline.Run();
            s1.Stop();
            System.Console.WriteLine("Pipeline: {0}", s1.ElapsedMilliseconds);
        }
    }
}
