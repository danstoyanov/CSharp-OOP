using Structure.Models.Cars;
using Structure.Models.Drivers.Contracts;

namespace Structure.Models.Drivers
{
    public class Driver : IDriver
    {
        public Driver(string name, double totalTime, Car car, double fuelConsumptionPerKm)
        {
            this.Name = name;
            this.TotalTime = totalTime;
            this.Car = car;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public string Name { get; private set; }

        public double TotalTime { get; private set; }

        public Car Car { get; private set; }

        public double FuelConsumptionPerKm { get; private set; }

        public virtual double  Speed => 
            (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
    }
}
