using System;

namespace Parrot
{
    public class NorwegianParrot : Parrot
    {
        private bool _isNailed;
        private double _voltage;

        public NorwegianParrot(bool isNailed, double voltage)
        {
            _isNailed = isNailed;
            _voltage = voltage;
        }

        public override double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }

        private double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * base.GetBaseSpeed());
        }

    }
}