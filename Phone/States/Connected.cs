namespace Phone
{
    public abstract class Connected : PhoneState
    {
        protected Connected()
        {

        }

        public override void HandelCallButton(Phone context)
        {
            context.SetState(Disconnecting.Instance);
        }
    }
}