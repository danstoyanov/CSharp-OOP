using System;

using P07_Military_Elite.Core.IO.Contracts;

namespace P07_Military_Elite.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
