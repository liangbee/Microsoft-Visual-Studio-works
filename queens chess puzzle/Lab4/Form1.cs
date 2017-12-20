using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public bool HintsCheck = false;
        public int NumOfQueens = 0;
        public Size BlockSize = new Size(50, 50);
        public Pen BlackP = new Pen(Brushes.Black, 2);
        public Brush Bow;
        public List<Point> BlockPointList = new List<Point>();
        public List<Block> Blocks = new List<Block>();
        public List<Block> Queens = new List<Block>();
        public List<Rectangle> Rects = new List<Rectangle>();
        public Form1()
        {
            InitializeComponent();
            MessB.Text = "You have " + NumOfQueens + " queens on board.";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Point a = new Point(100 + 50 * j, 100 + 50 * i);
                    BlockPointList.Add(a);
                }
            }
        }

        private void HintB_CheckedChanged(object sender, EventArgs e)
        {
            if (HintsCheck == false) HintsCheck = true;
            else if (HintsCheck == true) HintsCheck = false;
            this.Invalidate();
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            Queens.Clear();
            NumOfQueens = 0;
            MessB.Text = "You have " + NumOfQueens + " queens on board.";
            foreach (Block b in Blocks)
            {
                b.Safe = true;
                b.Queen = false;
            }
            this.Invalidate();

        }
        private void Check_safe(Block a)
        {
            foreach (Block b in Blocks)
            { 
                if (b.Column == a.Column || b.Row == a.Row) b.Safe = false;
                if (b.Column - a.Column == b.Row - a.Row) b.Safe = false;
                else if (b.Column - a.Column == -(b.Row - a.Row)) b.Safe = false;
                this.Invalidate();
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // set up the graphics object
            // now set up the board cells using rectangle object
            // adds 64 points corresponding to each cell for later construction
            int j = 0;
            Pen p = new Pen(Brushes.Black, 1);
            for (int column = 0; column < 8; column++)
            {
                for (int row = 0; row < 8; row++)
                {
                    Block newblock = new Block(column, row, BlockPointList[j]);
                    Blocks.Add(newblock); // adding block to the blocklist for record
                    Rectangle newrect = new Rectangle(BlockPointList[j], BlockSize);
                    Rects.Add(newrect);
                    // rectangles will draw out the blocks of the board.
                    g.DrawRectangle(BlackP, newrect);
                    int i = column % 2;
                    int k = row % 2;
                    j++;

                    if (k == i)
                    {
                        g.FillRectangle(newblock.Bbrush, newrect);
                    }
                    else if (k != i)
                    {
                        g.FillRectangle(newblock.Bbrush, newrect);

                    }
                }
            }
            if (!HintsCheck) // hints not checked
            {
                foreach (Block b in Queens)
                {
                    Font Arial = new Font("Arial", 30, FontStyle.Bold);
                    if (b.Bbrush == Brushes.Black) Bow = Brushes.White;
                    else if (b.Bbrush == Brushes.White) Bow = Brushes.Black;
                    if (HintsCheck)
                    {
                        g.DrawString("Q", Arial, Brushes.Black, b.Coordinate);
                    }
                    else if (HintsCheck == false) // HINTS not checked 
                    {
                        g.DrawString("Q", Arial, Bow, b.Coordinate);
                    }
                }

            }
            else if (HintsCheck)
            {
                int counter = 0;
                foreach (Block b in Blocks)
                {
                    if (b.Safe == false)
                    {
                        
                        g.FillRectangle(Brushes.Red, Rects[counter]);
                        g.DrawRectangle(p, Rects[counter]);
                    }
                    counter++;
                }
                foreach (Block c in Queens)
                {
                    Font drawfont = new Font("Arial", 30, FontStyle.Bold);
                    if (c.Bbrush == Brushes.Black) Bow = Brushes.White;
                    else if (c.Bbrush == Brushes.White) Bow = Brushes.Black;
                    g.DrawString("Q", drawfont, Brushes.Black, c.Coordinate);
                    
                }
                

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {   
            if (e.Button == MouseButtons.Right)
            {
                Point Mousecord = new Point(e.X, e.Y);
                int RangeX;
                int RangeY;
                for(int i = 0; i < NumOfQueens; i++)
                {
                    RangeX = Mousecord.X - Queens[i].Coordinate.X;
                    RangeY = Mousecord.Y - Queens[i].Coordinate.Y;
                    if (RangeX < 50 && RangeY < 50 && RangeX > 0 && RangeY > 0)
                    {
                        Queens.Remove(Queens[i]);
                        NumOfQueens -= 1;
                        this.Invalidate();
                        MessB.Text = "You have " + NumOfQueens + " queens on board.";
                        foreach (Block b in Blocks) b.Safe = true;
                        break;
                    }
                }
                this.Invalidate();
            }            
            if(e.Button == MouseButtons.Left)
            {
                if (NumOfQueens == 8){
                    MessageBox.Show("You did it!"); // no i didn't
                    foreach (Block b in Blocks) b.Safe = false;
                }
                Point Mousecord = new Point(e.X, e.Y);
                int RangeX;
                int RangeY;
                foreach (Block a in Blocks)
                {
                    if (a.Safe == true)
                    {
                        RangeX = Mousecord.X - a.Coordinate.X;
                        RangeY = Mousecord.Y - a.Coordinate.Y;
                        if (RangeX < 50 && RangeY < 50 && RangeX > 0 && RangeY > 0 && !Queens.Contains(a))
                        {
                            Queens.Add(a);
                            a.Safe = false;
                            a.Queen = true;
                            Check_safe(a); // checks surrounding blocks
                            NumOfQueens += 1;
                            MessB.Text = "You have " + NumOfQueens + " queens on board.";
                            this.Invalidate();
                            break;
                            
                        }
                        else
                        {
                            System.Media.SystemSounds.Beep.Play();
                        }
                    }
                   }

            }
        }
    }
}
