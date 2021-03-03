using CarManager;
using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test_Car_Class_Implementation_Correctly()
        {
            // Arrange
            string make = "Toyota";
            string model = "Corolla";
            double fuelConsimption = 4.50;
            double fuelCapacity = 200;

            var car = new Car(make, model, fuelConsimption, fuelCapacity);
            // Act

            // Assert
        }
    }
}