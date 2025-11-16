using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal abstract class WarriorBuilder
    {
        protected IWarrior Wojownik { get; set; }
        internal IWarrior GetWarrior()
        {
            return Wojownik;
        }
        internal abstract void CreateWarrior(string name);
        internal abstract void GetWeapon();
        internal abstract void Train();
    }
}
