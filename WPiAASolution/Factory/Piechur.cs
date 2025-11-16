using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Piechur : Wojownik
    {
        public Piechur(string name)
        {
            this.name = name;
            weapon = "miecz";
        }
    }
}
