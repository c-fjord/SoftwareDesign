using System.Collections.Generic;
using PortioningMachine.ItemProviders;
using PortioningMachine.SystemComponents;
using PortioningMachine.Logger;

namespace PortioningMachine
{
    public class RoundRobinMachine
    {
        private IControlUnit _control_unit;
        private IItemProvider _item_provider;
        private ILogger _logger;
        private double _target = 200;

        public RoundRobinMachine(uint number_bins)
        {
            _logger = new ConsoleLogger();
            List<IBin> bins = new List<IBin>();
            for (uint i = 0; i < number_bins; i++)
            {
                bins.Add(new Bin(_target, _logger));
            }

            _control_unit = new ControlUnit(_logger, new RoundRobinAlogrithm(), bins);
            _item_provider = new ItemProvider(new GaussianDistribution(50, 2));
            _item_provider.ItemArrived += _control_unit.item_handler;
        }

        public void start()
        {
            _item_provider.Go();
        }

    }
}