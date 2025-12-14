using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Dish : IMenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Dish(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + $"{Name}: ${Price}");
        }
    }
}
