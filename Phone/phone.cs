using System;
using System.Collections.Generic;

namespace Phone
{
    public class Phone : IPhoneInternal, IPhoneGUI
    {
        private List<int> _currentNumber = new List<int>();
        private PhoneState state;
        private SpeakerState speakerState;

        public Phone()
        {
            state = Idle.Instance;
            speakerState = Speaker.Instance;
        }

        public void SetState(PhoneState state)
        {
            state.OnExit(this);
            this.state = state;
            state.OnEnter(this);
        }

        public void SetSpeakerState(SpeakerState state)
        {
            this.speakerState = state;
            state.OnEnter(this);
        }

        // User Actions
        public void CallButton()
        {
            state.HandelCallButton(this);
        }

        public void ConnectionEstablished()
        {
            state.HandelConnectionEstablished(this);
        }

        public void DigitPressed(int digit)
        {
            state.HandelDigitPressed(this, digit);
        }

        public void Disconnected()
        {
            state.HandelDisconnected(this);
        }

        public void ToggleMute()
        {
            state.HandelToggleMute(this);
        }

        public void ToggleSpeaker()
        {
            speakerState.HandelToggleSpeaker(this);
        }

        // Internal Actions
        public void AddDigit(int digit)
        {
            _currentNumber.Add(digit);
            Console.WriteLine("{0} has been added", digit);
        }

        public void CallNumber()
        {
            Console.WriteLine("Calling: " + String.Join(" ", _currentNumber));
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting call");
        }

        public void TurnMicOn()
        {
            Console.WriteLine("Microphone is now on");
        }

        public void TurnMicOff()
        {
            Console.WriteLine("Microphone is now off");
        }

        public void TurnSpeakerOn()
        {
            Console.WriteLine("Speaker is now on");
        }

        public void TurnSpeakerOff()
        {
            Console.WriteLine("Speaker is now off");
        }

        public void ClearNumber()
        {
            _currentNumber.Clear();
            Console.WriteLine("Current number has been cleared");
        }
    }
}