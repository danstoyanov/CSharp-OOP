using System;
using System.Linq;

using P04_Pizza_Calories.Core;
using P04_Pizza_Calories.Ingredients;

namespace P04_Pizza_Calories
{
    public class StartUp
    {
        static void Main()
        {
            try
            {
                string[] pizzaInputArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string pizzaName = pizzaInputArgs[1];

                Pizza pizza = new Pizza(pizzaName);

                string[] doughInputArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string flourType = doughInputArgs[1];
                string bakingTechnique = doughInputArgs[2];
                double grams = double.Parse(doughInputArgs[3]);

                Dough dough = new Dough(flourType, bakingTechnique, grams);
                pizza.Dough = dough;

                string command;

                while ((command = Console.ReadLine()) != "END")
                {
                    string[] toppingArgs = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string toppingType = toppingArgs[1];
                    double toppingGrams = double.Parse(toppingArgs[2]);

                    Topping topping = new Topping(toppingType, toppingGrams);
                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
            }
            catch (Exception em)
            {
                Console.WriteLine(em.Message);
            }
        }
    }
}
