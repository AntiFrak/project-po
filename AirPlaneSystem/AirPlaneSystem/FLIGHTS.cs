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
    public partial class FLIGHTS : Form
    {
        private Company comp;
        double Distans;
        Airport FromA, ToA;
        Airplane ap;
        DateTime date, dateAr;

        public FLIGHTS()
        {
            InitializeComponent();
        }

        public void setCompany(Company c)
        {
            try { 
            comp = c;
            foreach (Airport a in comp.GetAllAirports())
            {
                fromList.Items.Add(a.Name);
                toList.Items.Add(a.Name);
            }
            foreach (Flight f in comp.GetAllFlights())
            {
                ListViewItem fli = new ListViewItem(new string[] { Text = f.From.Name, f.To.Name, f.Ap.Capacity.ToString(), f.Ap.Name, f.Date.ToString(), f.ArrivalDate.ToString() });
                listView.Items.Add(fli);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void fFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void fTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void FLIGHTS_Load(object sender, EventArgs e)
        {

        }

        private void SelestPlane_Click(object sender, EventArgs e)
        {
            try
            {
                listPlanes.Enabled = true;
                Distans = (Math.Sqrt(Math.Pow(FromA.CoordX - ToA.CoordX, 2) + Math.Pow(FromA.CoordY - ToA.CoordY, 2)));
                dateAr = date.AddHours(Distans / 25);
                if (Distans > 749)
                {
                    foreach (Airplane a in comp.GetAllBigAirplanes())
                    {
                        listPlanes.Items.Add(a.Name + " [ID:" + a.Id + "]");
                    }
                }
                else
                {
                    if (Distans > 399 && Distans < 750)
                    {
                        foreach (Airplane a in comp.GetAllMediumAirplanes())
                        {
                            listPlanes.Items.Add(a.Name + " [ID:" + a.Id + "]");
                        }
                    }
                    else
                    {
                        if (Distans < 400)
                        {
                            foreach (Airplane a in comp.GetAllSmallAirplanes())
                            {
                                listPlanes.Items.Add(a.Name + " [ID:" + a.Id + "]");
                            }
                        }
                    }
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void toList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if (FromA != comp.GetAirport(toList.SelectedIndex))
                ToA = comp.GetAirport(toList.SelectedIndex);
            else
            {
                MessageBox.Show("Select other destination!");
                return;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            try { 
            comp.AddFlight(FromA, ToA, ap, date);
            ListViewItem fli = new ListViewItem(new string[] { Text = FromA.Name, ToA.Name, ap.Capacity.ToString(), ap.Name, date.ToString(), dateAr.ToString() });
            listView.Items.Add(fli);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void listPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            ap = comp.GetAirplane(listPlanes.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        { try { 
            if (dateTimePicker1.Value < DateTime.Now)
            {
                throw new Exception("Select correct date");
            }
            else
            {
                date = dateTimePicker1.Value;
                SelestPlane.Enabled = true;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void abort_Click(object sender, EventArgs e)
        {

        }

        private void fromList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            FromA = comp.GetAirport(fromList.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }
    }
}
