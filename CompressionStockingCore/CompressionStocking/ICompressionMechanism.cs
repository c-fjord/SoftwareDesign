namespace CompressionStocking
{
    public interface ICompressionMechanism
    {
        void Compress();
        void Decompress();
        void Stop();
    }
}