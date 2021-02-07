using P02_Vehicles_Extension.Contracts;
using System;

namespace P02_Vehicles_Extension
{
    public class Vehicle : IVehicle
    {
        private double intitialFuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.LitersPerKm = fuelConsumption;
            this.IntitialFuelQuantity = fuelQuantity;
        }

        public double IntitialFuelQuantity
        {
            get
            {
                return this.intitialFuelQuantity;
            }
            set
            {
                if (this.intitialFuelQuantity <= this.TankCapacity)
                {
                    this.intitialFuelQuantity = value;
                }
                else
                {
                    this.intitialFuelQuantity = 0;
                }
            }
        }

        public double LitersPerKm { get; private set; }

        public double TankCapacity { get; private set; }

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
