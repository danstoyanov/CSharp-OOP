﻿using System;

using EasterRaces.Utilities.Messages;
using EasterRaces.Models.Cars.Contracts;

namespace EasterRaces.Models.Cars.Entities
{
    public abstract class Car : ICar
    {
        private const int MIN_MODEL_NAME_SYMBOLS = 4;

        private string model;

        public Car(string model, int horsePower, double cubicCentimeters)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
        }


        public string Model
        {
            get
            {
                return this.model;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < MIN_MODEL_NAME_SYMBOLS)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidModel, value, MIN_MODEL_NAME_SYMBOLS));
                }

                this.model = value;
            }
        }


        public abstract int HorsePower { get; protected set; }

        public double CubicCentimeters { get; }

        public double CalculateRacePoints(int laps) => this.CubicCentimeters / this.HorsePower * laps;
    }
}
