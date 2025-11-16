using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Units
{
    internal class Wojownik
    {
        public string? Name;
        public string? Weapon;

        public void Attack()
        {
            Console.WriteLine($"{Name} zaatakował wroga przy pomocy {Weapon}");
        }
    }
}
