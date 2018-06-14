namespace AirPlaneSystem
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.NamePerson = new System.Windows.Forms.TextBox();
            this.AddPerson = new System.Windows.Forms.Button();
            this.list1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PESEL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameAgency = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RemoveAgency = new System.Windows.Forms.Button();
            this.AddAgency = new System.Windows.Forms.Button();
            this.buyt = new System.Windows.Forms.Button();
            this.listf = new System.Windows.Forms.ComboBox();
            this.howmanyseats = new System.Windows.Forms.NumericUpDown();
            this.listView = new System.Windows.Forms.ListView();
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.To = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Back = new System.Windows.Forms.Button();
            this.seeMyTick = new System.Windows.Forms.Button();
            this.who = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.howmanyseats)).BeginInit();
            this.SuspendLayout();
            // 
            // NamePerson
            // 
            this.NamePerson.Location = new System.Drawing.Point(11, 210);
            this.NamePerson.Margin = new System.Windows.Forms.Padding(2);
            this.NamePerson.Name = "NamePerson";
            this.NamePerson.Size = new System.Drawing.Size(74, 20);
            this.NamePerson.TabIndex = 29;
            this.NamePerson.TextChanged += new System.EventHandler(this.NamePerson_TextChanged);
            // 
            // AddPerson
            // 
            this.AddPerson.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddPerson.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddPerson.Location = new System.Drawing.Point(282, 206);
            this.AddPerson.Margin = new System.Windows.Forms.Padding(2);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(82, 24);
            this.AddPerson.TabIndex = 27;
            this.AddPerson.Text = "Add Person";
            this.AddPerson.UseVisualStyleBackColor = false;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(24, 11);
            this.list1.Margin = new System.Windows.Forms.Padding(2);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(261, 134);
            this.list1.TabIndex = 20;
            this.list1.SelectedIndexChanged += new System.EventHandler(this.list1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(103, 210);
            this.Surname.Margin = new System.Windows.Forms.Padding(2);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(74, 20);
            this.Surname.TabIndex = 35;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "PESEL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PESEL
            // 
            this.PESEL.Location = new System.Drawing.Point(194, 210);
            this.PESEL.Margin = new System.Windows.Forms.Padding(2);
            this.PESEL.Name = "PESEL";
            this.PESEL.Size = new System.Drawing.Size(74, 20);
            this.PESEL.TabIndex = 38;
            this.PESEL.TextChanged += new System.EventHandler(this.PESEL_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NameAgency
            // 
            this.NameAgency.Location = new System.Drawing.Point(11, 262);
            this.NameAgency.Margin = new System.Windows.Forms.Padding(2);
            this.NameAgency.Name = "NameAgency";
            this.NameAgency.Size = new System.Drawing.Size(74, 20);
            this.NameAgency.TabIndex = 39;
            this.NameAgency.TextChanged += new System.EventHandler(this.NameAgency_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(102, 262);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(153, 20);
            this.ID.TabIndex = 41;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "ID";
            // 
            // RemoveAgency
            // 
            this.RemoveAgency.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RemoveAgency.Location = new System.Drawing.Point(387, 231);
            this.RemoveAgency.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveAgency.Name = "RemoveAgency";
            this.RemoveAgency.Size = new System.Drawing.Size(76, 24);
            this.RemoveAgency.TabIndex = 44;
            this.RemoveAgency.Text = "Remove Agency";
            this.RemoveAgency.UseVisualStyleBackColor = false;
            this.RemoveAgency.Click += new System.EventHandler(this.RemoveAgency_Click);
            // 
            // AddAgency
            // 
            this.AddAgency.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddAgency.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddAgency.Location = new System.Drawing.Point(282, 258);
            this.AddAgency.Margin = new System.Windows.Forms.Padding(2);
            this.AddAgency.Name = "AddAgency";
            this.AddAgency.Size = new System.Drawing.Size(82, 24);
            this.AddAgency.TabIndex = 43;
            this.AddAgency.Text = "Add Agency";
            this.AddAgency.UseVisualStyleBackColor = false;
            this.AddAgency.Click += new System.EventHandler(this.AddAgency_Click);
            // 
            // buyt
            // 
            this.buyt.Enabled = false;
            this.buyt.Location = new System.Drawing.Point(338, 83);
            this.buyt.Name = "buyt";
            this.buyt.Size = new System.Drawing.Size(75, 23);
            this.buyt.TabIndex = 46;
            this.buyt.Text = "Buy tickets";
            this.buyt.UseVisualStyleBackColor = true;
            this.buyt.Click += new System.EventHandler(this.buyt_Click);
            // 
            // listf
            // 
            this.listf.Enabled = false;
            this.listf.FormattingEnabled = true;
            this.listf.Location = new System.Drawing.Point(290, 56);
            this.listf.Name = "listf";
            this.listf.Size = new System.Drawing.Size(273, 21);
            this.listf.TabIndex = 47;
            this.listf.Text = "Select flight";
            this.listf.SelectedIndexChanged += new System.EventHandler(this.listf_SelectedIndexChanged);
            // 
            // howmanyseats
            // 
            this.howmanyseats.Location = new System.Drawing.Point(569, 56);
            this.howmanyseats.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.howmanyseats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howmanyseats.Name = "howmanyseats";
            this.howmanyseats.Size = new System.Drawing.Size(66, 20);
            this.howmanyseats.TabIndex = 48;
            this.howmanyseats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howmanyseats.ValueChanged += new System.EventHandler(this.howmanyseats_ValueChanged);
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.who,
            this.From,
            this.To,
            this.Seats,
            this.Plane,
            this.DepDate,
            this.columnHeader1});
            this.listView.Location = new System.Drawing.Point(2, 8);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(703, 250);
            this.listView.TabIndex = 49;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Visible = false;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 79;
            // 
            // To
            // 
            this.To.Text = "To";
            this.To.Width = 77;
            // 
            // Seats
            // 
            this.Seats.Text = "Number of seats";
            this.Seats.Width = 110;
            // 
            // Plane
            // 
            this.Plane.Text = "Plane";
            this.Plane.Width = 118;
            // 
            // DepDate
            // 
            this.DepDate.Text = "Departure date";
            this.DepDate.Width = 115;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Arrival date";
            this.columnHeader1.Width = 129;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(578, 257);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(126, 28);
            this.Back.TabIndex = 50;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // seeMyTick
            // 
            this.seeMyTick.Location = new System.Drawing.Point(567, 185);
            this.seeMyTick.Name = "seeMyTick";
            this.seeMyTick.Size = new System.Drawing.Size(137, 23);
            this.seeMyTick.TabIndex = 51;
            this.seeMyTick.Text = "MY TICKETS";
            this.seeMyTick.UseVisualStyleBackColor = true;
            this.seeMyTick.Click += new System.EventHandler(this.seeMyTick_Click);
            // 
            // who
            // 
            this.who.Text = "Person/Firm";
            this.who.Width = 72;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 287);
            this.Controls.Add(this.seeMyTick);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.howmanyseats);
            this.Controls.Add(this.listf);
            this.Controls.Add(this.buyt);
            this.Controls.Add(this.RemoveAgency);
            this.Controls.Add(this.AddAgency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameAgency);
            this.Controls.Add(this.PESEL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamePerson);
            this.Controls.Add(this.AddPerson);
            this.Controls.Add(this.list1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.howmanyseats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NamePerson;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PESEL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameAgency;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RemoveAgency;
        private System.Windows.Forms.Button AddAgency;
        private System.Windows.Forms.Button buyt;
        private System.Windows.Forms.ComboBox listf;
        private System.Windows.Forms.NumericUpDown howmanyseats;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader To;
        private System.Windows.Forms.ColumnHeader Seats;
        private System.Windows.Forms.ColumnHeader Plane;
        private System.Windows.Forms.ColumnHeader DepDate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button seeMyTick;
        private System.Windows.Forms.ColumnHeader who;
    }
}