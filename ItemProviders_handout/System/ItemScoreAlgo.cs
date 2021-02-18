using System.Collections.Generic;
using PortioningMachine;

namespace PortioningMachine.SystemComponents
{
    public class ItemScoreAlgo : IAlgorithm
    {
        public IBin find_bin(IItem item, List<IBin> bins)
        {   
            IBin curr_bin = bins[0];
            foreach (var bin in bins)
            {
                if (bin.score_item(item) > curr_bin.score_item(item))
                {
                    curr_bin = bin;
                }
            }
            return curr_bin;
        }
    }
}