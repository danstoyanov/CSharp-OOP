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
            return base.Drive(distance);
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
