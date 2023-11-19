﻿using System;
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

            //farmComponents.Text = "root";
            TreeNode rootNode = new TreeNode("root");
            treeView.Nodes.Add(rootNode);

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
            //farmComponents.Clear();
            treeView.Nodes.Clear();
            PopulateTest();
            PopulateTreeView(rootContainer, treeView.Nodes);

            //Testing.PopulateBarnTest(rootContainer);                
            //DisplayTest(rootContainer, 0, farmComponents);
        }

/*        private void DisplayTest(ElementalUnit unit, int level, TextBox textBox)
        {
            textBox.AppendText(Environment.NewLine + new string(' ', level * 2) + unit.Name);

            if (unit is ItemContainer container)
            {
                foreach (var child in container.Children)
                {
                    DisplayTest(child, level + 1, textBox);
                }
            }
        }*/

        private void PopulateTreeView(ElementalUnit unit, TreeNodeCollection nodes)
        {
            TreeNode newNode = nodes.Add(unit.Name);
            newNode.Tag = unit; // Storing the ElementalUnit object in the Tag property

            if (unit is ItemContainer container)
            {
                foreach (var child in container.Children)
                {
                    PopulateTreeView(child, newNode.Nodes);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //what treeView
            if (treeView.SelectedNode != null)
            {
                ElementalUnit selectedUnit = treeView.SelectedNode.Tag as ElementalUnit;
                // Implement the logic to delete the selectedUnit from its parent
                // Update the TreeView
                treeView.Nodes.Remove(treeView.SelectedNode);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                ElementalUnit selectedUnit = treeView.SelectedNode.Tag as ElementalUnit;
/*                EditForm editForm = new EditForm(selectedUnit);
                editForm.ShowDialog();*/

                // After editing, update the TreeView if necessary
                treeView.SelectedNode.Text = selectedUnit.Name;
            }
        }
    }
}