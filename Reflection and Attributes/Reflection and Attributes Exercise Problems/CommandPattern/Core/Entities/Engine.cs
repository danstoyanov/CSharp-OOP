﻿using System;
using System.Linq;

using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Entities
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                string result = this.commandInterpreter.Read(input);
                Console.WriteLine(result);
            }
        }
    }
}
