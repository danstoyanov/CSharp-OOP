using System;
using System.Linq;

using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Commands
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args
                .Split()
                .ToArray();
            string commandName = tokens[0];

            string result = "";

            if (commandName == "Hello")
            {
                result = $"Hello, {tokens[1]}";
            }
            else if (commandName == "Exit")
            {
                Environment.Exit(0);
            }

            return result;
        }
    }
}
