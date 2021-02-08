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

        public Engine()
        {
            animals = new List<Animal>();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                try
                {
                    var animal = new Animal();
                    var food = new Food();

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
                            animal = cat;
                        }
                        else if (animalType == "Tiger")
                        {
                            Tiger tiger = new Tiger(name, weight, region, breed);
                            animal = tiger;
                        }
                    }
                    else if (animalType == "Owl" || animalType == "Hen")
                    {
                        double windSize = double.Parse(animalArgs[3]);

                        if (animalType == "Owl")
                        {
                            Owl owl = new Owl(name, weight, windSize);
                            animal = owl;
                        }
                        else if (animalType == "Hen")
                        {
                            Hen hen = new Hen(name, weight, windSize);
                            animal = hen;
                        }
                    }
                    else if (animalType == "Dog" || animalType == "Mouse")
                    {
                        string region = animalArgs[3];

                        if (animalType == "Dog")
                        {
                            Dog dog = new Dog(name, weight, region);
                            animal = dog;
                        }
                        else if (animalType == "Mouse")
                        {
                            Mouse mouse = new Mouse(name, weight, region);
                            animal = mouse;
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
                        food = vegetable;
                    }
                    else if (foodType == "Fruit")
                    {
                        Fruit fruit = new Fruit(quantity);
                        food = fruit;
                    }
                    else if (foodType == "Meat")
                    {
                        Meat meat = new Meat(quantity);
                        food = meat;
                    }
                    else if (foodType == "Seeds")
                    {
                        Seeds seeds = new Seeds(quantity);
                        food = seeds;
                    }

                    animals.Add(animal);
                    Console.WriteLine(animal.ProducingSound());
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            foreach (var animal in this.animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
