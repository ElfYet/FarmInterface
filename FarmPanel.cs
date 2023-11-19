using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmInterface
{
    public class FarmPanel : Panel
    {
        public ElementalUnit RootContainer { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawElement(RootContainer, e.Graphics);
        }

        private void DrawElement(ElementalUnit element, Graphics graphics)
        {
            if (element == null) return;

            // Draw each element as a rectangle
            int x = element.LocationX;
            int y = element.LocationY;
            int width = (int)element.Width;
            int length = (int)element.Length;

            Rectangle rect = new Rectangle(x, y, width, length);
            graphics.DrawRectangle(Pens.Black, rect);

            if (element is ItemContainer container)
            {
                foreach (var child in container.Children)
                {
                    DrawElement(child, graphics);
                }
            }
        }
    }
}
