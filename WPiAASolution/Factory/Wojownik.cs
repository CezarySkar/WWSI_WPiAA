using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Wojownik
    {
        public string? name;
        public string? weapon;

        public void Attack()
        {
            Console.WriteLine($"{name} zaatakował wroga przy pomocy {weapon}");
        }
    }
}
