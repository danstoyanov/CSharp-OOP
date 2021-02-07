using P02_Vehicles_Extension.Contracts;
using System;

namespace P02_Vehicles_Extension
{
    public class Vehicle : IVehicle
    {
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.IntitialFuelQuantity = fuelQuantity;
            this.LitersPerKm = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double IntitialFuelQuantity { get; set; }

        public double LitersPerKm { get; private set; }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                if (this.IntitialFuelQuantity <= value)
                {
                    this.tankCapacity = value;
                }

                this.tankCapacity = 0;
            }
        }

        public virtual string Drive(double distance)
        {
            if (this.IntitialFuelQuantity - (distance * (this.LitersPerKm)) >= 0)
            {
                this.IntitialFuelQuantity -= distance * (this.LitersPerKm);

                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                throw new Exception($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double refuelQuantity)
        {
            if (refuelQuantity > 0)
            {
                if (this.IntitialFuelQuantity + refuelQuantity <= this.TankCapacity)
                {
                    this.IntitialFuelQuantity += refuelQuantity;
                }
                else
                {
                    throw new Exception($"Cannot fit {refuelQuantity} fuel in the tank");
                }
            }
            else
            {
                throw new Exception("Fuel must be a positive number");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.IntitialFuelQuantity:F2}";
        }
    }
}
