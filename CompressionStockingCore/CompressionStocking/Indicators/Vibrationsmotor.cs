using System;

namespace CompressionStocking
{
    public class VibrationMotor : IIndicator
    {
        public void On()
        {
            Console.WriteLine("VibrationMotor::On() is called");
        }

        public void Off()
        {
            Console.WriteLine("VibrationMotor::Off() is called");
        }
    }
}