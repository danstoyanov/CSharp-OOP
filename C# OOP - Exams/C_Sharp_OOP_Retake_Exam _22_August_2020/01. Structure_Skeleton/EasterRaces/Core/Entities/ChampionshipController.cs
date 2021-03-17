using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using EasterRaces.Core.Contracts;
using EasterRaces.Utilities.Messages;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Repositories.Entities;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Drivers.Contracts;

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

            if (!this.drivers.GetAll().Any(d => d.Name == driverName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            if (!this.cars.GetAll().Any(c => c.Model == carModel))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarNotFound, carModel));
            }

            ICar currentCarModel = this.cars.GetAll().FirstOrDefault(c => c.Model == carModel);
            IDriver currentDriver = this.drivers.GetAll().FirstOrDefault(d => d.Name == driverName);

            currentDriver.AddCar(currentCarModel);

            return string.Format(OutputMessages.CarAdded, driverName, carModel);
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            if (!this.races.GetAll().Any(r => r.Name == raceName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            if (!this.drivers.GetAll().Any(d => d.Name == driverName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            IRace currentRace = this.races.GetAll().FirstOrDefault(r => r.Name == raceName);
            IDriver currentDriver = this.drivers.GetAll().FirstOrDefault(d => d.Name == driverName);

            currentRace.AddDriver(currentDriver);

            return string.Format(OutputMessages.DriverAdded, driverName, raceName);
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            if (this.cars.GetAll().Any(c => c.Model == model))
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
            if (this.drivers.GetAll().Any(d => d.Name == driverName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriversExists, driverName));
            }

            this.drivers.Add(new Driver(driverName));

            return string.Format(OutputMessages.DriverCreated, driverName);
        }

        public string CreateRace(string name, int laps)
        {
            if (this.races.GetAll().Any(r => r.Name == name))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, name));
            }

            this.races.Add(new Race(name, laps));

            return string.Format(OutputMessages.RaceCreated, name);
        }

        public string StartRace(string raceName)
        {
            if (!this.races.GetAll().Any(r => r.Name == raceName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            if (this.races.GetAll().Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, 3));
            }

            StringBuilder sb = new StringBuilder();

            IRace currentRace = this.races.GetAll().FirstOrDefault(r => r.Name == raceName);

            List<IDriver> drivers = currentRace.Drivers
                .ToList()
                .OrderByDescending(d => d.Car.CalculateRacePoints(currentRace.Laps))
                .Take(3)
                .ToList();

            for (int i = 0; i < drivers.Count; i++)
            {
                IDriver raceDriver = drivers[i];

                if (i == 0)
                {
                    sb.AppendLine(string.Format(OutputMessages.DriverFirstPosition, raceDriver.Name, raceName));
                }
                else if (i == 1)
                {
                    sb.AppendLine(string.Format(OutputMessages.DriverSecondPosition, raceDriver.Name, raceName));
                }
                else if (i == 2)
                {
                    sb.AppendLine(string.Format(OutputMessages.DriverThirdPosition, raceDriver.Name, raceName));
                }
            }

            this.races.Remove(currentRace);

            return sb.ToString().Trim();
        }
    }
}
