using System;

namespace CompressionStocking
{
    public class StockingCtrl : IStockingCtrl
    {
        private ICompressionCtrl _compression_device;
        private bool _relaxed = true;

        public StockingCtrl(ICompressionCtrl compression_device)
        {
            _compression_device = compression_device;
        }

        public void start_compressing()
        {   
            if (_relaxed)
            {
                _compression_device.compress();
            }
            
        }

        public void start_decompressing()
        {
            if (!_relaxed)
            {
                _compression_device.decompress();
            }
        }

    }
}