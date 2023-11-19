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
        private ItemContainer rootContainer = new ItemContainer("root", 0.00m, 0, 0, 0, 0, 0);
        private FarmPanel farmPanel;



        public Form1()
        {
            InitializeComponent();

            //farmComponents.Text = "root";
            TreeNode rootNode = new TreeNode("root");
            treeView.Nodes.Add(rootNode);

            //Replaces the placeholder panel displayed in design with the custom farmPanel
            farmPanel = new FarmPanel
            {

                Size = placeholderPanel.Size, 
                Location = placeholderPanel.Location, 
                BorderStyle = BorderStyle.Fixed3D 
            };
            this.Controls.Remove(placeholderPanel);
            this.Controls.Add(farmPanel);

            farmPanel.RootContainer = rootContainer;
        }

        private void populate_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            Testing.PopulateBarnTest(rootContainer);
            PopulateTreeView(rootContainer, treeView.Nodes);
            farmPanel.Invalidate();
        }


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

                if (selectedUnit.Parent != null)
                {
                    selectedUnit.Delete(selectedUnit);
                }

                treeView.Nodes.Remove(treeView.SelectedNode);

                farmPanel.Invalidate();
            }

            treeView.Nodes.Clear();
            PopulateTreeView(rootContainer, treeView.Nodes);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                ElementalUnit selectedUnit = treeView.SelectedNode.Tag as ElementalUnit;
                EditForm editForm = new EditForm(selectedUnit);
                editForm.ShowDialog();

                // After editing, update the TreeView if necessary
                treeView.SelectedNode.Text = selectedUnit.Name;
            }
            farmPanel.Invalidate();
        }
    }
}
