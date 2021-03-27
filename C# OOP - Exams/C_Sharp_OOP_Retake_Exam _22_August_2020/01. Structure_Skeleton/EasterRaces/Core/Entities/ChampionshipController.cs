using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using EasterRaces.Core.Contracts;
using EasterRaces.Utilities.Messages;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Drivers.Contracts;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private readonly List<IDriver> drivers;
        private readonly List<ICar> cars;
        private readonly List<IRace> races;

        public ChampionshipController()
        {
            this.drivers = new List<IDriver>();
            this.cars = new List<ICar>();
            this.races = new List<IRace>();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            if (!this.drivers.Any(d => d.Name == driverName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            if (! this.cars.Any(c => c.Model == carModel))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarNotFound, carModel));
            }

            var currentDriver = this.drivers.FirstOrDefault(d => d.Name == driverName);
            var currentCar = this.cars.FirstOrDefault(c => c.Model == carModel);

            currentDriver.AddCar(currentCar);

            string outputMsg = string.Format(OutputMessages.CarAdded, driverName, carModel);

            return outputMsg.ToString().Trim();
        }

        public string AddDriverToRace(string raceName, string driverName)
        {

            if (!this.races.All(r => r.Name == raceName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            if (!this.drivers.Any(d => d.Name == driverName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            var currentRace = this.races.FirstOrDefault(r => r.Name == raceName);
            var currentDriver = this.drivers.FirstOrDefault(d => d.Name == driverName);

            currentRace.AddDriver(currentDriver);

            string outputMsg = string.Format(OutputMessages.DriverAdded, driverName, raceName);

            return outputMsg.ToString().Trim();
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            if (this.cars.Exists(c => c.Model == model))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists, model));
            }

            string outputMsg = "";

            if (type == "Muscle")
            {
                this.cars.Add(new MuscleCar(model, horsePower));
                outputMsg = string.Format(OutputMessages.CarCreated, "MuscleCar", model);
            }
            else if (type == "Sports")
            {
                this.cars.Add(new SportsCar(model, horsePower));
                outputMsg = string.Format(OutputMessages.CarCreated, "SportsCar", model);
            }

            return outputMsg.ToString().Trim();
        }

        public string CreateDriver(string driverName)
        {
            if (this.drivers.Exists(d => d.Name == driverName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriversExists, driverName));
            }

            this.drivers.Add(new Driver(driverName));
            string outputMsg = string.Format(OutputMessages.DriverCreated, driverName);

            return outputMsg.ToString().Trim();
        }

        public string CreateRace(string name, int laps)
        {
            if (this.races.Any(r => r.Name == name))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, name));
            }

            this.races.Add(new Race(name, laps));

            string outputMsg = string.Format(OutputMessages.RaceCreated, name);

            return outputMsg.ToString().Trim();
        }

        public string StartRace(string raceName)
        {
            if (this.races.Any(r => r.Name != raceName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            var currentRace = this.races.FirstOrDefault(r => r.Name == raceName);

            if (currentRace.Drivers.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, 3));
            }

            var list = new List<IDriver>(currentRace.Drivers);
            var sb = new StringBuilder();

            list.OrderByDescending(d => d.CanParticipate);

            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    sb.AppendLine(string.Format(OutputMessages.DriverFirstPosition, list[i].Name, raceName));
                }
                
                if (i == 1)
                {
                    sb.AppendLine(string.Format(OutputMessages.DriverSecondPosition, list[i].Name, raceName));
                }

                if (i == 2)
                {
                    sb.AppendLine(string.Format(OutputMessages.DriverThirdPosition, list[i].Name, raceName));
                }
            }

            this.races.Remove(currentRace);

            return sb.ToString().Trim();
        }
    }
}
