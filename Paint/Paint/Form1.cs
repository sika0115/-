using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.Black;
            button7.BackColor = Color.Red;
            button6.BackColor = Color.Blue;
            button2.BackColor = Color.Green;
            button4.BackColor = Color.Yellow;
            button5.BackColor = Color.Magenta;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bit1 = new Bitmap(pic.Width,pic.Height);
        }
        bool drawstate = false;
        Point locationo = new Point();
        Color colorp = Color.Black;

        Bitmap bit1 = null;

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            locationo = e.Location;
            drawstate = true;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawstate == false)
            {
                return;
            }

            Pen pen = new Pen(colorp, 3);

            using (Graphics g = Graphics.FromImage(bit1))
            {
                g.DrawLine(pen, locationo, e.Location);
            }
            pic.Image = bit1;
            locationo = e.Location;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            drawstate = false;
         }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            colorp = Color.Black;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            colorp = Color.Red;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            colorp = Color.Blue;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            colorp = Color.Yellow;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            colorp = Color.Green;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            colorp = Color.Magenta;
        }
    }
}


