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
    public partial class Planes : Form
    {
        private Company comp = new Company();
        internal Company Comp { get => comp; set => value = comp; }
        public Planes()
        {
            InitializeComponent();
        }

        private void NamePlane_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxDistans_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypePlane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPlane_Click(object sender, EventArgs e)
        {

        }

        private void RemovePlane_Click(object sender, EventArgs e)
        {

        }
    }
}
