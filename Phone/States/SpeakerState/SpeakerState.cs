namespace Phone
{
    public abstract class SpeakerState
    {
        public abstract void HandelToggleSpeaker(Phone context);
        public abstract void OnEnter(Phone context);
    }
}