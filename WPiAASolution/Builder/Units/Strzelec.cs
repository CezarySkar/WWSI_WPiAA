using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Units
{
    internal class Strzelec : IWarrior
    {
        public string Name { get; set; }
        public string Weapon { get; set; }

        public Strzelec(string name)
        {
            Name = name;
            Weapon = "";
        }
        public void Attack()
        {
            Console.WriteLine($"{Name} strzela do wroga z {Weapon}");
        }
    }
}
