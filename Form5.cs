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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Image img = Arrow.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Arrow.Image = img;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //outback
            var newForm = new Form18();
            newForm.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {//Farmhouse
            var newForm = new Form19();
            newForm.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {//longhorn
            var newForm = new Form20();
            newForm.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            //butch and babes
            var newForm = new Form21();
            newForm.Show();
        }
    }
}
