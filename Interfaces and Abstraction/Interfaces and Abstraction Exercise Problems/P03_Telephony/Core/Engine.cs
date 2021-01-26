using System;
using System.Linq;

using Telephony.Core;

namespace P03_Telephony.Models
{
    public class Engine : IEngine
    {
        public Engine()
        {

        }

        public void Run()
        {
            int[] phoneNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[] webSites = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }
    }
}
