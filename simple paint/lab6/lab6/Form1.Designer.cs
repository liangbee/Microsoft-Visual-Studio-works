namespace lab6
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
            this.greypanel = new System.Windows.Forms.Panel();
            this.DrawBox = new System.Windows.Forms.GroupBox();
            this.SettingsB = new System.Windows.Forms.Button();
            this.EllB = new System.Windows.Forms.RadioButton();
            this.RecB = new System.Windows.Forms.RadioButton();
            this.LineB = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawpad = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.greypanel.SuspendLayout();
            this.DrawBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // greypanel
            // 
            this.greypanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.greypanel.Controls.Add(this.DrawBox);
            this.greypanel.Controls.Add(this.menuStrip1);
            this.greypanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.greypanel.Location = new System.Drawing.Point(0, 0);
            this.greypanel.Name = "greypanel";
            this.greypanel.Size = new System.Drawing.Size(815, 184);
            this.greypanel.TabIndex = 0;
            // 
            // DrawBox
            // 
            this.DrawBox.Controls.Add(this.SettingsB);
            this.DrawBox.Controls.Add(this.EllB);
            this.DrawBox.Controls.Add(this.RecB);
            this.DrawBox.Controls.Add(this.LineB);
            this.DrawBox.Location = new System.Drawing.Point(49, 63);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(250, 121);
            this.DrawBox.TabIndex = 1;
            this.DrawBox.TabStop = false;
            this.DrawBox.Text = "Draw";
            // 
            // SettingsB
            // 
            this.SettingsB.Location = new System.Drawing.Point(163, 50);
            this.SettingsB.Name = "SettingsB";
            this.SettingsB.Size = new System.Drawing.Size(75, 35);
            this.SettingsB.TabIndex = 3;
            this.SettingsB.Text = "Settings";
            this.SettingsB.UseVisualStyleBackColor = true;
            this.SettingsB.Click += new System.EventHandler(this.SettingsB_Click);
            // 
            // EllB
            // 
            this.EllB.AutoSize = true;
            this.EllB.Location = new System.Drawing.Point(7, 78);
            this.EllB.Name = "EllB";
            this.EllB.Size = new System.Drawing.Size(70, 21);
            this.EllB.TabIndex = 2;
            this.EllB.TabStop = true;
            this.EllB.Text = "Ellipse";
            this.EllB.UseVisualStyleBackColor = true;
            // 
            // RecB
            // 
            this.RecB.AutoSize = true;
            this.RecB.Location = new System.Drawing.Point(7, 50);
            this.RecB.Name = "RecB";
            this.RecB.Size = new System.Drawing.Size(93, 21);
            this.RecB.TabIndex = 1;
            this.RecB.TabStop = true;
            this.RecB.Text = "Rectangle";
            this.RecB.UseVisualStyleBackColor = true;
            // 
            // LineB
            // 
            this.LineB.AutoSize = true;
            this.LineB.Location = new System.Drawing.Point(7, 22);
            this.LineB.Name = "LineB";
            this.LineB.Size = new System.Drawing.Size(56, 21);
            this.LineB.TabIndex = 0;
            this.LineB.TabStop = true;
            this.LineB.Text = "Line";
            this.LineB.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // drawpad
            // 
            this.drawpad.Location = new System.Drawing.Point(0, 181);
            this.drawpad.Name = "drawpad";
            this.drawpad.Size = new System.Drawing.Size(815, 372);
            this.drawpad.TabIndex = 1;
            this.drawpad.Paint += new System.Windows.Forms.PaintEventHandler(this.drawpad_Paint);
            this.drawpad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawpad_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 554);
            this.Controls.Add(this.drawpad);
            this.Controls.Add(this.greypanel);
            this.Name = "Form1";
            this.Text = "Lab 6 made by Biyao Liang";
            this.greypanel.ResumeLayout(false);
            this.greypanel.PerformLayout();
            this.DrawBox.ResumeLayout(false);
            this.DrawBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel greypanel;
        private System.Windows.Forms.GroupBox DrawBox;
        private System.Windows.Forms.Button SettingsB;
        private System.Windows.Forms.RadioButton EllB;
        private System.Windows.Forms.RadioButton RecB;
        private System.Windows.Forms.RadioButton LineB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.Panel drawpad;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

