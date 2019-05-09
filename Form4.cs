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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Image img = Arrow.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Arrow.Image = img;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            //uno
            var newForm = new Form14();
            newForm.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            //crackerbarrel
            var newForm = new Form15();
            newForm.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            var newForm = new Form16();
            newForm.Show();
            //ihop
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Form17();
            newForm.Show();
            //olive garden
        }
    }
}
