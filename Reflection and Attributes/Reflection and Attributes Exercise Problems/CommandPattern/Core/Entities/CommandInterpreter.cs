using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Commands
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandPostFix = "Command";

        public string Read(string args)
        {
            string[] tokens = args
                .Split()
                .ToArray();


            string commandName = tokens[0];
            string commandTypeName = commandName + CommandPostFix;

            // *NEW = Reflection, how to get type !
            Type commandType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i.Name == nameof(ICommand))) // <= Get all interfaces only with ICommand !
                .FirstOrDefault(t => t.Name == commandTypeName);

            if (commandType == null)
            {
                throw new InvalidOperationException("Command type is invalid!");
            }

            // *NEW When commandType != null, we must create the object from current command type !
            ICommand command = Activator.CreateInstance(commandType) as ICommand;

            string[] readData = tokens.Skip(1).ToArray();
            string result = command.Execute(readData);

            return result;
        }
    }
}
