using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    internal class Item : AbstractItem
    {
        //All functions inherited from parent
        public Item(string name, decimal price, int locationX, int locationY, double length, double width, double height)
    : base(name, price, locationX, locationY, length, width, height) { }
    }
}
