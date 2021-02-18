using PortioningMachine.Logger;

namespace PortioningMachine.SystemComponents
{
    public class Bin : IBin
    {
        public double weight {private set; get;} = 0;
        public double target {get; }
        public IItemScore score_method{set; private get;}

        private ILogger _logger;

        public Bin(double target, ILogger logger)
        {
            this.target = target;
            _logger = logger;
        }

        public void add(IItem item)
        {
            weight += item.Weight;
            if (weight >= target) empty();
        }

        private void empty()
        {
            double giveaway = ((weight - target) / target) * 100; 
            _logger.bin_closed(this);
            weight = 0;
        }
        
        public double score_item(IItem item)
        {
            if (score_method != null) return score_method.score(item, this);
            else{
                throw new System.Exception("Score methos has not been sat");
            }
        }
    }
}