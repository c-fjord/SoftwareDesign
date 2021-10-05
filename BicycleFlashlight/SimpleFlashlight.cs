using System;

namespace BicycleFlashlight
{
    class SimpleFlashlight
    {
        public enum FlaslightEvent { Power }
        enum FlaslightState { OFF, ON }

        private FlaslightState _currentState;

        public SimpleFlashlight()
        {
            _currentState = FlaslightState.OFF;
        }

        public void HandelEvent(FlaslightEvent evt)
        {
            switch (_currentState)
            {
                case FlaslightState.OFF:
                    _currentState = FlaslightState.ON;
                    Console.WriteLine("Flash Light is now on");
                    break;
                case FlaslightState.ON:
                    _currentState = FlaslightState.OFF;
                    Console.WriteLine("Flash Light is now off");
                    break;
            }
        }

    }

}