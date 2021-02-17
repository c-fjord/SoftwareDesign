using PortioningMachine.SystemComponents;

namespace PortioningMachine
{
    public interface IItemScore
    {
        double score(IItem item, IBin bin);
    }
}