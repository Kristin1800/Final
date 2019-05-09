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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseYourStateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MassB.Show();
            NHB.Show();
            VTB.Show();
            MAINEB.Show();

        }

        private void MassB_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
        }

        private void NHB_Click(object sender, EventArgs e)
        {
            var newForm = new Form3();
            newForm.Show();
        }

        private void VTB_Click(object sender, EventArgs e)
        {
            var newForm = new Form5();
            newForm.Show();
        }

        private void MAINEB_Click(object sender, EventArgs e)
        {
            var newForm = new Form4();
            newForm.Show();
        }
    }
}
