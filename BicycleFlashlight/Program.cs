using System;

namespace BicycleFlashlight
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SimpleFlashlight bicycleLight = new SimpleFlashlight();
            bicycleLight.HandelEvent(SimpleFlashlight.FlaslightEvent.Power);
            bicycleLight.HandelEvent(SimpleFlashlight.FlaslightEvent.Power);
            */

            Flashlight GOF_bicycleLight = new Flashlight();
            GOF_bicycleLight.Power();
            GOF_bicycleLight.Mode();
            GOF_bicycleLight.Mode();
            GOF_bicycleLight.Mode();
            GOF_bicycleLight.Power();
            GOF_bicycleLight.Power();
        }
    }
}
