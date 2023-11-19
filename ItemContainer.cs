using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    internal class ItemContainer : AbstractItem
    {
        public List<ElementalUnit> Children { get; private set; } = new List<ElementalUnit>();

        public void AddItem(ElementalUnit item) {
            Children.Add(item);         
        }

        //This method is unnecessary, since polymorphism allows each container to be treated like an item
        /*
                public void AddContainer(ItemContainer container)
                {
                    Children.Add(container);
                }
        */


    }
}
