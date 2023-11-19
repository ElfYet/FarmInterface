using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    internal class AbstractItem : ElementalUnit
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public void ChangeHeight(double newHeight)
        {
            Height = newHeight;
        }

        public void ChangeLength(double newLength)
        {
            Length = newLength;
        }

        public void ChangeLocationX(int newLocation)
        {
            LocationX = newLocation;
        }

        public void ChangeLocationY(int newLocation)
        {
            LocationY = newLocation;
        }

        public virtual void ChangeName(string newName)
        {
            Name = newName;
        }

        public virtual void ChangePrice(decimal newPrice)
        {
            Price = newPrice;
        }

        public void ChangeWidth(double newWidth)
        {
            Width = newWidth;
        }

        public virtual void Delete()
        {
            // Implementation for deleting the item
        }
    }
}
