using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace createTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int n;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Green, 2);
            Pen myPen2 = new Pen(Color.Black, 2);
            SolidBrush myBrush = new SolidBrush(Color.Blue);

            int xStart = 0;
            int yStart = 0;
            int xEnd = 456;
            int yEnd = 0;
            for (int i = 0; i <= 8; i++)
            {
                g.DrawLine(myPen2, xStart, yStart, xEnd, yEnd);
                yStart = yStart + 57;
                yEnd = yEnd + 57;
            }

            xStart = 0;
            yStart = 0;
            xEnd = 0;
            yEnd = 456;
            for (int i = 0; i <= 8; i++)
            {
                g.DrawLine(myPen2, xStart, yStart, xEnd, yEnd);
                xStart = xStart + 57;
                xEnd = xEnd + 57;
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (n)
            {
                case 1: pictureBox1.Location = new System.Drawing.Point(e.X, e.Y);
                    break;
                case 2: pictureBox2.Location = new System.Drawing.Point(e.X, e.Y);
                    break;
            }
            //algo.GetDistance()
            //MessageBox.Show(e.X.ToString()+" ,"+e.Y.ToString());
            n = 0;
            //MessageBox.Show(e.X.ToString());
            //this.panel1.Refresh();
            //Algo algo = new Algo();
            //int n = algo.cn_PnPoly(pClick, listPoint, (listPoint.Count - 1));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            n = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            n = 2;
        }
    }
}
