using System;
using System.Collections.Generic;
using System.Linq;

using P04_Border_Control.Models;
using P04_Border_Control.Contracts;
using P05_Birthday_Celebrations.Models;
using P05_Birthday_Celebrations.Contracts;

namespace P04_Border_Control.Core
{
    public class Engine : IEngine
    {
        private readonly List<IInhabitants> inhabitans;
        private readonly List<IBirthdates> birthdates;

        public Engine()
        {
            this.inhabitans = new List<IInhabitants>();
            this.birthdates = new List<IBirthdates>();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command
                    .Split(" ")
                    .ToArray();

                if (args[0] == "Citizen")
                {
                    string name = args[1];
                    string age = args[2];
                    string id = args[3];
                    string birthdate = args[4];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    this.inhabitans.Add(citizen);
                    this.birthdates.Add(citizen);
                }
                else if (args[0] == "Robot")
                {
                    string model = args[0];
                    string id = args[1];

                    Robot robot = new Robot(model, id);
                    this.inhabitans.Add(robot);
                }
                else if (args[0] == "Pet")
                {
                    string name = args[1];
                    string birthdate = args[2];

                    Pet pet = new Pet(name, birthdate);
                    this.birthdates.Add(pet);
                }
            }

            string lastDigits = Console.ReadLine();

            foreach (var inhabitan in this.birthdates)
            {
                if (inhabitan.Birthdate.EndsWith(lastDigits))
                {
                    Console.WriteLine(inhabitan.Birthdate);
                }
            }
        }
    }
}
