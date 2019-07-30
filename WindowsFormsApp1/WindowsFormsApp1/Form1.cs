using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ボタンの背景色設定
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.Yellow;
            button5.BackColor = Color.Violet;
            button6.BackColor = Color.Magenta;
        }

        int colorsave = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            colorsave = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            colorsave = 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            colorsave = 2;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            colorsave = 3;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            colorsave = 4;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            colorsave = 5;
        }

        bool State = false;  //描画状態の制御
        int drawx;
        int drawy;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

         private void PictureBox1_Click(object sender, EventArgs e)
        {
            State = true;
        }

        private void PictureBox1_MouseDowm(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            State = true;
            drawx = e.Location.X;
            drawy = e.Location.Y;
        }

        private void PictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            State = false;
        }

        private void PictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (State == true)
            {
                if (colorsave == 0)
                {
                    Pen pen = new Pen(System.Drawing.Color.Red, 9);
                    Graphics graphics = this.CreateGraphics();
                    graphics.DrawLine(pen, drawx, drawy, e.Location.X, e.Location.Y);
                    graphics.FillEllipse(System.Drawing.Brushes.Red, drawx - pen.Width / 2, drawy - pen.Width / 2, pen.Width, pen.Width);
                    drawx = e.Location.X;
                    drawy = e.Location.Y;
                    pen.Dispose();
                }
                if (colorsave == 1)
                {
                    Pen pen = new Pen(System.Drawing.Color.Green, 9);
                    Graphics graphics = this.CreateGraphics();
                    graphics.DrawLine(pen, drawx, drawy, e.Location.X, e.Location.Y);
                    graphics.FillEllipse(System.Drawing.Brushes.Green, drawx - pen.Width / 2, drawy - pen.Width / 2, pen.Width, pen.Width);
                    drawx = e.Location.X;
                    drawy = e.Location.Y;
                    pen.Dispose();
                }
                if (colorsave == 2)
                {
                    Pen pen = new Pen(System.Drawing.Color.Blue, 9);
                    Graphics graphics = this.CreateGraphics();
                    graphics.DrawLine(pen, drawx, drawy, e.Location.X, e.Location.Y);
                    graphics.FillEllipse(System.Drawing.Brushes.Blue, drawx - pen.Width / 2, drawy - pen.Width / 2, pen.Width, pen.Width);
                    drawx = e.Location.X;
                    drawy = e.Location.Y;
                    pen.Dispose();
                }
                if (colorsave == 3)
                {
                    Pen pen = new Pen(System.Drawing.Color.Yellow, 9);
                    Graphics graphics = this.CreateGraphics();
                    graphics.DrawLine(pen, drawx, drawy, e.Location.X, e.Location.Y);
                    graphics.FillEllipse(System.Drawing.Brushes.Yellow, drawx - pen.Width / 2, drawy - pen.Width / 2, pen.Width, pen.Width);
                    drawx = e.Location.X;
                    drawy = e.Location.Y;
                    pen.Dispose();
                }
                if (colorsave == 4)
                {
                    Pen pen = new Pen(System.Drawing.Color.Violet, 9);
                    Graphics graphics = this.CreateGraphics();
                    graphics.DrawLine(pen, drawx, drawy, e.Location.X, e.Location.Y);
                    graphics.FillEllipse(System.Drawing.Brushes.Violet, drawx - pen.Width / 2, drawy - pen.Width / 2, pen.Width, pen.Width);
                    drawx = e.Location.X;
                    drawy = e.Location.Y;
                    pen.Dispose();
                }
                if (colorsave == 5)
                {
                    Pen pen = new Pen(System.Drawing.Color.Magenta, 9);
                    Graphics graphics = this.CreateGraphics();
                    graphics.DrawLine(pen, drawx, drawy, e.Location.X, e.Location.Y);
                    graphics.FillEllipse(System.Drawing.Brushes.Magenta, drawx - pen.Width / 2, drawy - pen.Width / 2, pen.Width, pen.Width);
                    drawx = e.Location.X;
                    drawy = e.Location.Y;
                    pen.Dispose();
                }



            }
        }

    }
}
