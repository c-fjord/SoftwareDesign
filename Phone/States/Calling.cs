namespace Phone
{
    public class Calling : PhoneState
    {
        public static Calling Instance { get; private set; }

        static Calling()
        {
            Instance = new Calling();
        }

        public override void HandelConnectionEstablished(Phone context)
        {
            context.SetState(Unmute.Instance);
        }

        public override void OnEnter(Phone context)
        {
            context.CallNumber();
        }

    }
}