using System;

using P02_Vehicles_Extension.Contracts;

namespace P02_Vehicles_Extension.Models
{
    public class Truck : Vehicle
    {
        private const double MORE_FUEL_CONSMP = 1.6;
        private const double INCREASE_CAPACITY_VALUE = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override string Drive(double distance)
        {
            if (this.IntitialFuelQuantity - (distance * (this.LitersPerKm + MORE_FUEL_CONSMP)) >= 0)
            {
                this.IntitialFuelQuantity -= distance * (this.LitersPerKm + MORE_FUEL_CONSMP);

                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                throw new Exception($"{this.GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double refuelQuantity)
        {
            refuelQuantity *= INCREASE_CAPACITY_VALUE;

            if (this.IntitialFuelQuantity + refuelQuantity <= this.TankCapacity)
            {
                this.IntitialFuelQuantity += refuelQuantity;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
