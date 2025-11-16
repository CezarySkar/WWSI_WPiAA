using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Konny : Wojownik
    {
        public Konny(string name) 
        {
            this.name = name;
            weapon = "lanca";
        }
    }
}
