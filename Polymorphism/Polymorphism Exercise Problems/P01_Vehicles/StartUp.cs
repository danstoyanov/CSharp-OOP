using System;

using P01_Vehicles.Core;

namespace P01_Vehicles
{
    public class StartUp
    {
        static void Main()
        {
            var command = "Start";
            PrintTest(command);
            Engine engine = new Engine();
            engine.Run();
        }

        private static void PrintTest(string comm)
        {
            Console.WriteLine(comm);
        }
    }
}
