using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string SelectedFilePath;
        public OpenFileDialog FindFilePath = new OpenFileDialog();
        private void FileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FindFilePath.ShowDialog() == DialogResult.OK)
                {
                    FindFilePath.InitialDirectory = "Desktop";
                    FindFilePath.Filter = "All files (*.*)|*.*";
                    FindFilePath.RestoreDirectory = true;
                    SelectedFilePath = FindFilePath.FileName;

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("File not found. Check the file name and check again.", "Open", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FilePathBox.Text = SelectedFilePath;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string path = FilePathBox.Text;
            string key = KeyBox.Text;
            if (key == "")
            {
                MessageBox.Show("Please enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    FileStream enfs = File.OpenRead(path);
                    string outputfilename = path + ".enc";
                    if (File.Exists(outputfilename))
                    {
                        MessageBox.Show("Output file exists. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }

                    using (FileStream output = File.Create(outputfilename))
                    {
                        for (int i = 0; i < enfs.Length; i++)
                        {
                            byte[] keybyte = Encoding.ASCII.GetBytes(key);
                            int keylength = keybyte.Length;
                            int n = keybyte[i % keylength] ^ enfs.ReadByte();
                            byte m = Convert.ToByte(n);
                            output.WriteByte(m);
                        }
                        MessageBox.Show("Operation completed successfully.");
                        enfs.Close();
                        output.Close();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FileNotFoundException)
                {
                    MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
                string path = FilePathBox.Text;
                string key = KeyBox.Text;
                if (key == "")
                {
                    MessageBox.Show("Please enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!path.EndsWith(".enc"))
                {
                    MessageBox.Show("Not a .enc file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                    FileStream defs = File.OpenRead(path);
                    string outputfilename = path.Substring(0, path.Length - 4);
                    string format = Path.GetExtension(path);
                    if (format != ".enc")
                    {
                        MessageBox.Show("Not a .enc file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (File.Exists(outputfilename))
                        {
                            MessageBox.Show("Output file exists. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        using (FileStream output = File.Create(outputfilename))
                        {
                            Retry:
                            try
                            {
                                for (int i = 0; i < defs.Length; i++)
                                {
                                    string istring = Convert.ToString(i);
                                    byte[] keybyte = Encoding.ASCII.GetBytes(key);
                                    int keylength = keybyte.Length;
                                    int n = keybyte[i % keylength] ^ defs.ReadByte();
                                    byte m = Convert.ToByte(n);
                                    output.WriteByte(m);
                                    string a = Convert.ToString(m);
                                }
                                defs.Close();
                                MessageBox.Show("Operation completed successfully.");
                            }
                            catch (IOException)
                            {
                                defs.Close();
                                output.Close();
                                goto Retry;
                            }
                           
                            
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FileNotFoundException)
                {
                    MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(IOException)
                {

                }
                }
            }
        }
    }