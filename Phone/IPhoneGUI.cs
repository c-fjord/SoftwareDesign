namespace Phone
{
    public interface IPhoneGUI
    {
        void CallButton();
        void ConnectionEstablished();
        void DigitPressed(int digit);
        void Disconnected();
        void ToggleMute();
        void ToggleSpeaker();
    }
}