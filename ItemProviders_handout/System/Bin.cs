using PortioningMachine.Logger;

namespace PortioningMachine.SystemComponents
{
    class Bin : IBin
    {
        public double weight {get {return _weight; }}
        public double target {get; }
        
        private double _weight = 0;
        private ILogger _logger;

        public Bin(double target, ILogger logger)
        {
            this.target = target;
            _logger = logger;
        }

        public void add(IItem item)
        {
            _weight += item.Weight;
            if (_weight >= target) empty();
        }

        private void empty()
        {
            double giveaway = ((_weight - target) / target) * 100; 
            string log = string.Format("Bin weight: {0} Target weight: {1} Giveaway: {2}", _weight, target, giveaway);
            _logger.bin_closed(this);
            _weight = 0;
        }
    }
}