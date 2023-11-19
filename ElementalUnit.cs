using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    internal interface ElementalUnit
    {

        //Common properties of our composite pattern

        string Name { get; set; }
        decimal Price { get; set; }
        int LocationX { get; set; }
        int LocationY { get; set; }
        double Length { get; set; }
        double Width { get; set; }
        double Height { get; set; }

        ElementalUnit Parent { get; set; }

        //Common methods of our composite pattern
        void ChangeName(string newName);
        void ChangePrice(decimal newPrice);
        void Delete(ElementalUnit unit);
        void ChangeLocationX(int newLocation);
        void ChangeLocationY(int newLocation);
        void ChangeLength(double newLength);
        void ChangeWidth(double newWidth);
        void ChangeHeight(double newHeight);
    }
}
