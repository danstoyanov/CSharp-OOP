using System;

namespace P02_Vehicles_Extension.Models
{
    public class Car : Vehicle
    {
        private const double MORE_FUEL_CONSMP = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
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
                throw new Exception ($"{this.GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double refuelQuantity)
        {
            base.Refuel(refuelQuantity);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
