namespace OverTheHillsAndFarAway
{
    public enum Activities
    {
        WakeUp,
        Dinner,
        WatchTV,
        ByeBye
    }

    public interface ISubject
    {
        void Attach(IObserver obs);
        void Detach(IObserver obs);
        void Notify();
    }
}