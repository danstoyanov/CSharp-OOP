using P02_Vehicles_Extension.Contracts;
using System;

namespace P02_Vehicles_Extension
{
    public class Vehicle : IVehicle
    {
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                if (this.FuelQuantity <= value)
                {
                    this.tankCapacity = value;
                }

                this.tankCapacity = 0;
            }
        }

        public virtual string Drive(double distance)
        {
            if (this.FuelQuantity - (distance * (this.FuelConsumption)) >= 0)
            {
                this.FuelQuantity -= distance * (this.FuelConsumption);

                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                throw new Exception($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double refuelQuantity)
        {
            if (this.FuelQuantity + refuelQuantity <= this.TankCapacity)
            {
                this.FuelQuantity += refuelQuantity;
            }
            else
            {
                throw new Exception($"Cannot fit {refuelQuantity} fuel in the tank");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
