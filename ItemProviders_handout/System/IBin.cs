using System.Collections.Generic;

namespace PortioningMachine.SystemComponents
{
    public interface IBin
    {   
        double weight {get; }
        double target {get; }
        void add(IItem item);
        double score_item(IItem item); // was added in exe 4 in order to aviod creating multiple interface for the algorithm
        //Score_item makes more sense in the algorithm than here.
    }
}