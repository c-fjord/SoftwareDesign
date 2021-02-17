using System;
using System.Timers;

namespace CompressionStocking
{
    public class AirCompression : ICompressionCtrl
    {   
        private Pump _air_pump = new Pump();
        private Timer _compression_timer = new Timer();
        private Timer _decompression_timer = new Timer();

        public AirCompression()
        {
            _compression_timer.Interval = 5000;
            _decompression_timer.Interval = 2000;

            _compression_timer.AutoReset = false;
            _decompression_timer.AutoReset = false;

            _compression_timer.Elapsed += compression_event;
            _decompression_timer.Elapsed += decompression_event;
        }

        public void compress()
        {
            _air_pump.forward();
        }

        public void decompress()
        {
            _air_pump.backward();
        }

        public void compression_event(object obj, EventArgs e)
        {
            _air_pump.stop();
            Console.WriteLine("Compression is done");
        }

        public void decompression_event(object obj, EventArgs e)
        {
            _air_pump.stop();
            Console.WriteLine("Decompression is done");
        }

    }
}