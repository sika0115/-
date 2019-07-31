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
        float x1;
        float y1;
        float x2;
        float y2;

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
        Pen pen = new Pen(Color.Black, 4);

        private void Button1_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 4);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, 4);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue, 4);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Green, 4);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Yellow, 4);

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Magenta, 4);
        }
        private void PictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            x1 = System.Windows.Forms.Cursor.Position.X;//最初のX座標取得
            y1 = System.Windows.Forms.Cursor.Position.Y;//最初のY座標取得
        }
        private void PictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) 
        {
            x2 = System.Windows.Forms.Cursor.Position.X;//離したところのX座標取得
            y2 = System.Windows.Forms.Cursor.Position.Y;//離したところのY座標取得

            Graphics g = this.CreateGraphics();
            PointF p1 = new PointF(x1, y1);
            PointF p2 = new PointF(x2, y2);
            g.DrawLine(pen, p1, p2);



        }
    }
}
