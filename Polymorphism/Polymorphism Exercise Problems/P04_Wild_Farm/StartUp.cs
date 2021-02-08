using System;

using P04_Wild_Farm.Core;
using P04_Wild_Farm.Models.Animals.Mammals.Felines;
using P04_Wild_Farm.Models.Foods;

namespace P04_Wild_Farm
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
