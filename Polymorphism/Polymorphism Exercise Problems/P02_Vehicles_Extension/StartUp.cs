using System;

using P02_Vehicles_Extension.Core;
using P02_Vehicles_Extension.Models;

namespace P02_Vehicles_Extension
{
    public class StartUp
    {
        static void Main()
        {
            //    Engine engine = new Engine();
            //    engine.Run();

            var bus = new Bus(40, 0.3, 150);

            Console.WriteLine(bus.Drive(10));
        }
    }
}
