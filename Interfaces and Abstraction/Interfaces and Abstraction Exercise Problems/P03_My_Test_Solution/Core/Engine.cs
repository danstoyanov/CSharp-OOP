using System;
using System.Linq;

using P03_Telephony.Models;
using P03_Telephony.Contracts;
using P03_Telephony.Exceptions;

namespace P03_Telephony.Core
{
    public class Engine : IEngine
    {
        private StationaryPhone stationaryPhone;
        private SmartPhone smartphone;

        public Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartphone = new SmartPhone();
        }

        public void Run()
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split()
                .ToArray();

            string[] webs = Console.ReadLine()
                .Split()
                .ToArray();

            CallNumbers(phoneNumbers);
            BrowseSites(webs);
        }

        private void BrowseSites(string[] webs)
        {
            foreach (var web in webs)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(web));
                }
                catch (InvalidURLException msg)
                {
                    Console.WriteLine(msg.Message);
                }
            }
        }

        private void CallNumbers(string[] phoneNumbers)
        {
            foreach (var number in phoneNumbers)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(number));
                    }
                    else if (number.Length == 10)
                    {
                        Console.WriteLine(smartphone.Call(number));
                    }
                    else
                    {
                        throw new InvalidNumberException();
                    }
                }
                catch (InvalidNumberException msg)
                {
                    Console.WriteLine(msg.Message);
                }
            }
        }
    }
}
