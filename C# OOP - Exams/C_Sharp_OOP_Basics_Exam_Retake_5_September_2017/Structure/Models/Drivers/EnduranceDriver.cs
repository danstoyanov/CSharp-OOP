using Structure.Models.Cars;

namespace Structure.Models.Drivers
{
    public class EnduranceDriver : Driver
    {
        private const double ENDURANCE_FUEL_CONSP_PER_KM = 1.5;

        public EnduranceDriver(string name, double totalTime, Car car) 
            : base(name, totalTime, car, ENDURANCE_FUEL_CONSP_PER_KM)
        {

        }
    }
}
