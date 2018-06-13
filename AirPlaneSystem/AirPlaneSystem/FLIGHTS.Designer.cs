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
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.To = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fTo = new System.Windows.Forms.TextBox();
            this.fFrom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.SelestPlane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.From,
            this.To,
            this.Seats,
            this.Plane,
            this.DepDate,
            this.columnHeader1});
            this.listView.Location = new System.Drawing.Point(23, 26);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(585, 182);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged_1);
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 31;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 64;
            // 
            // To
            // 
            this.To.Text = "To";
            this.To.Width = 67;
            // 
            // Seats
            // 
            this.Seats.Text = "Available seats";
            this.Seats.Width = 108;
            // 
            // Plane
            // 
            this.Plane.Text = "Plane";
            this.Plane.Width = 76;
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
            this.label1.Location = new System.Drawing.Point(144, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // fTo
            // 
            this.fTo.Location = new System.Drawing.Point(147, 270);
            this.fTo.Name = "fTo";
            this.fTo.Size = new System.Drawing.Size(100, 22);
            this.fTo.TabIndex = 3;
            this.fTo.TextChanged += new System.EventHandler(this.fTo_TextChanged);
            // 
            // fFrom
            // 
            this.fFrom.Location = new System.Drawing.Point(23, 270);
            this.fFrom.Name = "fFrom";
            this.fFrom.Size = new System.Drawing.Size(100, 22);
            this.fFrom.TabIndex = 4;
            this.fFrom.TextChanged += new System.EventHandler(this.fFrom_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(270, 239);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(38, 17);
            this.Date.TabIndex = 6;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // SelestPlane
            // 
            this.SelestPlane.Location = new System.Drawing.Point(493, 306);
            this.SelestPlane.Name = "SelestPlane";
            this.SelestPlane.Size = new System.Drawing.Size(115, 35);
            this.SelestPlane.TabIndex = 7;
            this.SelestPlane.Text = "Select a plane";
            this.SelestPlane.UseVisualStyleBackColor = true;
            this.SelestPlane.Click += new System.EventHandler(this.SelestPlane_Click);
            // 
            // FLIGHTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.SelestPlane);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.fFrom);
            this.Controls.Add(this.fTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLIGHTS";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.FLIGHTS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader To;
        private System.Windows.Forms.ColumnHeader Seats;
        private System.Windows.Forms.ColumnHeader Plane;
        private System.Windows.Forms.ColumnHeader DepDate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fTo;
        private System.Windows.Forms.TextBox fFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button SelestPlane;
    }
}