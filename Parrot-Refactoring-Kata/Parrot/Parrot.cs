using System;

namespace Parrot
{   
    public abstract class Parrot
    {
        public static Parrot Create(ParrotTypeEnum type, int numberOfCoconuts = 0, double voltage = 0, bool isNailed = false)
        {
            switch (type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return new EuropeanParrot();
                
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return new NorwegianParrot(isNailed, voltage);
                
                case ParrotTypeEnum.AFRICAN:
                    return new AfricanParrot(numberOfCoconuts);
                default:
                    throw new Exception("Unknown parrot type");
            }
        }

        public static Parrot Create(ParrotTypeEnum type)
        {
            if (type == ParrotTypeEnum.EUROPEAN)
            {
                return new EuropeanParrot();
            }
            throw new Exception("More paramaters needed");
        }

        public static Parrot Create(ParrotTypeEnum type, double voltage, bool isNailed)
        {
            return new NorwegianParrot(isNailed, voltage);
        }

        public static Parrot Create(ParrotTypeEnum typeEnum, int numberOfCoconuts)
        {
            return new AfricanParrot(numberOfCoconuts);
        }

        public abstract double GetSpeed();
        protected double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}