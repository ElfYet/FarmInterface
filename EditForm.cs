using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FarmInterface
{
    public partial class EditForm : Form
    {
        private ElementalUnit unitToEdit;

        public EditForm(ElementalUnit unit)
        {
            InitializeComponent();
            unitToEdit = unit;
            LoadUnitData();
        }

        private void LoadUnitData()
        {
            nameText.Text = unitToEdit.Name;
            priceText.Text = unitToEdit.Price.ToString();
            xLocText.Text = unitToEdit.LocationX.ToString();
            yLocText.Text = unitToEdit.LocationY.ToString();
            lengthText.Text = unitToEdit.Length.ToString();
            widthText.Text = unitToEdit.Width.ToString();
            heightText.Text = unitToEdit.Height.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            unitToEdit.Name = nameText.Text;
            unitToEdit.Price = Decimal.Parse(priceText.Text);
            unitToEdit.LocationX = Int32.Parse(xLocText.Text);
            unitToEdit.LocationY = Int32.Parse(yLocText.Text);
            unitToEdit.Length = Double.Parse(lengthText.Text);
            unitToEdit.Width= Double.Parse(widthText.Text);
            unitToEdit.Height = Double.Parse(heightText.Text);

            this.Close();
        }
    }
}
