using System;

namespace BicycleFlashlight
{
    public class Flashlight
    {
        private GOF_SimpleFlashlight _currentState;

        public Flashlight()
        {
            _currentState = new Off();
        }

        public void Power()
        {
            _currentState.HandelPowerEvent(this);
        }

        public void Mode()
        {
            _currentState.HandelModeEvent(this);
        }

        public void LightOn()
        {
            Console.WriteLine("Flashlight is now on");
        }

        public void LightOff()
        {
            Console.WriteLine("Flashlight is now off");
        }

        public void SolidLED()
        {
            Console.WriteLine("Flashlight is now solid");
        }

        public void FlashLED()
        {
            Console.WriteLine("Flashlight is now flashing");
        }

        public void setState(GOF_SimpleFlashlight s)
        {
            _currentState.OnExit(this);
            _currentState = s;
            _currentState.OnEnter(this);
        }
    }
}