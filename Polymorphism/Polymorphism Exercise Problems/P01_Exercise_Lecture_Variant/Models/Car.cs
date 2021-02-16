namespace P01_Exercise_Lecture_Variant.Models
{
    public class Car : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCR = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {

        }

        public override double FuelConsumption => base.FuelConsumption + FUEL_CONSUMPTION_INCR;
    }
}
