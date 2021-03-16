using System;

using EasterRaces.Utilities.Messages;
using EasterRaces.Models.Cars.Contracts;

namespace EasterRaces.Models.Cars.Entities
{
    public abstract class Car : ICar
    {
        private string model;
        private int minHorsePower;
        private int maxHorsePower;
        private int horsePower;
        private double cubicCentimeters;

        public Car(string model, int horsePower, double cubicCentimeters, int minHoursePower, int maxHoursePower)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
            this.MinHorsePower = minHoursePower;
            this.MaxHorsePower = maxHoursePower;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidModel, value, 4));
                }

                this.model = value;
            }
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            private set
            {
                if (value < this.MinHorsePower && value > this.MaxHorsePower)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower, value));
                }

                this.horsePower = value;
            }
        }

        public int MinHorsePower
        {
            get
            {
                return this.minHorsePower;
            }
            private set
            {
                this.minHorsePower = value;
            }
        }

        public int MaxHorsePower
        {
            get
            {
                return this.maxHorsePower;
            }
            private set
            {
                this.horsePower = value;
            }
        }

        public double CubicCentimeters
        {
            get
            {
                return this.cubicCentimeters;
            }
            private set
            {
                cubicCentimeters = value;
            }
        }

        public double CalculateRacePoints(int laps)
        {
            double calculateRacePoints = this.CubicCentimeters / this.HorsePower * laps;

            return calculateRacePoints;
        }
    }
}
