using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Pro
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //concord
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Concord/25/");
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Dover
            linkLabel5.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Dover/29/");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Hooksett
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Hooksett/48/");
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Littleton
            linkLabel7.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Littleton/51/");
        }

        private void LinkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Portsmouth
            linkLabel9.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Portsmouth/70/");
        }

        private void LinkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Salem
            linkLabel10.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Salem/78/");
        }

        private void LinkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Seabrook
            linkLabel11.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Seabrook/81/");
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Manchester
            linkLabel6.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Manchester/55/");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Londonderry
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Londonderry/54/");

        }

        private void LinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //N. Conway
            linkLabel8.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/North%20Conway/60/");
        }

        private void LinkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Tilton
            linkLabel13.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Tilton/89/");
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Nashua
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/Nashua/62/");
        }

        private void LinkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //W. Lebanon
            linkLabel12.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.99restaurants.com/Locations/NH/West%20Lebanon/94/");
        }
    }
}
