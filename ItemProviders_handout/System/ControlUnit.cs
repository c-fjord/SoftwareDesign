using System.Collections.Generic;
using PortioningMachine.Logger;

namespace PortioningMachine.SystemComponents
{
    public class ControlUnit : IControlUnit
    {
        private ILogger _logger;
        private IAlgorithm _algorithm;
        private List<IBin> _bins = new List<IBin>();

        public ControlUnit(ILogger logger, IAlgorithm algorithm, uint nr_bins, IItemScore method = null)
        {
            _logger = logger;
            _algorithm = algorithm;
            
            // Thight coupled with Bin (not ideal)
            for (int i = 0; i < nr_bins; i++)
            {
                _bins.Add(new Bin(200, new ConsoleLogger()){score_method = method});
            }

        }

        public void item_handler(object source, IItem item)
        {
            _logger.item_arrived(item);
            IBin bin = _algorithm.find_bin(item, _bins);
            bin.add(item);
        }

    }
}