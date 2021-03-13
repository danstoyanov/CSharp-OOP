using Structure.Models.Cars.Contracts;

namespace Structure.Models.Cars
{
    public class Car : ICar
    {


        public int Hp { get; private set; }

        public double FuelAmount { get; private set; }
    }
}
