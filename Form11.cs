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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Salem
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.chilis.com/locations/us/new-hampshire/salem");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Dover
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.chilis.com/locations/us/new-hampshire/dover");
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Keene
            linkLabel5.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.chilis.com/locations/us/new-hampshire/keene");
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Nashua
            linkLabel6.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.chilis.com/locations/us/new-hampshire/nashua");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Seabrook
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.chilis.com/locations/us/new-hampshire/seabrook");

        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Tilton
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.chilis.com/locations/us/new-hampshire/tilton");
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //W Lebanon
            linkLabel7.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.chilis.com/locations/us/new-hampshire/w-lebanon");
        }
    }
}
