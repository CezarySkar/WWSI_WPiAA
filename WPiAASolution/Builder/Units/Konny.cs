using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Units
{
    internal class Konny : IWarrior
    {
        public string Name { get; set; }
        public string Weapon { get; set; }

        public Konny(string name)
        {
            Name = name;
            Weapon = "";
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} szarzuje na wroga z {Weapon}");
        }
    }
}
