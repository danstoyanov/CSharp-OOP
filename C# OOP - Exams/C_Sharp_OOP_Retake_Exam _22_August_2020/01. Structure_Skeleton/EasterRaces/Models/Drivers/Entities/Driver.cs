using System;

using EasterRaces.Utilities.Messages;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver : IDriver
    {
        private const int MIN_DRIVER_NAME_SYMBOLS = 5;

        private string name;

        public Driver(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < MIN_DRIVER_NAME_SYMBOLS)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidName, value, MIN_DRIVER_NAME_SYMBOLS));
                }

                this.name = value;
            }
        }

        public ICar Car { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate => this.Car != null;

        public void AddCar(ICar car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(ICar), String.Format(ExceptionMessages.CarInvalid));
            }

            this.Car = car;
        }

        public void WinRace() => this.NumberOfWins++;
    }
}
