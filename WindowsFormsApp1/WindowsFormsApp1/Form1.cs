using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int r = 220;
        static int g = 20;
        static int b = 60;
        public Form1()
        {
            InitializeComponent();
            //ボタンの背景色設定
            button1.BackColor = Color.FromArgb(220, 20, 60);
            button2.BackColor = Color.FromArgb(219, 179, 20);
            button3.BackColor = Color.FromArgb(60, 219, 20);
            button4.BackColor = Color.FromArgb(20, 219, 179);
            button5.BackColor = Color.FromArgb(20, 60, 219);
            button6.BackColor = Color.FromArgb(179, 20, 219);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            r = 220;
            g = 20;
            b = 60;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            r = 219;
            g = 179;
            b = 20;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            r = 60;
            g = 219;
            b = 20;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            r = 20;
            g = 219;
            b = 179;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            r = 20;
            g = 60;
            b = 219;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            r = 179;
            g = 20;
            b = 219;
        }

        bool State = false;  //描画状態の制御
        int x;
        int y;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void From1_MouseDowm(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            State = true;
            x = e.Location.X;
            y = e.Location.Y;
        }

        private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            State = false;
        }

        private void From1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (State)
            {
                Pen pen = new Pen(System.Drawing.Color.FromArgb(r,g,b), 9);
                Graphics graphics = this.CreateGraphics();
                graphics.DrawLine(pen, x, y, e.Location.X, e.Location.Y);
                graphics.FillEllipse(Brushes.Black, x - pen.Width / 2, y - pen.Width / 2, pen.Width, pen.Width);
                x = e.Location.X;
                y = e.Location.Y;
                pen.Dispose();
                pen.Dispose();
            }
        }
    }
}
