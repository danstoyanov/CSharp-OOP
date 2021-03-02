using System;

namespace Demo_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[16];

            var data = new Database();

            ;

            data.Add(41);
            data.Add(32);

            data.Remove();
            data.Remove();

            var currentValue = data.Count;

        }
    }
}
