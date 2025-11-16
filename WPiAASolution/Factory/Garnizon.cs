using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Garnizon
    {
        public Wojownik Train(string unitType, string name)
        {
            return unitType.ToLower() switch
            {
                "piechur" => new Piechur(name),
                "konny" => new Konny(name),
                "strzelec" => new Strzelec(name),
                _ => throw new ArgumentException("Nieznany typ jednostki"),
            };
        }
    }
}
