namespace AirPlaneSystem
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.Airports = new System.Windows.Forms.Button();
            this.Planes = new System.Windows.Forms.Button();
            this.Flight = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Button();
            this.Saver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Airports
            // 
            this.Airports.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Airports.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Airports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Airports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Airports.Location = new System.Drawing.Point(52, 33);
            this.Airports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Airports.Name = "Airports";
            this.Airports.Size = new System.Drawing.Size(118, 37);
            this.Airports.TabIndex = 0;
            this.Airports.Text = "Airports";
            this.Airports.UseVisualStyleBackColor = false;
            this.Airports.Click += new System.EventHandler(this.Airports_Click);
            // 
            // Planes
            // 
            this.Planes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Planes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Planes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Planes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Planes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Planes.Location = new System.Drawing.Point(284, 33);
            this.Planes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Planes.Name = "Planes";
            this.Planes.Size = new System.Drawing.Size(118, 37);
            this.Planes.TabIndex = 1;
            this.Planes.Text = "Planes";
            this.Planes.UseVisualStyleBackColor = false;
            this.Planes.Click += new System.EventHandler(this.Planes_Click);
            // 
            // Flight
            // 
            this.Flight.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Flight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Flight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Flight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Flight.Location = new System.Drawing.Point(52, 104);
            this.Flight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Flight.Name = "Flight";
            this.Flight.Size = new System.Drawing.Size(118, 37);
            this.Flight.TabIndex = 2;
            this.Flight.Text = "Flights";
            this.Flight.UseVisualStyleBackColor = false;
            this.Flight.Click += new System.EventHandler(this.Flight_Click);
            // 
            // Clients
            // 
            this.Clients.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Clients.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clients.Location = new System.Drawing.Point(284, 104);
            this.Clients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(118, 37);
            this.Clients.TabIndex = 3;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = false;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // Saver
            // 
            this.Saver.Location = new System.Drawing.Point(160, 227);
            this.Saver.Name = "Saver";
            this.Saver.Size = new System.Drawing.Size(127, 48);
            this.Saver.TabIndex = 4;
            this.Saver.Text = "Save to drive";
            this.Saver.UseVisualStyleBackColor = true;
            this.Saver.Click += new System.EventHandler(this.Saver_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 287);
            this.Controls.Add(this.Saver);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.Flight);
            this.Controls.Add(this.Planes);
            this.Controls.Add(this.Airports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MAIN";
            this.Text = "Reservation system";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Airports;
        private System.Windows.Forms.Button Planes;
        private System.Windows.Forms.Button Flight;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Saver;
    }
}