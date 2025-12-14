using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class WindowsSystem
    {
        public required ISysInterface sysInterface { get; set; }
        public void DisplayMenu()
        {
            if (sysInterface != null)
            {
                sysInterface.DisplayMenu();
            }
            else
            {
                Console.WriteLine("No system interface defined.");
            }
        }
    }
}
