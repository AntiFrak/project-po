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
    public partial class MAIN : Form
    {
        Company comp = new Company();
        
        public MAIN()
        {
            InitializeComponent();
          
        }

        public void MAIN_Load(object sender, EventArgs e)
        {
             
        }

        private void Airports_Click(object sender, EventArgs e)
        {
            AIRPORTS air = new AIRPORTS();
            this.Hide();
            air.Show();
           
        }

        private void Planes_Click(object sender, EventArgs e)
        {
            
            Planes pla = new Planes();
            this.Hide();
            pla.Show();
        }

        private void Flight_Click(object sender, EventArgs e)
        {
            FLIGHTS fli = new FLIGHTS();
            this.Hide();
            fli.Show();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            this.Hide();
            clients.Show();
        }
    }
}
