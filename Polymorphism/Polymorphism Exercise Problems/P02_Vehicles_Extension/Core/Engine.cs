﻿using System;
using System.Linq;

using P02_Vehicles_Extension.Models;

namespace P02_Vehicles_Extension.Core
{
    public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            string[] carArgs = Console.ReadLine()
                .Split()
                .ToArray();
            string[] truckArgs = Console.ReadLine()
                .Split()
                .ToArray();

            string[] busArgs = Console.ReadLine()
                .Split()
                .ToArray();

            Car car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), double.Parse(carArgs[3]));
            Truck truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), double.Parse(truckArgs[3]));
            Bus bus = new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), double.Parse(busArgs[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commArgs = Console.ReadLine().Split(" ")
                    .ToArray();

                string command = commArgs[0] + " " + commArgs[1];
                double inputValue = double.Parse(commArgs[2]);

                try
                {
                    if (command == "Drive Car")
                    {
                        Console.WriteLine(car.Drive(inputValue));
                    }
                    else if (command == "Refuel Car")
                    {
                        car.Refuel(inputValue);
                    }
                    else if (command == "Drive Truck")
                    {
                        Console.WriteLine(truck.Drive(inputValue));
                    }
                    else if (command == "Refuel Truck")
                    {
                        truck.Refuel(inputValue);
                    }
                    else if (command == "Drive Bus")
                    {
                        Console.WriteLine(bus.Drive(inputValue));
                    }
                    else if (command == "DriveEmpty Bus")
                    {
                        Console.WriteLine(bus.DriveEmpty(inputValue));
                    }
                    else if (command == "Refuel Bus")
                    {
                        bus.Refuel(inputValue);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
