using System;
using NUnit.Framework;

using CarManager;

namespace Tests
{
    public class CarTests
    {
        private const string make = "Toyota";
        private const string model = "Corolla";
        private const double fuelConsimption = 4.50;
        private const double fuelCapacity = 200;

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test_Car_Class_Implementation_Correctly()
        {
            // Arrange
            var car = new Car(make, model, fuelConsimption, fuelCapacity);

            // Assert
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsimption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
        }

        [Test]
        public void Test_Make_If_Is_Null_Or_Empty_And_Throw_Exception_MSG()
        {
            // Arrange
            var car = new Car(make, model, fuelConsimption, fuelCapacity);

            //Assert
            Assert.Throws<ArgumentException>(() =>
            car = new Car("", model, fuelConsimption, fuelCapacity), "Make cannot be null or empty!");
        }
    }
}