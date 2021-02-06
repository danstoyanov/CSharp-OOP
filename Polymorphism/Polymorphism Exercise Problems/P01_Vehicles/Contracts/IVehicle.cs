namespace P01_Vehicles.Contracts
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }

        public string Drive(double distance);
        public void Refuel(double refuelQuantity);
    }
}
