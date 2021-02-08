using System;
using System.Linq;
using System.Collections.Generic;

using P04_Wild_Farm.Models.Foods;
using P04_Wild_Farm.Models.Animals;
using P04_Wild_Farm.Models.Animals.Birds;
using P04_Wild_Farm.Models.Animals.Mammals;
using P04_Wild_Farm.Models.Animals.Mammals.Felines;

namespace P04_Wild_Farm.Core
{
    public class Engine
    {
        private readonly List<Animal> animals;
        private readonly List<Food> foods;

        public Engine()
        {
            animals = new List<Animal>();
            foods = new List<Food>();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] animalArgs = command
                .Split(" ")
                .ToArray();

                string animalType = animalArgs[0];
                string name = animalArgs[1];
                double weight = double.Parse(animalArgs[2]);

                // Animal Input !
                if (animalType == "Cat" || animalType == "Tiger")
                {
                    string region = animalArgs[3];
                    string breed = animalArgs[4];

                    if (animalType == "Cat")
                    {
                        Cat cat = new Cat(name, weight, region, breed);
                        this.animals.Add(cat);
                    }
                    else if (animalType == "Tiger")
                    {
                        Tiger tiger = new Tiger(name, weight, region, breed);
                        this.animals.Add(tiger);
                    }
                }
                else if (animalType == "Owl" || animalType == "Hen")
                {
                    double windSize = double.Parse(animalArgs[3]);

                    if (animalType == "Own")
                    {
                        Owl owl = new Owl(name, weight, windSize);
                        this.animals.Add(owl);
                    }
                    else if (animalType == "Hen")
                    {
                        Hen hen = new Hen(name, weight, windSize);
                        this.animals.Add(hen);
                    }
                }
                else if (animalType == "Dog" || animalType == "Mouse")
                {
                    string region = animalArgs[3];

                    if (animalType == "Dog")
                    {
                        Dog dog = new Dog(name, weight, region);
                        this.animals.Add(dog);
                    }
                    else if (animalType == "Mouse")
                    {
                        Mouse mouse = new Mouse(name, weight, region);
                        this.animals.Add(mouse);
                    }
                }

                string[] foodArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                string foodType = foodArgs[0];
                int quantity = int.Parse(foodArgs[1]);

                if (foodType == "Vegetable")
                {
                    Vegetable vegetable = new Vegetable(quantity);
                    this.foods.Add(vegetable);
                }
                else if (foodType == "Fruit")
                {
                    Fruit fruit = new Fruit(quantity);
                    this.foods.Add(fruit);
                }
                else if (foodType == "Meat")
                {
                    Meat meat = new Meat(quantity);
                    this.foods.Add(meat);
                }
                else if (foodType == "Seeds")
                {
                    Seeds seeds = new Seeds(quantity);
                    this.foods.Add(seeds);
                }
            }
        }

        private static void AddAnimals(string command)
        {
            string[] animalArgs = command
                .Split(" ")
                .ToArray();

            string animalType = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);

            // Animal Input !
            if (animalType == "Cat" || animalType == "Tiger")
            {
                string region = animalArgs[3];
                string breed = animalArgs[4];

                if (animalType == "Cat")
                {
                    Cat cat = new Cat(name, weight, region, breed);
                    dict.Add();
                }
                else if (animalType == "Tiger")
                {
                    Tiger tiger = new Tiger(name, weight, region, breed);
                }
            }
            else if (animalType == "Owl" || animalType == "Hen")
            {
                double windSize = double.Parse(animalArgs[3]);

                if (animalType == "Own")
                {
                    Owl own = new Owl(name, weight, windSize);
                }
                else if (animalType == "Hen")
                {
                    Hen hen = new Hen(name, weight, windSize);
                }
            }
            else if (animalType == "Dog" || animalType == "Mouse")
            {
                string region = animalArgs[3];

                if (animalType == "Dog")
                {
                    Dog dog = new Dog(name, weight, region);
                }
                else if (animalType == "Mouse")
                {
                    Mouse mouse = new Mouse(name, weight, region);
                }
            }
        }
    }
}
