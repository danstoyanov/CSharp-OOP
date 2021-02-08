using System;

using P03_Raiding.Core;
using P03_Raiding.Models;

namespace P03_Raiding
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
