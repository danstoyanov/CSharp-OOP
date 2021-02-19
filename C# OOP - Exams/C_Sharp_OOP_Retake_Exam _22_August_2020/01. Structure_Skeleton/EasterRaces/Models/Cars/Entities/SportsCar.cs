using EasterRaces.Utilities.Messages;
using System;

namespace EasterRaces.Models.Cars.Entities
{
    public class SportsCar : Car
    {
        private const int CURR_CAR_CUBIC_CENTIMETERS = 3000;
        private const int CURR_CAR_MIN_HORSE_POWER = 250;
        private const int CURR_CAR_MAX_HORSE_POWER = 450;

        private int horsePower;

        public SportsCar(string model, int horsePower, double cubicCentimeters) 
            : base(model, horsePower, CURR_CAR_CUBIC_CENTIMETERS)
        {
            this.HorsePower = horsePower;
        }

        public override int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            protected set
            {
                if (value < CURR_CAR_MIN_HORSE_POWER && value > CURR_CAR_MAX_HORSE_POWER)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidHorsePower, value));
                }

                this.horsePower = value;
            }
        }
    }
}
