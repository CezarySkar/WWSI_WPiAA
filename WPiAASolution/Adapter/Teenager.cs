using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Teenager
    {
        public string Name { get; }
        public int Age { get; }

        public Teenager(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
