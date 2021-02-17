using System;

namespace CompressionStocking
{
    class Program
    {
        static void Main(string[] args)
        {   
            ICompressionCtrl AirComp = new AirCompression();
            IStockingCtrl Stocking = new StockingCtrl(AirComp);

        }
    }
}
