using System;

namespace P02_Vehicles_Extension.Models
{
    public class Bus : Vehicle
    {
        private const double MORE_FUEL_CONSMP = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override string Drive(double distance)
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

        public string DriveEmpty(double distance)
        {
            if (this.IntitialFuelQuantity - (distance * (this.LitersPerKm + MORE_FUEL_CONSMP)) >= 0)
            {
                this.IntitialFuelQuantity -= distance * (this.LitersPerKm + +MORE_FUEL_CONSMP);

                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                throw new Exception($"{this.GetType().Name} needs refueling");
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
