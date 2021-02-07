using P02_Vehicles_Extension.Contracts;
using System;

namespace P02_Vehicles_Extension
{
    public class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

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
            this.FuelQuantity += refuelQuantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
