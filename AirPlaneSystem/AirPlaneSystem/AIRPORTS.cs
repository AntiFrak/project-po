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
    public partial class AIRPORTS : Form
    {
        Company comp;
        public AIRPORTS()
        {
            InitializeComponent();
        }

        public void setCompany(Company c)
        {
            try
            {
                comp = c;
                foreach (Airport a in comp.GetAllAirports())
                {
                    list.Items.Add(a.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {
            comp.RemoveAirports(list.SelectedIndex);
            list.Items.Remove(list.SelectedItem);
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                comp.AddAirports(name.Text, Convert.ToDouble(coordX.Text), Convert.ToDouble(coordY.Text));
                list.Items.Add(name.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void AIRPORTS_Load(object sender, EventArgs e)
        {

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
