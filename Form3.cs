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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Image img = Arrow.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Arrow.Image = img;
        }

        //applebees
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            var newForm = new Form10();
            newForm.Show();
        }
        //chilis
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Form11();
            newForm.Show();
        }
        //chipotle
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            var newForm = new Form12();
            newForm.Show();
        }
        //99
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            var newForm = new Form13();
            newForm.Show();
        }
    }
}
