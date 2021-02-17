namespace PortioningMachine.SystemComponents
{
    public interface IScoreBin : IBin
    {  
        IItemScore score_method{get; }
        double score_item(IItem item);
    }
}