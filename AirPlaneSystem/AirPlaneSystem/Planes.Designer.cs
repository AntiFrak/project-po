namespace AirPlaneSystem
{
    partial class Planes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planes));
            this.RemovePlane = new System.Windows.Forms.Button();
            this.AddPlane = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxDistans = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.NamePlane = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ListBox();
            this.Capacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TypePlane = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemovePlane
            // 
            this.RemovePlane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RemovePlane.Location = new System.Drawing.Point(469, 309);
            this.RemovePlane.Name = "RemovePlane";
            this.RemovePlane.Size = new System.Drawing.Size(126, 35);
            this.RemovePlane.TabIndex = 17;
            this.RemovePlane.Text = "Remove";
            this.RemovePlane.UseVisualStyleBackColor = false;
            this.RemovePlane.Click += new System.EventHandler(this.RemovePlane_Click);
            // 
            // AddPlane
            // 
            this.AddPlane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddPlane.Location = new System.Drawing.Point(469, 258);
            this.AddPlane.Name = "AddPlane";
            this.AddPlane.Size = new System.Drawing.Size(126, 35);
            this.AddPlane.TabIndex = 16;
            this.AddPlane.Text = "Add ";
            this.AddPlane.UseVisualStyleBackColor = false;
            this.AddPlane.Click += new System.EventHandler(this.AddPlane_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Max Distans";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // MaxDistans
            // 
            this.MaxDistans.Location = new System.Drawing.Point(222, 271);
            this.MaxDistans.Name = "MaxDistans";
            this.MaxDistans.ReadOnly = true;
            this.MaxDistans.Size = new System.Drawing.Size(98, 22);
            this.MaxDistans.TabIndex = 12;
            this.MaxDistans.TextChanged += new System.EventHandler(this.MaxDistans_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(176, 271);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(40, 22);
            this.ID.TabIndex = 11;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // NamePlane
            // 
            this.NamePlane.Location = new System.Drawing.Point(38, 271);
            this.NamePlane.Name = "NamePlane";
            this.NamePlane.Size = new System.Drawing.Size(132, 22);
            this.NamePlane.TabIndex = 10;
            this.NamePlane.TextChanged += new System.EventHandler(this.NamePlane_TextChanged);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 16;
            this.list.Location = new System.Drawing.Point(38, 8);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(132, 212);
            this.list.TabIndex = 9;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // Capacity
            // 
            this.Capacity.Location = new System.Drawing.Point(326, 271);
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Size = new System.Drawing.Size(98, 22);
            this.Capacity.TabIndex = 18;
            this.Capacity.TextChanged += new System.EventHandler(this.Capacity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Capacity";
            // 
            // TypePlane
            // 
            this.TypePlane.FormattingEnabled = true;
            this.TypePlane.Items.AddRange(new object[] {
            "Big plane",
            "Medium plane",
            "Small plane"});
            this.TypePlane.Location = new System.Drawing.Point(38, 316);
            this.TypePlane.Name = "TypePlane";
            this.TypePlane.Size = new System.Drawing.Size(121, 24);
            this.TypePlane.TabIndex = 20;
            this.TypePlane.SelectedIndexChanged += new System.EventHandler(this.TypePlane_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Type of plane";
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TypePlane);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.RemovePlane);
            this.Controls.Add(this.AddPlane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxDistans);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.NamePlane);
            this.Controls.Add(this.list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Planes";
            this.Text = "Planes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemovePlane;
        private System.Windows.Forms.Button AddPlane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxDistans;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox NamePlane;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.TextBox Capacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypePlane;
        private System.Windows.Forms.Label label5;
    }
}