using System;

namespace CompressionStocking
{
    public class LED : IIndicator
    {
        private string Color;
        public LED(string color)
        {
            Color = color;
        }
        
        public void On()
        {
            Console.WriteLine("{0} LED is on", Color);
        }

        public void Off()
        {
            Console.WriteLine("{0} LED is off", Color);
        }
    }
}