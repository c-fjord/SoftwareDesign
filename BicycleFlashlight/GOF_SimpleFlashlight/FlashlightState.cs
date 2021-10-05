using System;

namespace BicycleFlashlight
{
    public abstract class GOF_SimpleFlashlight
    {
        abstract public void HandelPowerEvent(Flashlight context);
        abstract public void HandelModeEvent(Flashlight context);
        abstract public void OnEnter(Flashlight context);
        abstract public void OnExit(Flashlight context);
    }

    public abstract class On : GOF_SimpleFlashlight
    {
        protected On()
        {

        }

        public override void OnEnter(Flashlight context)
        {
            context.LightOn();
        }

        public override void HandelPowerEvent(Flashlight context)
        {
            context.setState(Off.Instance);
        }

        public override void HandelModeEvent(Flashlight context) { }

        public override void OnExit(Flashlight context) { }
    }

    public class Off : GOF_SimpleFlashlight
    {
        public static Off Instance { get; private set; }

        static Off()
        {
            Instance = new Off();
        }

        public override void HandelPowerEvent(Flashlight context)
        {
            context.setState(Solid.Instance);
        }

        public override void HandelModeEvent(Flashlight context) { }

        public override void OnEnter(Flashlight context)
        {
            context.LightOff();
        }

        public override void OnExit(Flashlight context) { }
    }

    public class Solid : On
    {
        public static Solid Instance { get; private set; }

        static Solid()
        {
            Instance = new Solid();
        }

        public override void HandelModeEvent(Flashlight context)
        {
            context.setState(Flash.Instance);
        }
        public override void OnEnter(Flashlight context)
        {
            base.OnEnter(context);
            context.SolidLED();
        }
    }

    public class Flash : On
    {
        public static Flash Instance { get; private set; }

        static Flash()
        {
            Instance = new Flash();
        }

        public override void HandelModeEvent(Flashlight context)
        {
            context.setState(Solid.Instance);
        }
        public override void OnEnter(Flashlight context)
        {
            base.OnEnter(context);
            context.FlashLED();
        }
    }
}