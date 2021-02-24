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

            ICommand command = null;

            if (commandName == "Hello")
            {
                command = new HelloCommand();
            }
            else if (commandName == "Exit")
            {
                command = new ExitCommand();
            }

            string[] readData = tokens.Skip(1).ToArray();
            string result = command.Execute(readData);
            
            return result;
        }
    }
}
