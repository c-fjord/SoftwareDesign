namespace Phone
{
    public class Idle : PhoneState
    {
        public static Idle Instance { get; private set; }

        static Idle()
        {
            Instance = new Idle();
        }

        public override void HandelCallButton(Phone context)
        {
            context.SetState(Calling.Instance);
        }

        public override void HandelDigitPressed(Phone context, int digit)
        {
            context.AddDigit(digit);
            context.SetState(Instance);
        }
    }
}