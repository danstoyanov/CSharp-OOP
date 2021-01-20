using System;

using P04_Pizza_Calories.Core;
using P04_Pizza_Calories.Ingredients;

namespace P04_Pizza_Calories
{
    public class StartUp
    {
        static void Main()
        {
            Dough dough = new Dough("White", "Chewy", 100);
            Console.WriteLine(dough.CaloriesPerGrams* 100);

        //   Engine engine = new Engine();
        //   engine.Run();
        }
    }
}
