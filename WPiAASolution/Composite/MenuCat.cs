using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class MenuCat : IMenuItem
    {
        private string _name;
        private List<IMenuItem> _items = new List<IMenuItem>();

        public MenuCat(string name)
        {
            _name = name;
        }

        public void addItem(IMenuItem item)
        {
            _items.Add(item);
        }

        public void removeItem(IMenuItem item)
        {
            _items.Remove(item);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);
            foreach (var item in _items)
            {
                item.Display(depth + 2);
            }
        }
    }
}
