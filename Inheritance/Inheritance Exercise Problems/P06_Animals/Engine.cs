using Animals.Cats;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class Engine
    {
        private const string END_OF_INPUT_COMMAND = "Beast!";
        private readonly List<Animal> animals;

        public Engine()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string type;

            while ((type = Console.ReadLine()) != END_OF_INPUT_COMMAND)
            {
                var commArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Animal animal;

                try
                {
                    animal = GetAnimal(type, commArgs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                this.animals.Add(animal);
            }

            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (Animal animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private Animal GetAnimal(string type, string[] commArgs)
        {
            var name = commArgs[0];
            var age = int.Parse(commArgs[1]);
            string gender = GetGender(commArgs);

            Animal animal = null;

            switch (type)
            {
                case "Dog":
                    animal = new Dog(name, age, gender);
                    break;

                case "Cat":
                    animal = new Cat(name, age, gender);
                    break;

                case "Frog":
                    animal = new Frog(name, age, gender);
                    break;

                case "Kitten":
                    animal = new Kitten(name, age);
                    break;

                case "Tomcat":
                    animal = new Tomcat(name, age);
                    break;

                default:
                    throw new ArgumentException("Invalid input!");
            }

            return animal;
        }

        private string GetGender(string[] commArgs)
        {
            string gender = null;

            if (commArgs.Length > 2)
            {
                gender = commArgs[2];
            }

            return gender;
        }
    }
}
