using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPlaneSystem
{
     partial class MAIN : Form
    {
        Company comp = new Company();

        public MAIN()
        {
            InitializeComponent();
            comp.AddAirplane("Boing", 747, 0);
            comp.AddAirports("Dresden", 1d, 1d);
        }

        public void MAIN_Load(object sender, EventArgs e)
        {
             
        }

        internal void Airports_Click(object sender, EventArgs e)
        {
            AIRPORTS air = new AIRPORTS();
            air.setCompany(comp);
            //this.Hide();
            air.Show();
           
        }

        private void Planes_Click(object sender, EventArgs e)
        {
            
            Planes pla = new Planes();
            pla.setCompany(comp);
            //this.Hide();
            pla.Show();
        }

        private void Flight_Click(object sender, EventArgs e)
        {
            FLIGHTS fli = new FLIGHTS();
            fli.setCompany(comp);
            //this.Hide();
            fli.Show();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.setCompany(comp);
            //this.Hide();
            clients.Show();
        }
    }
}
