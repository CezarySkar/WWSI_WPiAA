using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Strzelec : Wojownik
    {
        public Strzelec(string name)
        {
            this.name = name;
            weapon = "łuk";
        }
    }
}
