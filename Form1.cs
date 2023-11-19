using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmInterface
{
    public partial class Form1 : Form
    {
        private ItemContainer rootContainer = new ItemContainer { Name = "root" };
        public Form1()
        {
            InitializeComponent();

            farmComponents.Text = "root";

        }


        private void PopulateTest()
        {
            var barn = new ItemContainer { Name = "Barn" };
            rootContainer.AddItem(barn);

            var livestockArea = new ItemContainer { Name = "Livestock-Area" };
            barn.AddItem(livestockArea);

            var cow = new Item { Name = "Cow" };
            livestockArea.AddItem(cow);

            var milkstorage = new Item { Name = "Milk Storage" };
            barn.AddItem(milkstorage);

            var storageBuilding = new ItemContainer { Name = "Storage Building" };
            rootContainer.AddItem(storageBuilding);

            var tractor = new Item { Name = "Tractor" };
            storageBuilding.AddItem(tractor);

            var tiller = new Item { Name = "Tiller" };
            storageBuilding.AddItem(tiller);

            var commandCenter = new ItemContainer { Name = "Command Center" };
            rootContainer.AddItem(commandCenter);

            var drone = new Item { Name = "Drone" };
            commandCenter.AddItem(drone);

            var soyCrop = new Item { Name = "Soy Crop" };
            rootContainer.AddItem(soyCrop);
        }

        private void populate_Click(object sender, EventArgs e)
        {
            farmComponents.Clear();
            Testing.PopulateBarnTest(rootContainer);                
            DisplayTest(rootContainer, 0, farmComponents);
        }

        private void DisplayTest(ElementalUnit unit, int level, TextBox textBox)
        {
            textBox.AppendText(Environment.NewLine + new string(' ', level * 2) + unit.Name);

            if (unit is ItemContainer container)
            {
                foreach (var child in container.Children)
                {
                    DisplayTest(child, level + 1, textBox);
                }
            }
        }
    }
}
