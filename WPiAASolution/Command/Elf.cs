using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Elf
    {
        private readonly List<ICommand> _commands = new();
        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var com in _commands)
            {
                com.Execute();
            }
        }
    }
}
