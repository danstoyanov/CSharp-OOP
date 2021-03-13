namespace Structure.Models.Drivers.Contracts
{
    public interface IDriver
    {
        string Name { get; }

        double TotalTime { get; }

        Car CurrentCar { get; }

        double FuelConsumptionPerKm { get; }

        double Speed { get; }
    }
}
