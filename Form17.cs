﻿using System;
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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Bangor
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.olivegarden.com/order-online?_requestid=1132331");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Augusta
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.olivegarden.com/order-online?_requestid=1132524");
        }
    }
}
