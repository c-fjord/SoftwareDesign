using System.Collections.Generic;
using PortioningMachine.SystemComponents;

namespace PortioningMachine
{
    public class RoundRobinAlogrithm : IAlgorithm
    {
        private int _index = 0;

        public RoundRobinAlogrithm ()
        {

        }

        public IBin find_bin(IItem item, List<IBin> bins)
        {
            if (bins == null) return null;

            IBin output_bin = bins[_index];     

            if (_index >= bins.Count - 1)
            {
                    _index = 0;
            }
            else
            {
                _index++;
            }
            
            return output_bin;            
        }
    }
}