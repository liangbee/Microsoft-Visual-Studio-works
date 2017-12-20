using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateB_Click(object sender, EventArgs e)
        {
            try
            {
                ResultBox.Items.Clear();
                int InputInt = Int32.Parse(StartInt.Text);
                int CountInt = Int32.Parse(Count.Text);
                if (InputInt >= 0 && InputInt <= 1000000000 && CountInt >= 1 && CountInt <= 100)
                {
                    Comment.Text = "";
                    Comment.Visible = false;
                    for (int i = 1; i <= CountInt;)
                    {
                        string Input = InputInt.ToString();
                        string Reverse = new string(Input.ToCharArray().Reverse().ToArray());
                        if (Input == Reverse)
                        {
                            ResultBox.Items.Add(Input);
                            i += 1;
                            InputInt++;
                        }
                        else
                        {
                            InputInt++;
                        }
                    }
                }
                else
                {
                    Comment.Visible = true;
                    Comment.Text = "Please enter a positive integer within range.";
                }
            }
            catch (FormatException)
            {
                Comment.Visible = true;
                Comment.Text = "Please enter a positive integer within range.";
                ResultBox.Items.Clear();
            }
            catch (OverflowException)
            {
                Comment.Visible = true;
                Comment.Text = "Please enter a positive integer within range.";
                ResultBox.Items.Clear();
            }
        }
    }
}
