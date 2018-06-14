namespace AirPlaneSystem
{
    partial class FLIGHTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLIGHTS));
            this.listView = new System.Windows.Forms.ListView();
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.To = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.SelestPlane = new System.Windows.Forms.Button();
            this.fromList = new System.Windows.Forms.ComboBox();
            this.toList = new System.Windows.Forms.ComboBox();
            this.listPlanes = new System.Windows.Forms.ComboBox();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.From,
            this.To,
            this.Seats,
            this.Plane,
            this.DepDate,
            this.columnHeader1});
            this.listView.Location = new System.Drawing.Point(18, 20);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(607, 149);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged_1);
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
            this.Seats.Text = "Available seats";
            this.Seats.Width = 83;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 218);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(202, 194);
            this.Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 6;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // SelestPlane
            // 
            this.SelestPlane.Enabled = false;
            this.SelestPlane.Location = new System.Drawing.Point(370, 216);
            this.SelestPlane.Margin = new System.Windows.Forms.Padding(2);
            this.SelestPlane.Name = "SelestPlane";
            this.SelestPlane.Size = new System.Drawing.Size(86, 23);
            this.SelestPlane.TabIndex = 7;
            this.SelestPlane.Text = "Select a plane";
            this.SelestPlane.UseVisualStyleBackColor = true;
            this.SelestPlane.Click += new System.EventHandler(this.SelestPlane_Click);
            // 
            // fromList
            // 
            this.fromList.FormattingEnabled = true;
            this.fromList.Location = new System.Drawing.Point(6, 217);
            this.fromList.Name = "fromList";
            this.fromList.Size = new System.Drawing.Size(80, 21);
            this.fromList.TabIndex = 8;
            this.fromList.SelectedIndexChanged += new System.EventHandler(this.fromList_SelectedIndexChanged);
            // 
            // toList
            // 
            this.toList.FormattingEnabled = true;
            this.toList.Location = new System.Drawing.Point(111, 218);
            this.toList.Name = "toList";
            this.toList.Size = new System.Drawing.Size(80, 21);
            this.toList.TabIndex = 9;
            this.toList.SelectedIndexChanged += new System.EventHandler(this.toList_SelectedIndexChanged);
            // 
            // listPlanes
            // 
            this.listPlanes.Enabled = false;
            this.listPlanes.FormattingEnabled = true;
            this.listPlanes.Location = new System.Drawing.Point(476, 216);
            this.listPlanes.Name = "listPlanes";
            this.listPlanes.Size = new System.Drawing.Size(103, 21);
            this.listPlanes.TabIndex = 10;
            this.listPlanes.Text = "Planes:";
            this.listPlanes.SelectedIndexChanged += new System.EventHandler(this.listPlanes_SelectedIndexChanged);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(504, 252);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 11;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // FLIGHTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 287);
            this.Controls.Add(this.create);
            this.Controls.Add(this.listPlanes);
            this.Controls.Add(this.toList);
            this.Controls.Add(this.fromList);
            this.Controls.Add(this.SelestPlane);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FLIGHTS";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.FLIGHTS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader To;
        private System.Windows.Forms.ColumnHeader Seats;
        private System.Windows.Forms.ColumnHeader Plane;
        private System.Windows.Forms.ColumnHeader DepDate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button SelestPlane;
        private System.Windows.Forms.ComboBox fromList;
        private System.Windows.Forms.ComboBox toList;
        private System.Windows.Forms.ComboBox listPlanes;
        private System.Windows.Forms.Button create;
    }
}