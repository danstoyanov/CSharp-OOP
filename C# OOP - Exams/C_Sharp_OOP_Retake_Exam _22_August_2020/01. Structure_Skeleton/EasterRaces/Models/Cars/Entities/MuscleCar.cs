using EasterRaces.Utilities.Messages;
using System;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car
    {
        private const int CURR_CAR_CUBIC_CENTIMETERS = 5000;
        private const int CURR_CAR_MIN_HORSE_POWER = 400;
        private const int CURR_CAR_MAX_HORSE_POWER = 600;

        private int horsePower;

        public MuscleCar(string model, int horsePower)
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
