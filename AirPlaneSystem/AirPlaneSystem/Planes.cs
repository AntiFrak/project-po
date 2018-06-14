﻿using System;
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
        private Company comp;
        public Planes()
        {
            InitializeComponent();            
        }
        public void setCompany(Company c)
        {
            comp = c;
            foreach (Airplane a in comp.GetAllAirplanes())
            {
                list.Items.Add(a.Name + " [ID:" + a.Id + "]");
            }
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
            switch (TypePlane.SelectedIndex) // choise a type of airplane
            {
                case 0:
                    MaxDistans.Text = "1500";
                    Capacity.Text = "300";
                    break;
                case 1:
                    MaxDistans.Text = "750";
                    Capacity.Text = "150";
                    break;
                case 2:
                    MaxDistans.Text = "400";
                    Capacity.Text = "50";
                    break;
                default:
                    Console.WriteLine("Unknown airplane type!!!");
                    break;
            }
        }

        private void AddPlane_Click(object sender, EventArgs e)
        {
            comp.AddAirplane(NamePlane.Text, Convert.ToInt32(ID.Text), Convert.ToInt32(TypePlane.SelectedIndex));
            list.Items.Add(NamePlane.Text +  " [ID:" + ID.Text + "]");

        }

        private void RemovePlane_Click(object sender, EventArgs e)
        {
            comp.RemoveAirplane(list.SelectedIndex);
            list.Items.Remove(list.SelectedItem);
        }

        private void back_Click(object sender, EventArgs e)
        {

        }
    }
}
