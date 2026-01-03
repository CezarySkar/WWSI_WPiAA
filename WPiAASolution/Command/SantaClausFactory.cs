using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class SantaClausFactory
    {
        private readonly List<string> _items = new();
        public IReadOnlyList<string> ProducedItems => _items;

        public void CreateToy(string toy)
        {
            Console.WriteLine($"Creating a '{toy}' toy...");
            _items.Add(toy);
        }

        public void CreateRod(string rod)
        {
            Console.WriteLine($"Creating a '{rod}' rod...");
            _items.Add(rod);
        }
    }
}
