using System;
using System.Linq;
using System.Collections.Generic;

using EasterRaces.Utilities.Messages;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Drivers.Contracts;

namespace EasterRaces.Models.Races.Entities
{
    public class Race : IRace
    {
        private const int MIN_RACE_NAME_SYMBOLS = 5;
        private const int MIN_LAPS_VALUE = 1;

        private string name;
        private int laps;

        private readonly List<IDriver> drivers;

        public Race(string name, int laps)
        {
            this.Name = name;
            this.Laps = laps;
            this.drivers = new List<IDriver>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < MIN_RACE_NAME_SYMBOLS)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidName, value, MIN_RACE_NAME_SYMBOLS));
                }

                this.name = value;
            }
        }

        public int Laps
        {
            get
            {
                return this.laps;
            }
            private set
            {
                if (value < MIN_LAPS_VALUE)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidNumberOfLaps, MIN_LAPS_VALUE));
                }

                this.laps = value;
            }
        }

        public IReadOnlyCollection<IDriver> Drivers => this.drivers;
        public void AddDriver(IDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(IDriver), String.Format(ExceptionMessages.DriverInvalid));
            }

            if (!driver.CanParticipate)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.DriverNotParticipate, driver.Name));
            }

            if (this.drivers.Any(d => d.Name == driver.Name))
            {
                throw new ArgumentNullException(nameof(IDriver), String.Format(ExceptionMessages.DriverAlreadyAdded, driver.Name, this.Name));
            }

            this.drivers.Add(driver);
        }
    }
}
