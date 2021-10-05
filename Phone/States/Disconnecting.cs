namespace Phone
{
    public class Disconnecting : PhoneState
    {
        public static Disconnecting Instance { get; private set; }

        static Disconnecting()
        {
            Instance = new Disconnecting();
        }

        public override void HandelDisconnected(Phone context)
        {
            context.SetState(Idle.Instance);
        }

        public override void OnEnter(Phone context)
        {
            context.TurnMicOff();
            context.Disconnect();
        }

        public override void OnExit(Phone context)
        {
            context.ClearNumber();
        }
    }
}