using System.Collections.Generic;

namespace PortioningMachine.SystemComponents
{
    public interface IBin
    {   
        double weight {get; }
        double target {get; }
        void add(IItem item);
    }
}