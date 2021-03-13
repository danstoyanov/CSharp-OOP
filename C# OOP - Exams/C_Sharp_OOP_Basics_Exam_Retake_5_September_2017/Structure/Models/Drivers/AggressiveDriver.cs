using Structure.Models.Cars;

namespace Structure.Models.Drivers
{
    public class AggressiveDriver : Driver
    {
        private const double AGRESIVE_FUEL_CONSP_PER_KM = 2.7;

        public AggressiveDriver(string name, double totalTime, Car car) 
            : base(name, totalTime, car, AGRESIVE_FUEL_CONSP_PER_KM)
        {

        }

        public override double Speed => base.Speed * 1.3;
    }
}
