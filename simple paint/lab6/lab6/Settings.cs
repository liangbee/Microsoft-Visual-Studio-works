using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Settings : Form
    {
        public int PenColor;
        public int width;
        public bool Fill;
        public bool Outline;
        public int Fcolor;
        public Settings()
        {
            InitializeComponent(); // constructor
        }

        public Settings(int inPC, int inwidth, bool inFill, bool inOutline, int inFcolor)
        {
            InitializeComponent();
            fillCB.Checked = inFill;
            OBox.Checked = inOutline;
            pcBox.SelectedIndex = inPC;
            fcBox.SelectedIndex = inFcolor;
            pwBox.SelectedIndex = inwidth;
            // the above lines are in this way to initialize what's inside the settings window.
            Fill = inFill;
            Outline = inOutline;
            PenColor = inPC;
            Fcolor = inFcolor;
            width = inwidth;
            PenColor = pcBox.SelectedIndex; // 1=black 2=red 3=blue 4=green
            Fcolor = fcBox.SelectedIndex; // 1= white 2=black 3=red 4=blue 5=green
            width = pwBox.SelectedIndex + 1; // Index+1 = real value
        }

        public bool getFill()
        {
            return Fill;
        }
        public bool getOutl() {
            return Outline;
        }
        public int getPC() {
            return PenColor;
        }
        public int getFC() {
            return Fcolor;
        }
        public int getPW() {
            return width;
        } 
        // above are convinient commands for form1 to retrieve information.
        private void OKbutton_Click(object sender, EventArgs e)
        {
            Fill = fillCB.Checked;
            Outline = OBox.Checked;
            PenColor = pcBox.SelectedIndex;
            Fcolor = fcBox.SelectedIndex;
            width = pwBox.SelectedIndex;
            // these lines should be able to preserve last choices.
        }
    }
}
