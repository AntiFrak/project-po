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
            comp = c;
            foreach (Airport a in comp.GetAllAirports())
            {
                fromList.Items.Add(a);
                toList.Items.Add(a);
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
            date = dateTimePicker1.Value;
        }

        private void FLIGHTS_Load(object sender, EventArgs e)
        {

        }

        private void SelestPlane_Click(object sender, EventArgs e)
        {
            Distans = (Math.Sqrt(Math.Pow(FromA.CoordX - ToA.CoordX, 2) + Math.Pow(FromA.CoordY - ToA.CoordY, 2)));
            dateAr = date.AddHours(Distans / 25);
            if (Distans > 749)
            {
                foreach (Airplane a in comp.GetAllBigAirplanes())
                {
                    listPlanes.Items.Add(a);
                }
            }
            else
            {
                if (Distans > 399 && Distans < 750)
                {
                    foreach (Airplane a in comp.GetAllMediumAirplanes())
                    {
                        listPlanes.Items.Add(a);
                    }
                }
                else
                {
                    if (Distans < 400)
                    {
                        foreach (Airplane a in comp.GetAllSmallAirplanes())
                        {
                            listPlanes.Items.Add(a);
                        }
                    }
                }
            }
        }

        private void toList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FromA != comp.GetAirport(toList.SelectedIndex))
                ToA = comp.GetAirport(toList.SelectedIndex);
            else
            {
                MessageBox.Show("ERROR!!!");
                return;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            comp.AddFlight(FromA, ToA, ap, date);
            ListViewItem item = new ListViewItem { Text = FromA.Name };
            item.SubItems.Add(ToA.Name);
            item.SubItems.Add(ap.Capacity.ToString());
            item.SubItems.Add(ap.Name);
            item.SubItems.Add(date.ToShortDateString());
            item.SubItems.Add(dateAr.ToShortDateString());
        }

        private void listPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ap = comp.GetAirplane(listPlanes.SelectedIndex);
        }

        private void abort_Click(object sender, EventArgs e)
        {

        }

        private void fromList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromA = comp.GetAirport(fromList.SelectedIndex);
        }
    }
}
