namespace Phone
{
    public class Speaker : SpeakerState
    {
        public static Speaker Instance { get; private set; }

        static Speaker()
        {
            Instance = new Speaker();
        }

        public override void HandelToggleSpeaker(Phone context)
        {
            context.SetSpeakerState(LoudSpeaker.Instance);
        }

        public override void OnEnter(Phone context)
        {
            context.TurnSpeakerOff();
        }
    }
}