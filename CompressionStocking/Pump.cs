using System;

namespace CompressionStocking
{
    public class Pump
    {
        public void forward()
        {
            Console.WriteLine("Pump running forwards");
        }

        public void backward()
        {
            Console.WriteLine("Pump running backwards");
        }

        public void stop()
        {
            Console.WriteLine("Pump has stopped");
        }
    }
}