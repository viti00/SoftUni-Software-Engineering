using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandFactory : ICommandFactory
    {
        private const string commandSufix = "Command";
        public ICommand CreateCommand(string commandType)
        {
            var type = Assembly.GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{commandType}{commandSufix}");
            if (type == null)
            {
                throw new ArgumentException($"{commandType} is invalid command type.");
            }

            ICommand instace = (ICommand)Activator.CreateInstance(type);

            return instace;
        }
    }
}
