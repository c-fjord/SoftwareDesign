
using System.Collections.Generic;
using PortioningMachine.SystemComponents;

namespace PortioningMachine
{
    public interface IAlgorithm
    {
        IBin find_bin(IItem item, List<IBin> bins);
    }
}