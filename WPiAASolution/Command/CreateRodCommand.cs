using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class CreateRodCommand : ICommand
    {
        private readonly SantaClausFactory _factory;
        private readonly string _rod;

        public CreateRodCommand(SantaClausFactory factory, string rod)
        {
            _factory = factory;
            _rod = rod;
        }

        public void Execute()
        {
            _factory.CreateRod(_rod);
        }
    }
}
