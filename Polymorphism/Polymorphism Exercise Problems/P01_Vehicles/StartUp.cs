using System;

using P01_Vehicles.Core;
namespace P01_Vehicles
{
    public class StartUp
    {
        static void Main()
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
