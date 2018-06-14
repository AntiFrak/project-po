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
            try { 
                InitializeComponent();
                comp.AddAirplane("Boing", 747, 0);
                comp.AddAirplane("Boing", 737, 1);
                comp.AddAirports("Dresden", 1d, 1d);
                comp.AddAirports("Warszawa", 499d, 499d);
                comp.AddAirports("Minsk", 130d, 240d);
                comp.AddFlightAgent("HotTour", "46521654");
                comp.AddPrivatePerson("Tim", "Hlebik", "1998051900000");
                comp.AddPrivatePerson("Lizaveta", "Smolina", "2000112600000");
                comp.AddPrivatePerson("Sid", "Lieniu", "00000000000");
                comp.AddAirports("Moskva", 463d, -241d);
                comp.AddAirplane("Little Bird", 666, 2);
                comp.AddFlight(comp.GetAirport(3), comp.GetAirport(2), comp.GetAirplane(2), DateTime.Now.AddDays(15));                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

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

        public void mainShow()
        {
            this.Show();
        }
    }
}
