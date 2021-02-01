using System;
using System.Linq;
using System.Collections.Generic;

using P06_Food_Shortage.Models;
using P06_Food_Shortage.Contracts;

namespace P06_Food_Shortage.Core
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
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] args = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                if (args.Length == 4)
                {
                    string name = args[0];
                    string age = args[1];
                    string id = args[2];
                    string birthdate = args[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    this.inhabitans.Add(citizen);
                }
                else if (args.Length == 3)
                {
                    string name = args[0];
                    string age = args[1];
                    string group = args[2];

                    Rebel rebel = new Rebel(name, age, group);
                    this.inhabitans.Add(rebel);
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {

            }
        }
    }
}
