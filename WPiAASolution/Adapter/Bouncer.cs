using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Bouncer
    {
        public void CheckId(Adult person)
        {
            Console.WriteLine($"Bramkarz sprawdza osobę: {person.GetName()}");

            if (person.IsAdult())
            {
                Console.WriteLine("Bramkarz: Wszystko gra. Wchodzisz.");
            }
            else
            {
                Console.WriteLine("Bramkarz: Przykro mi, to klub tylko dla dorosłych. Wypad.");
            }
        }
    }
}
