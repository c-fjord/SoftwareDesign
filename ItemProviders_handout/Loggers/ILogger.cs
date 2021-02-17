using PortioningMachine.SystemComponents;

namespace PortioningMachine.Logger
{
    public interface ILogger
    {
        void item_arrived(IItem item);
        void bin_closed(IBin bin);
        void waste(IItem item);
    }
}