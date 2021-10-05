namespace Phone
{
    public interface IPhoneInternal
    {
        void AddDigit(int digit);
        void CallNumber();
        void Disconnect();
        void TurnMicOn();
        void TurnMicOff();
        void TurnSpeakerOn();
        void TurnSpeakerOff();
        void ClearNumber();
    }
}