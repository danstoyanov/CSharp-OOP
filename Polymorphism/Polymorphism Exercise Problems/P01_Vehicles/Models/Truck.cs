using System;

using P01_Vehicles.Contracts;

namespace P01_Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double MORE_FUEL_CONSMP = 1.6;
        private const double INCREASE_CAPACITY_VALUE = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {

        }

        public override string Drive(double distance)
        {
            if (this.FuelQuantity - (distance * (this.FuelConsumption + MORE_FUEL_CONSMP)) >= 0)
            {
                this.FuelQuantity -= distance * (this.FuelConsumption + MORE_FUEL_CONSMP);

                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                throw new Exception ($"{this.GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double refuelQuantity)
        {
            refuelQuantity *= INCREASE_CAPACITY_VALUE;
            this.FuelQuantity += refuelQuantity;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
