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

        private Car car;

        [SetUp]
        public void Setup()
        {
            this.car = new Car(make, model, fuelConsimption, fuelCapacity);
        }

        [Test]
        public void Test_Car_Class_Implementation_Correctly()
        {
            // Assert
            Assert.AreEqual(make, this.car.Make);
            Assert.AreEqual(model, this.car.Model);
            Assert.AreEqual(fuelConsimption, this.car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, this.car.FuelCapacity);
        }

        [Test]
        public void Test_Make_If_Is_Empty_And_Throw_Argument_Exception_MSG()
        {
            //Assert
            Assert.Throws<ArgumentException>(() =>
            this.car = new Car("", model, fuelConsimption, fuelCapacity), "Make cannot be null or empty!");
        }

        [Test]
        public void Test_Make_If_Is_Null_And_Throw_Argument_Exception_MSG()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            this.car = new Car(null, model, fuelConsimption, fuelCapacity), "Make cannot be null or empty!");
        }

        [Test]
        public void Test_Model_If_Is_Empty_And_Throw_Argument_Exception_MSG()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            this.car = new Car(make, "", fuelConsimption, fuelCapacity), "Model cannot be null or empty!");
        }

        [Test]
        public void Test_Model_If_Is_Null_And_Throw_Argument_Exception_MSG()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            this.car = new Car(make, null, fuelConsimption, fuelCapacity), "Model cannot be null or empty!");
        }

        [Test]
        public void Test_FuelConsumption_If_Equal_To_Zero_Throw_Argument_Exception_MSG()
        {
            Assert.Throws<ArgumentException>(() =>
            this.car = new Car(make, model, 0, fuelCapacity), "Fuel consumption cannot be zero or negative!");
        }

        [Test]
        public void Test_FuelConsumption_If_Less_Than_Zero_Throw_Argument_Exception_MSG()
        {
            Assert.Throws<ArgumentException>(() =>
            this.car = new Car(make, model, -1, fuelCapacity), "Fuel consumption cannot be zero or negative!");
        }

        []
    }
}