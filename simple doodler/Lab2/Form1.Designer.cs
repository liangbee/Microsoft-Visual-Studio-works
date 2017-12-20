namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuS = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Clearmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuS.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuS
            // 
            this.MenuS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.MenuS.Location = new System.Drawing.Point(0, 0);
            this.MenuS.Name = "MenuS";
            this.MenuS.Size = new System.Drawing.Size(282, 28);
            this.MenuS.TabIndex = 1;
            this.MenuS.Text = "File";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clearmenuitem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(44, 24);
            this.Menu.Text = "File";
            this.Menu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_DropDownItemClicked);
            // 
            // Clearmenuitem
            // 
            this.Clearmenuitem.Name = "Clearmenuitem";
            this.Clearmenuitem.Size = new System.Drawing.Size(118, 26);
            this.Clearmenuitem.Text = "Clear";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.MenuS);
            this.MainMenuStrip = this.MenuS;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MenuS.ResumeLayout(false);
            this.MenuS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuS;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Clearmenuitem;
    }
}

