using System.Timers;

namespace CompressionStocking
{
    public interface ICompressionCtrl
    {
        Timer CompressionTimer {set; get; }
        Timer DecompressionTimer {set; get; }
        void Compress();
        void Decompress();
    }
}