using Structure.Models.Cars;
using Structure.Models.Tyres;
using Structure.Models.Drivers.Contracts;

namespace Structure.Models.Drivers
{
    public class Driver : IDriver
    {
        public string Name => throw new System.NotImplementedException();

        public double TotalTime => throw new System.NotImplementedException();

        public double FuelConsumptionPerKm => throw new System.NotImplementedException();

        public double Speed => CurrentCar.Hp + 

        public Car CurrentCar { get; private set; }

        private Tyre CurrentTyre { get; private set; }
    }
}
