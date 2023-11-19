namespace FarmInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.farmComponents = new System.Windows.Forms.TextBox();
            this.populate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Farm Items";
            // 
            // farmComponents
            // 
            this.farmComponents.Location = new System.Drawing.Point(262, 78);
            this.farmComponents.Margin = new System.Windows.Forms.Padding(4);
            this.farmComponents.Multiline = true;
            this.farmComponents.Name = "farmComponents";
            this.farmComponents.Size = new System.Drawing.Size(164, 416);
            this.farmComponents.TabIndex = 7;
            // 
            // populate
            // 
            this.populate.Location = new System.Drawing.Point(473, 188);
            this.populate.Name = "populate";
            this.populate.Size = new System.Drawing.Size(114, 32);
            this.populate.TabIndex = 9;
            this.populate.Text = "Populate Test";
            this.populate.UseVisualStyleBackColor = true;
            this.populate.Click += new System.EventHandler(this.populate_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(688, 545);
            this.Controls.Add(this.populate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.farmComponents);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox farmComponents;
        private System.Windows.Forms.Button populate;
    }
}

