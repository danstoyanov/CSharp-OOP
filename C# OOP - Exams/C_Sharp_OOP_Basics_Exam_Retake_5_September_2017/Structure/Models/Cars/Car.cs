
using Structure.Models.Tyres;
using Structure.Models.Cars.Contracts;

namespace Structure.Models.Cars
{
    public class Car : ICar
    {
        public Car(int hp, double fuelAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyre;
        }

        public int Hp { get; private set; }

        public double FuelAmount { get; private set; }

        public Tyre Tyre { get; private set; }
    }
}
