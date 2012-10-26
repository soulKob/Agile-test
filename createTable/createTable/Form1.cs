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

            //Set icon Undo default = false
            btUndoY1.Enabled = false;
            btUndoY2.Enabled = false;
            btUndoY3.Enabled = false;
            btUndoY4.Enabled = false;
            btUndoY5.Enabled = false;
            btUndoY6.Enabled = false;
            btUndoY7.Enabled = false;
            btUndoY8.Enabled = false;

            btUndoG1.Enabled = false;
            btUndoG2.Enabled = false;
            btUndoG3.Enabled = false;
            btUndoG4.Enabled = false;
            btUndoG5.Enabled = false;
            btUndoG6.Enabled = false;
            btUndoG7.Enabled = false;
            btUndoG8.Enabled = false;

        }

        private int n;
        private int chkPointYell = 0;
        private int chkPointGreen = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (chkPointYell == 8)
            {
                MessageBox.Show("Blue is Win but Yellow is lose");
                Application.Restart();
            }
            else if (chkPointGreen == 8)
            {
                MessageBox.Show("Yellow is Win but Blue is lose");
                Application.Restart();
            }
            //Graphics g = e.Graphics;
            //Pen myPen = new Pen(Color.Green, 2);
            //Pen myPen2 = new Pen(Color.Black, 2);
            //SolidBrush myBrush = new SolidBrush(Color.Blue);

            //int xStart = 0;
            //int yStart = 0;
            //int xEnd = 456;
            //int yEnd = 0;
            //for (int i = 0; i <= 8; i++)
            //{
            //    g.DrawLine(myPen2, xStart, yStart, xEnd, yEnd);
            //    yStart = yStart + 57;
            //    yEnd = yEnd + 57;
            //}

            //xStart = 0;
            //yStart = 0;
            //xEnd = 0;
            //yEnd = 456;
            //for (int i = 0; i <= 8; i++)
            //{
            //    g.DrawLine(myPen2, xStart, yStart, xEnd, yEnd);
            //    xStart = xStart + 57;
            //    xEnd = xEnd + 57;
            //}
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = algo.createPointList(new Point(e.X, e.Y));
            switch (n)
            {
                case 1: pictureBox1.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 2: pictureBox2.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 3: pictureBox3.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 4: pictureBox4.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 5: pictureBox5.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 6: pictureBox6.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 7: pictureBox7.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 8: pictureBox8.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 9: pictureBox9.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 10: pictureBox10.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 11: pictureBox11.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 12: pictureBox12.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 13: pictureBox13.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 14: pictureBox14.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 15: pictureBox15.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
                case 16: pictureBox16.Location = new System.Drawing.Point(p.X, p.Y);
                    break;
            }
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
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
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            n = 2;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            n = 3;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            n = 4;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            n = 5;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            n = 6;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            } 
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            n = 7;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox7.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            n = 8;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox8.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            n = 9;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            n = 10;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox10.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            n = 11;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox11.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            n = 12;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox12.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            n = 13;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox13.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            n = 14;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox14.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            n = 15;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox15.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            n = 16;
            foreach (PictureBox picBox in this.panel1.Controls.OfType<PictureBox>())
            {
                picBox.BorderStyle = BorderStyle.None;
                picBox.Refresh();
            }
            pictureBox16.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bt_Y1_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            bt_Y1.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY1.Enabled = true;
            
        }

        private void bt_Y2_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            bt_Y2.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY2.Enabled = true;
        }

        private void bt_Y3_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            bt_Y3.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY3.Enabled = true;
        }

        private void bt_Y4_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
            bt_Y4.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY4.Enabled = true;
        }

        private void bt_Y5_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
            bt_Y5.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY5.Enabled = true;
        }

        private void bt_Y6_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false;
            bt_Y6.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY6.Enabled = true;
        }

        private void bt_Y7_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
            bt_Y7.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY7.Enabled = true;
        }

        private void bt_Y8_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = false;
            bt_Y8.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY8.Enabled = true;
        }

        private void bt_G1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            bt_G1.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG1.Enabled = true;
        }

        private void bt_G2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            bt_G2.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG2.Enabled = true;
        }

        private void bt_G3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            bt_G3.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG3.Enabled = true;
        }

        private void bt_G4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            bt_G4.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG4.Enabled = true;
        }

        private void bt_G5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            bt_G5.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG5.Enabled = true;
        }

        private void bt_G6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            bt_G6.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG6.Enabled = true;
        }

        private void bt_G7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            bt_G7.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG7.Enabled = true;
        }

        private void bt_G8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            bt_G8.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG8.Enabled = true;
        }

       private void btUndoG1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            bt_G1.Enabled = true;
            chkPointGreen = chkPointGreen -1 ;
        }

        private void btUndoG2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            bt_G2.Enabled = true;
            chkPointGreen = chkPointGreen - 1;
        }

        private void btUndoG3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            bt_G3.Enabled = true;
            chkPointGreen = chkPointGreen - 1;
        }

        private void btUndoG4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            bt_G4.Enabled = true;
            chkPointGreen = chkPointGreen - 1;
        }

        private void btUndoG5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            bt_G5.Enabled = true;
            chkPointGreen = chkPointGreen - 1;
        }

        private void btUndoG6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            bt_G6.Enabled = true;
            chkPointGreen = chkPointGreen - 1;
        }

        private void btUndoG7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            bt_G7.Enabled = true;
            chkPointGreen = chkPointGreen - 1;
        }

        private void btUndoG8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            bt_G8.Enabled = true;
            chkPointGreen = chkPointGreen - 1;
        }

        private void btUndoY1_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            bt_Y1.Enabled = true;
            chkPointYell = chkPointGreen - 1;
        }

        private void btUndoY2_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            bt_Y2.Enabled = true;
            chkPointYell = chkPointGreen - 1;
        }

        private void btUndoY3_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = true;
            bt_Y3.Enabled = true;
            chkPointYell = chkPointGreen - 1;
        }

        private void btUndoY4_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
            bt_Y4.Enabled = true;
            chkPointYell = chkPointGreen - 1;
        }

        private void btUndoY5_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible = true;
            bt_Y5.Enabled = true;
            chkPointYell = chkPointGreen - 1;
        }

        private void btUndoY6_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true;
            bt_Y6.Enabled = true;
            chkPointYell = chkPointGreen - 1;
        }

        private void btUndoY7_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = true;
            bt_Y7.Enabled = true;
            chkPointYell = chkPointGreen - 1;
        }

        private void btUndoY8_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = true;
            bt_Y8.Enabled = true;
            chkPointYell = chkPointGreen - 1;
        }

        private void Btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            bt_Y1.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY1.Enabled = true;
        }

        private void bt_Y2_Click_1(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            bt_Y2.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY2.Enabled = true;
        }

        private void bt_Y3_Click_1(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            bt_Y3.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY3.Enabled = true;
        }

        private void bt_Y4_Click_1(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
            bt_Y4.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY4.Enabled = true;
        }

        private void pictureBox17_Click_1(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
            bt_Y5.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY5.Enabled = true;
        }

        private void bt_Y6_Click_1(object sender, EventArgs e)
        {
            pictureBox14.Visible = false;
            bt_Y6.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY6.Enabled = true;
        }

        private void bt_Y7_Click_1(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
            bt_Y7.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY7.Enabled = true;
        }

        private void bt_Y8_Click_1(object sender, EventArgs e)
        {
            pictureBox16.Visible = false;
            bt_Y8.Enabled = false;
            chkPointYell = chkPointYell + 1;
            btUndoY8.Enabled = true;
        }

        private void bt_G1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            bt_G1.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG1.Enabled = true;
        }

        private void bt_G1_Click_2(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            bt_G1.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG1.Enabled = true;
        }

        private void bt_G2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            bt_G2.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG2.Enabled = true;
        }

        private void bt_G3_Click_1(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            bt_G3.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG3.Enabled = true;
        }

        private void bt_G4_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            bt_G4.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG4.Enabled = true;
        }

        private void bt_G5_Click_1(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            bt_G5.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG5.Enabled = true;
        }

        private void bt_G6_Click_1(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            bt_G6.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG6.Enabled = true;
        }

        private void bt_G7_Click_1(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            bt_G7.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG7.Enabled = true;
        }

        private void bt_G8_Click_1(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            bt_G8.Enabled = false;
            chkPointGreen = chkPointGreen + 1;
            btUndoG8.Enabled = true;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.pictureBox9.Image = new Bitmap("YK1.jpg");
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            this.pictureBox10.Image = new Bitmap("YK2.jpg");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.pictureBox11.Image = new Bitmap("YK3.jpg");
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.pictureBox12.Image = new Bitmap("YK4.jpg");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.pictureBox13.Image = new Bitmap("YK5.jpg");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.pictureBox14.Image = new Bitmap("YK6.jpg");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.pictureBox15.Image = new Bitmap("YK7.jpg");
        }

        private void pictureBox17_Click_2(object sender, EventArgs e)
        {
            this.pictureBox16.Image = new Bitmap("YK8.jpg");
        }



        private void pictureBox31_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Image = new Bitmap("GK2.jpg");
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            this.pictureBox3.Image = new Bitmap("GK3.jpg");
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            this.pictureBox4.Image = new Bitmap("GK4.jpg");
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            this.pictureBox5.Image = new Bitmap("GK5.jpg");
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            this.pictureBox6.Image = new Bitmap("GK6.jpg");
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.pictureBox7.Image = new Bitmap("GK7.jpg");
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            this.pictureBox8.Image = new Bitmap("GK8.jpg");
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = new Bitmap("GK1.jpg");
       
}

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.Show();
        }





    }
}
