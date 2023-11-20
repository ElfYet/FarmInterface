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
        public void DisplayLabels()
        {
            DisplayElementLabel(RootContainer);
        }

        private void DisplayElementLabel(ElementalUnit element)
        {
            if (element == null) return;

            Label nameLabel = new Label
            {
                Text = element.Name,
                AutoSize = true, // Automatically size the label to fit the text
                Font = new Font("Arial", 8, FontStyle.Regular),
                Location = new Point(element.LocationX, element.LocationY)
            };

            this.Controls.Add(nameLabel); // Add the label to the FarmPanel

            if (element is ItemContainer container)
            {
                foreach (var child in container.Children)
                {
                    DisplayElementLabel(child);
                }
            }
        }
    }
}
