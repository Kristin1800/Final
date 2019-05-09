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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Portland
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.ihop.com/en/restaurants-portland-me/195-maine-mall-rd-2019");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Auburn
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.ihop.com/en/restaurants-auburn-me/649-turner-st-3534");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Augusta
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.ihop.com/en/restaurants-augusta-me/110-community-dr-3566");
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Saco
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.ihop.com/en/restaurants-saco-me/515-main-st-3652");
        }
    }
}
