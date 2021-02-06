using System;

namespace P01_Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double MORE_FUEL_CONSMP = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
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
            base.Refuel(refuelQuantity);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
