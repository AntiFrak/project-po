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
    public partial class Clients : Form
    {
        private Company comp;
        public Clients()
        {
            InitializeComponent();
        }

        public void setCompany(Company c)
        {
            comp = c;
        }

        private void NamePerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            comp.AddPrivatePerson(NamePerson.Text, Surname.Text, PESEL.Text);
            list1.Items.Add(NamePerson.Text + " " + Surname.Text);
        }

        private void Clients_Load(object sender, EventArgs e)
        {
           
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void PESEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameAgency_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAgency_Click(object sender, EventArgs e)
        {
            comp.AddFlightAgent(NameAgency.Text, ID.Text);
            list1.Items.Add(NameAgency.Text);
        }

        private void RemoveAgency_Click(object sender, EventArgs e)
        {
            comp.RemoveClient(list1.SelectedIndex);
            list1.Items.Remove(list1.SelectedIndex);
        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
