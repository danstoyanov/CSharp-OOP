using System;
using System.Linq;
using P04_Wild_Farm_Exercise_Lecture.Core.Contracts;

namespace P04_Wild_Farm_Exercise_Lecture.Core
{
    public class Engine : IEngine
    {
        public Engine()
        {

        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] animalArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string[]

                string type = animalArgs[0];
                string name = animalArgs[1];
                double weight = double.Parse(animalArgs[2]);

                if (type == "Hen" || type == "Owl")
                {
                    double wingSize = double.Parse(animalArgs[3]);
                }


            }
        }
    }
}
