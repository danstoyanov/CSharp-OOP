namespace Structure.Models.Drivers.Contracts
{
    public interface IDriver
    {
        string Name { get; }

        double TotalTime { get; }

        double FuelConsumptionPerKm { get; }

        double Speed { get; }
    }
}
