using System;

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
                Dough dough = new Dough("White", "Chewy", 100);
                Topping ketchup = new Topping("Meat", 500);

            }
            catch (Exception em)
            {
                Console.WriteLine(em.Message);
            }


            //   Engine engine = new Engine();
            //   engine.Run();
        }
    }
}
