using PortioningMachine.Logger;

namespace PortioningMachine.SystemComponents
{
    public class ScoreBin : Bin, IScoreBin
    {
        public IItemScore score_method{get{return _socre_method;} }
        private IItemScore _socre_method;
        public ScoreBin(double target, ILogger logger, IItemScore score) : base(target, logger)
        {
            _socre_method = score;
        }
        
        public double score_item(IItem item)
        {
            return score_method.score(item, this);
        }
    }
}