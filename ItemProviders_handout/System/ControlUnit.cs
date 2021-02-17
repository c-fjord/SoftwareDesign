using System.Collections.Generic;
using PortioningMachine.Logger;

namespace PortioningMachine.SystemComponents
{
    public class ControlUnit : IControlUnit
    {
        private ILogger _logger;
        private IAlgorithm _algorithm;
        private List<IBin> _bins;

        public ControlUnit(ILogger logger, IAlgorithm algorithm, List<IBin> bins)
        {
            _logger = logger;
            _algorithm = algorithm;
            _bins = bins;
        }

        public void item_handler(object source, IItem item)
        {
            _logger.item_arrived(item);
            IBin bin = _algorithm.find_bin(item, _bins);
            bin.add(item);
        }

    }
}