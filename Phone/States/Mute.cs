namespace Phone
{
    public class Mute : Connected
    {
        public static Mute Instance { get; private set; }

        static Mute()
        {
            Instance = new Mute();
        }

        public override void HandelToggleMute(Phone context)
        {
            context.SetState(Unmute.Instance);
        }

        public override void OnEnter(Phone context)
        {
            context.TurnMicOff();
        }
    }
}