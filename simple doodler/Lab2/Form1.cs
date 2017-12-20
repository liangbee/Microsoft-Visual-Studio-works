using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

// some how this code works completely fine when you don't click too fast. 
// please be patient.

namespace Lab3
{
    public partial class Form1 : Form
    {
        public class mypoint
        {
            public float xcord = 0;
            public float ycord = 0;
            public Color p_color = Color.Black;
        }
        public mypoint dpoint(float x, float y)
        {
            mypoint p = new mypoint();
            p.xcord = x;
            p.ycord = y;
            p.p_color = Color.Black;
            return p;
        }
        public ArrayList coordinates = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            void delete(mypoint p)
            {
                this.coordinates.Remove(p);
                this.Invalidate();
            }

            if (e.Button == MouseButtons.Left)
            {
                mypoint p = dpoint(e.X, e.Y);
                this.coordinates.Add(p);
                this.Invalidate();
            }
            if (e.Button == MouseButtons.Right)
            {
                float x = e.X;
                float y = e.Y;
                List<mypoint> temp = new List<mypoint>();
                foreach (mypoint p in this.coordinates)
                    {
                        try
                        {
                            if (x > p.xcord - 20 && x < p.xcord + 20 && y > p.ycord - 20 && y < p.ycord + 20 && p.p_color == Color.Black)
                            {
                                p.p_color = Color.Red;
                            }
                            else if (x > p.xcord - 20 && x < p.xcord + 20 && y > p.ycord - 20 && y < p.ycord + 20 && p.p_color == Color.Red)
                            {
                                temp.Add(p);
                            }
                        }
                        catch (System.InvalidOperationException)
                        {
                            temp.Add(p);
                        }
                    }
                foreach (mypoint p in temp)
                {
                    this.coordinates.Remove(p);
                }
                }
            this.Invalidate();
        }
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            const int WIDTH = 20;
            const int HEIGHT = 20;
            Graphics g = e.Graphics;
            foreach (mypoint p in this.coordinates)
            {
                if (p.p_color == Color.Black)
                {
                    g.FillEllipse(Brushes.Black, p.xcord - WIDTH / 2, p.ycord - WIDTH / 2, WIDTH, HEIGHT);
                }
                else if (p.p_color == Color.Red)
                {
                    g.FillEllipse(Brushes.Red, p.xcord - WIDTH / 2, p.ycord - WIDTH / 2, WIDTH, HEIGHT);
                }
                else
                {
                    g.FillEllipse(Brushes.Black, p.xcord - WIDTH / 2, p.ycord - WIDTH / 2, WIDTH, HEIGHT);
                }
            }
        }

        public void CB_click(object sender, EventArgs e)
        {
            this.coordinates.Clear();
            this.Invalidate();
        }

        private void Menu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.coordinates.Clear();
            this.Invalidate();
        }
    }
}

