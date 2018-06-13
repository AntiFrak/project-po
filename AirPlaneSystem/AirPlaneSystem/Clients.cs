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
        private Company comp = new Company();
        internal Company Comp { get => comp; set => value = comp; }
        public Clients()
        {
            InitializeComponent();
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
            Comp.AddPrivatePerson(NamePerson.Text, Surname.Text, PESEL.Text);
            list1.Items.Add(Surname.Text);
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

        private void RemovePerson_Click(object sender, EventArgs e)
        {

        }

        private void AddAgency_Click(object sender, EventArgs e)
        {
            Comp.AddFlightAgent(NameAgency.Text, ID.Text);
            list2.Items.Add(NameAgency.Text);
        }

        private void RemoveAgency_Click(object sender, EventArgs e)
        {

        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
