using System;

using P02_Vehicles_Extension.Core;

namespace P02_Vehicles_Extension
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
