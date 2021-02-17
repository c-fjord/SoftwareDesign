using PortioningMachine.SystemComponents;

namespace PortioningMachine
{
    public class SocreFunc : IItemScore
    {
        public double score(IItem item, IBin bin)
        {   
            return (bin.target - bin.weight - item.Weight) / bin.target;
        }
    }
}