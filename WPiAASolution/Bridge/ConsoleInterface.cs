using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class ConsoleInterface : ISysInterface
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Displaying console interface menu...");
        }
    }
}
