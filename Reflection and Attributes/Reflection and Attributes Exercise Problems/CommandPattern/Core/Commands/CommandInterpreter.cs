using CommandPattern.Core.Contracts;
using System.Linq;

namespace CommandPattern.Core.Commands
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            var strArr = args
                .Split()
                .ToArray();



            return null;
        }
    }
}
