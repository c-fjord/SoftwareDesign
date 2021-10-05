namespace Phone
{
    public class LoudSpeaker : SpeakerState
    {
        public static LoudSpeaker Instance { get; private set; }

        static LoudSpeaker()
        {
            Instance = new LoudSpeaker();
        }

        public override void HandelToggleSpeaker(Phone context)
        {
            context.SetSpeakerState(Speaker.Instance);
        }

        public override void OnEnter(Phone context)
        {
            context.TurnSpeakerOn();
        }
    }
}