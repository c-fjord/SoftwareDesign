using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStocking;
using System.Timers;

namespace CompressionStockingApplication
{

    class StubCompressionCtrl : ICompressionCtrl
    {   
        private ICompressionMechanism _pump;
        
        private IIndicator _compressIndicator;
        private IIndicator _decompressIndicator;
        private IIndicator _vibrationMotor;

        public Timer CompressionTimer {set; get; }
        public Timer DecompressionTimer {set; get; }
        private bool state = false;

        public StubCompressionCtrl(ICompressionMechanism p, uint compressionTime, uint decompressionTime, IIndicator greenLED, IIndicator redLED, IIndicator vibrationMotor)
        {
            _pump = p;
            CompressionTimer = new Timer();
            CompressionTimer.Interval = compressionTime * 1000;
            CompressionTimer.Elapsed += Stop;
            CompressionTimer.AutoReset = false;

            DecompressionTimer = new Timer(decompressionTime);
            DecompressionTimer.Interval = decompressionTime * 1000;
            DecompressionTimer.Elapsed += Stop;
            DecompressionTimer.AutoReset = false;

            _compressIndicator = greenLED;
            _decompressIndicator = redLED;
            _vibrationMotor = vibrationMotor;
        }
        
        public void Compress()
        {
            Console.WriteLine("StubCompressionCtrl::Compress() called");
            CompressionTimer.Enabled = true;
            _pump.Compress();
            _compressIndicator.On();
            _vibrationMotor.On();
        }

        public void Decompress()
        {
            Console.WriteLine("StubCompressionCtrl::Decompress() called");
            DecompressionTimer.Enabled = true;
            _pump.Decompress();
            _decompressIndicator.On();
            _vibrationMotor.On();
        }

        void Stop(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("SubCompressionCtrl::Stop() called");
            _pump.Stop();
            _compressIndicator.Off();
            _decompressIndicator.Off();
            _vibrationMotor.Off();
        }
    }


    class CompressionStockingApplication
    {
        static void Main(string[] args)
        {   
            ICompressionMechanism p = new Pump();
        
            IIndicator GreenLED = new LED("Green");
            IIndicator RedLED = new LED("Red");
            IIndicator VMotor = new VibrationMotor();

            var compressionStockingstocking = new StockingCtrl(new StubCompressionCtrl(p, 5, 2, GreenLED, RedLED, VMotor));
            ConsoleKeyInfo consoleKeyInfo;
            
            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("ESC: Terminate application");

            do
            {
                consoleKeyInfo = Console.ReadKey(true); // true = do not echo character
                if (consoleKeyInfo.Key == ConsoleKey.A)  compressionStockingstocking.StartBtnPushed();
                if (consoleKeyInfo.Key == ConsoleKey.Z)  compressionStockingstocking.StopBtnPushed();

            } while (consoleKeyInfo.Key != ConsoleKey.Escape);           
        }
        
    }
}
