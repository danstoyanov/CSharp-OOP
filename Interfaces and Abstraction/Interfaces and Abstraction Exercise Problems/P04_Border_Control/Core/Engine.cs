using System;
using System.Collections.Generic;
using System.Linq;

using P04_Border_Control.Contracts;
using P04_Border_Control.Models;

namespace P04_Border_Control.Core
{
    public class Engine : IEngine
    {
        private readonly List<IInhabitants> inhabitans;

        public Engine()
        {
            this.inhabitans = new List<IInhabitants>();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command
                    .Split(" ")
                    .ToArray();

                if (args.Length == 3)
                {
                    string name = args[0];
                    string age = args[1];
                    string id = args[2];

                    Citizen citizen = new Citizen(name, age, id);
                    this.inhabitans.Add(citizen);
                }
                else
                {
                    string model = args[0];
                    string id = args[1];

                    Robot robot = new Robot(model, id);
                    this.inhabitans.Add(robot);
                }
            }

            string lastDigits = Console.ReadLine();

            foreach (var inhabitan in this.inhabitans)
            {
                if (inhabitan.Id.EndsWith(lastDigits))
                {
                    Console.WriteLine(inhabitan.Id);
                }
            }
        }
    }
}
