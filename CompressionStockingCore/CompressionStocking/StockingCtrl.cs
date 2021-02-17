using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public class StockingCtrl : IBtnHandler
    {
        private enum State
        {
            Relaxed,
            Compressed,
            Decompressing,
            Compressing
        }
        
        private readonly ICompressionCtrl _compressionCtrl;
        private State _state;

        public StockingCtrl(ICompressionCtrl compressionCtrl)
        {
            _compressionCtrl = compressionCtrl;
            _state = State.Relaxed;
            compressionCtrl.CompressionTimer.Elapsed += CompressionComplete;
            compressionCtrl.DecompressionTimer.Elapsed += DecompressionComplete;
        }
        // From IBtnHandler
        public void StartBtnPushed()
        {
            if (_state == State.Relaxed)
            {
                _compressionCtrl.Compress();
                _state = State.Compressing;
            } 
        }

        public void StopBtnPushed()
        {
            if (_state == State.Compressed)
            {
                _compressionCtrl.Decompress();
                _state = State.Decompressing;
            } 
        }
        
        public void CompressionComplete(object source, EventArgs e)
        {
            _state = State.Compressed;
            Console.WriteLine("Stocking is now compressed");
        }

        public void DecompressionComplete(object source, EventArgs e)
        {
            _state = State.Relaxed;
            Console.WriteLine("Stocking is now decompressed");
        }

    }
}
