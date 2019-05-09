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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Newington
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://order.chipotle.com/Meal/Index/1097?showloc=1");
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Concord
            linkLabel5.LinkVisited = true;
            System.Diagnostics.Process.Start("https://order.chipotle.com/Meal/Index/2826?showloc=1");
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Bedford
            linkLabel7.LinkVisited = true;
            System.Diagnostics.Process.Start("https://order.chipotle.com/Meal/Index/1799?showloc=1");
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Manchester
            linkLabel6.LinkVisited = true;
            System.Diagnostics.Process.Start("https://order.chipotle.com/Meal/Index/1473?showloc=1");
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Nashua
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://order.chipotle.com/Meal/Index/1737?showloc=1");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Keene
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://order.chipotle.com/Meal/Index/2959?showloc=1");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Dover
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://order.chipotle.com/Meal/Index/3156?showloc=1");
        }
    }
}
