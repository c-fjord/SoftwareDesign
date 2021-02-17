using System;

namespace CompressionStocking
{
    public class Pump : ICompressionMechanism
    {
        public void Compress()
        {
            Console.WriteLine("Pump::Compress() called");
        }

        public void Decompress()
        {
            Console.WriteLine("Pump::Decompress() called");
        }

        public void Stop()
        {
            Console.WriteLine("Pump::Stop() called");
        }
    }
}