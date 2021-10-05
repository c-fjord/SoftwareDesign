namespace Phone
{
    public class Unmute : Connected
    {
        public static Unmute Instance { get; private set; }

        static Unmute()
        {
            Instance = new Unmute();
        }

        public override void HandelToggleMute(Phone context)
        {
            context.SetState(Mute.Instance);
        }

        public override void OnEnter(Phone context)
        {
            context.TurnMicOn();
        }
    }
}