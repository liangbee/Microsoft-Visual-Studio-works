using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Please note that I am using the free late chance for this assignment.
namespace lab6
{
    public partial class Form1 : Form
    {

        public List<shape> ShapeList = new List<shape>();
        public int mouseclick;
        public Point p1;
        public Point p2;
        public bool fill = false;
        public bool oline = true;
        public int pcolor = 0;
        public Color Pencolor;
        public int fcolor = 0;
        public Color fillcolor;
        public int width = 0;
        // some of the values are set to initialize the values in the settings window.
        public Form1()
        {
            InitializeComponent();            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeList.Clear();
            this.Refresh();
            // choose refresh over invalidate cuz refresh is asynchronus. I blindly use refresh for all cases bc i don't want to debug
            // :P
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShapeList.Count > 0)
                ShapeList.RemoveAt(ShapeList.Count - 1);
            this.Refresh();
        }

        private void drawpad_MouseClick(object sender, MouseEventArgs e)
        {
            if (pcolor == 0) { Pencolor = Color.Black; }
            if (pcolor == 1) { Pencolor = Color.Red; }
            if(pcolor == 2) { Pencolor = Color.Blue; }
            if(pcolor == 3) { Pencolor = Color.Green; }
            if (fcolor == 0) { fillcolor = Color.White; }
            if (fcolor == 1) { fillcolor = Color.Black; }
            if (fcolor == 2) { fillcolor = Color.Red; }
            if (fcolor == 3) { fillcolor = Color.Blue; }
            if (fcolor == 4) { fillcolor = Color.Green; }
            // could have done it in a smarter way
            Point mouse = new Point(e.X, e.Y);
            mouseclick++;
            if (mouseclick < 2)
            {
                p1 = mouse;
            }
            else if (mouseclick == 2)
            {
                p2 = mouse;
                if (LineB.Checked == true)
                {
                    Line newline = new Line(p1, p2, fill, Pencolor, fillcolor,width);
                    ShapeList.Add(newline);
                    this.Refresh();
                    // if no refresh image won't get updated
                }
                if (RecB.Checked == true)
                {
                    if (fill != true && oline != true){
                        MessageBox.Show("Fill and or outline must be checked.");
                        // warning
                    }
                    else {
                        shapeRectangle newrec = new shapeRectangle(p1, p2, fill, Pencolor, fillcolor, width);
                        ShapeList.Add(newrec);
                        this.Refresh();
                    }
                    
                }
                if (EllB.Checked == true)
                {
                    if (fill != true && oline != true){
                        MessageBox.Show("Fill and or outline must be checked.");
                        // warning
                    }
                    else
                    {
                        shapeEllipse newell = new shapeEllipse(p1, p2, fill, Pencolor, fillcolor, width);
                        ShapeList.Add(newell);
                        this.Refresh();
                    }
                }
                mouseclick = 0; // resets mouseclick at the end to preven potential bug. 
                // this is recording how many clicks have been done by the user.
            }

        }

        private void SettingsB_Click(object sender, EventArgs e)
        {
            Settings newwindow = new Settings(pcolor, width, fill, oline, fcolor);
            newwindow.StartPosition = FormStartPosition.CenterParent;
            if (newwindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // show dialog and gather information
                fill = newwindow.getFill();
                width = newwindow.getPW();
                pcolor = newwindow.getPC();
                fcolor = newwindow.getFC();
                oline = newwindow.getOutl();
            }
        }

        private void drawpad_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = drawpad.CreateGraphics();
            foreach (shape a in ShapeList)
            {
                a.Drawshape(g);
            }
        }
    }
}
