using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    internal interface IWarrior
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public void Attack();
    }
}
