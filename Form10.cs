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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//Concord
            linkLabel5.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.applebees.com/en/restaurants-concord-nh/260-loudon-rd-steeplegate-mall-81041");

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Hooksett
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.applebees.com/en/restaurants-hooksett-nh/1273-hooksett-road-81061");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Manchester
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.applebees.com/en/restaurants-manchester-nh/581-2nd-st-shops-second-street-shops-81038");
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Tilton
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.applebees.com/en/restaurants-tilton-nh/75-laconia-rd-shaws-plaza-81055");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Derry
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.applebees.com/en/restaurants-derry-nh/14-manchester-rd-81042");
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Epping
            linkLabel6.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.applebees.com/en/restaurants-epping-nh/7-fresh-river-road-81079");
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Nashua
            linkLabel7.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.applebees.com/en/restaurants-nashua-nh/379-amherst-st-somerset-plaza-81037");
        }

        private void LinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Dover
            linkLabel8.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.applebees.com/en/restaurants-dover-nh/232-indian-brook-dr-81068");
        }

      

        private void LinkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Portsmouth
            linkLabel10.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.applebees.com/en/restaurants-portsmouth-nh/1464-woodbury-avenue-81043");
        }
    }
}
