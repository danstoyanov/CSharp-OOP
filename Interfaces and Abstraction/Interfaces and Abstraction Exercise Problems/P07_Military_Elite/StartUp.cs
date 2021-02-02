using System;

using P07_Military_Elite.IO;
using P07_Military_Elite.Core;
using P07_Military_Elite.Core.IO.Contracts;

namespace P07_Military_Elite
{
    public class Program
    {
        static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            Engine engine = new Engine();
            engine.Run();
        }
    }
}
