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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = img;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Yardhouse_Click(object sender, EventArgs e)
        {
            var newForm = new Form6();
            newForm.Show();
        }

        private void Wahlburgers_Click(object sender, EventArgs e)
        {
            var newForm = new Form7();
            newForm.Show();
        }

        private void Cheesecake_Click(object sender, EventArgs e)
        {
            var newForm = new Form8();
            newForm.Show();
        }

        private void Missionbar_Click(object sender, EventArgs e)
        {
            var newForm = new Form9();
            newForm.Show();
        }
    }
}
