namespace P02_Vehicles_Extension.Contracts
{
    public interface IVehicle
    {
        public double IntitialFuelQuantity { get; }
        public double LitersPerKm { get; }
        public double TankCapacity { get; }

        public string Drive(double distance);
        public void Refuel(double refuelQuantity);
    }
}
