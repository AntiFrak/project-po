using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

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
            foreach (Flight f in comp.GetAllFlights())
            {
                listf.Items.Add(f.From.Name + " - " + f.To.Name + " (" + f.Date.ToString() + " )");
            }
            //var x = comp.GetAllClients();
            //var t = x.GetType();
            //foreach (Client cl in comp.GetAllClients())
            //    foreach (var a in t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
            //        list1.Items.Add(a.GetValue(x));
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
            try {
                if (NamePerson.Text == "" || Surname.Text == "" || PESEL.Text == "")
                    throw new Exception("Fields are empty!");
                comp.AddPrivatePerson(NamePerson.Text, Surname.Text, PESEL.Text);
            list1.Items.Add(NamePerson.Text + " " + Surname.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
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
            try {
                if (NameAgency.Text == "" || ID.Text == "")
                    throw new Exception("Fields are empty!");
            comp.AddFlightAgent(NameAgency.Text, ID.Text);
            list1.Items.Add(NameAgency.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void RemoveAgency_Click(object sender, EventArgs e)
        {
            try { 
            comp.RemoveClient(list1.SelectedIndex);
            list1.Items.Remove(list1.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listf.Enabled = true;
        }

        private void listf_SelectedIndexChanged(object sender, EventArgs e)
        {
            howmanyseats.Maximum = comp.GetFlight(listf.SelectedIndex).Ap.Capacity;
        }

        private void buyt_Click(object sender, EventArgs e)
        {
            try
            {
                comp.GetClient(list1.SelectedIndex).BuyTicket(comp.GetFlight(listf.SelectedIndex), Convert.ToInt32(howmanyseats.Value));
                buyt.Enabled = false;
                ListViewItem fli = new ListViewItem(new string[] { Text =  list1.SelectedItem.ToString(),comp.GetFlight(listf.SelectedIndex).From.Name, comp.GetFlight(listf.SelectedIndex).To.Name, howmanyseats.Value.ToString(), comp.GetFlight(listf.SelectedIndex).Ap.Name, comp.GetFlight(listf.SelectedIndex).Date.ToString(), comp.GetFlight(listf.SelectedIndex).ArrivalDate.ToString() });
                listView.Items.Add(fli);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return;
            }
        }
        
        private void howmanyseats_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comp.GetFlight(listf.SelectedIndex).Ap.Capacity < Convert.ToInt32(howmanyseats.Value))
                    throw new Exception("Select less seats");
                else
                    buyt.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void seeMyTick_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Visible = true;
                Back.Visible = true;
                list1.Visible = false;
                listf.Visible = false;
                buyt.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                AddPerson.Visible = false;
                NamePerson.Visible = false;
                PESEL.Visible = false;
                NameAgency.Visible = false;
                Surname.Visible = false;
                seeMyTick.Visible = false;
                AddAgency.Visible = false;
                ID.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Visible = false;
                Back.Visible = false;
                list1.Visible = true;
                listf.Visible = true;
                buyt.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                AddPerson.Visible = true;
                NamePerson.Visible = true;
                PESEL.Visible = true;
                NameAgency.Visible = true;
                Surname.Visible = true;
                seeMyTick.Visible = true;
                AddAgency.Visible = true;
                ID.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return;
            }
        }
    }
}
