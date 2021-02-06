using P02_Vehicles_Extension.Contracts;

namespace P02_Vehicles_Extension
{
    public class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; private set; }

        public virtual string Drive(double distance)
        {
            this.FuelQuantity -= distance * (this.FuelConsumption);

            return "{0} travelled {1} km";
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
