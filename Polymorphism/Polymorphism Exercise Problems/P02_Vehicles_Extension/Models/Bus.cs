using System;

namespace P02_Vehicles_Extension.Models
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override string Drive(double distance)
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

        public override void Refuel(double refuelQuantity)
        {
            base.Refuel(refuelQuantity);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
