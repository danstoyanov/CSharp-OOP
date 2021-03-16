using System;
using System.Linq;

using EasterRaces.Core.Contracts;
using EasterRaces.Utilities.Messages;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Repositories.Entities;
using EasterRaces.Models.Drivers.Entities;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private readonly CarRepository cars;
        private readonly DriverRepository drivers;
        private readonly RaceRepository races;

        public ChampionshipController()
        {
            cars = new CarRepository();
            drivers = new DriverRepository();
            races = new RaceRepository();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            var currentDriver = this.drivers.GetAll().FirstOrDefault(d => d.Name == driverName);

            if (currentDriver == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            var currentCarModel = this.cars.GetAll().FirstOrDefault(c => c.Model == carModel);

            if (currentCarModel == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarNotFound, carModel));
            }

            currentDriver.AddCar(currentCarModel);

            return string.Format(OutputMessages.CarAdded, driverName, carModel);
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            throw new System.NotImplementedException();
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            if (!this.cars.GetAll().Any(c => c.Model == model))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists, model));
            }

            if (type == "Sports")
            {
                this.cars.Add(new SportsCar(model, horsePower));
            }
            else if (type == "Muscle")
            {
                this.cars.Add(new MuscleCar(model, horsePower));
            }

            return string.Format(OutputMessages.CarCreated, type, model);
        }

        public string CreateDriver(string driverName)
        {
            if (!this.drivers.GetAll().Any(d => d.Name == driverName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriversExists, driverName));
            }

            this.drivers.Add(new Driver(driverName));

            return string.Format(OutputMessages.DriverCreated, driverName);
        }

        public string CreateRace(string name, int laps)
        {
            throw new System.NotImplementedException();
        }

        public string StartRace(string raceName)
        {
            throw new System.NotImplementedException();
        }
    }
}
