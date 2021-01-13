using System;

namespace _04_Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int counter = 0; counter <= n; counter += 2)
            {
                Console.WriteLine(Math.Pow(2, counter));
            }
        }
    }
}
