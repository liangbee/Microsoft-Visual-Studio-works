namespace lab6
{
    partial class Settings
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
            this.pcBox = new System.Windows.Forms.ListBox();
            this.fcBox = new System.Windows.Forms.ListBox();
            this.pwBox = new System.Windows.Forms.ListBox();
            this.fillCB = new System.Windows.Forms.CheckBox();
            this.OBox = new System.Windows.Forms.CheckBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pcBox
            // 
            this.pcBox.FormattingEnabled = true;
            this.pcBox.ItemHeight = 16;
            this.pcBox.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.pcBox.Location = new System.Drawing.Point(26, 109);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(78, 84);
            this.pcBox.TabIndex = 0;
            // 
            // fcBox
            // 
            this.fcBox.FormattingEnabled = true;
            this.fcBox.ItemHeight = 16;
            this.fcBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.fcBox.Location = new System.Drawing.Point(140, 109);
            this.fcBox.Name = "fcBox";
            this.fcBox.Size = new System.Drawing.Size(59, 84);
            this.fcBox.TabIndex = 1;
            // 
            // pwBox
            // 
            this.pwBox.FormattingEnabled = true;
            this.pwBox.ItemHeight = 16;
            this.pwBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.pwBox.Location = new System.Drawing.Point(248, 109);
            this.pwBox.Name = "pwBox";
            this.pwBox.Size = new System.Drawing.Size(130, 164);
            this.pwBox.TabIndex = 2;
            // 
            // fillCB
            // 
            this.fillCB.AutoSize = true;
            this.fillCB.Location = new System.Drawing.Point(57, 313);
            this.fillCB.Name = "fillCB";
            this.fillCB.Size = new System.Drawing.Size(47, 21);
            this.fillCB.TabIndex = 3;
            this.fillCB.Text = "Fill";
            this.fillCB.UseVisualStyleBackColor = true;
            // 
            // OBox
            // 
            this.OBox.AutoSize = true;
            this.OBox.Location = new System.Drawing.Point(57, 340);
            this.OBox.Name = "OBox";
            this.OBox.Size = new System.Drawing.Size(75, 21);
            this.OBox.TabIndex = 4;
            this.OBox.Text = "Outline";
            this.OBox.UseVisualStyleBackColor = true;
            // 
            // OKbutton
            // 
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Location = new System.Drawing.Point(176, 375);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 5;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // cancelB
            // 
            this.cancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelB.Location = new System.Drawing.Point(303, 375);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 6;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pen Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fill Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pen Width";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 420);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.OBox);
            this.Controls.Add(this.fillCB);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.fcBox);
            this.Controls.Add(this.pcBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pcBox;
        private System.Windows.Forms.ListBox fcBox;
        private System.Windows.Forms.ListBox pwBox;
        private System.Windows.Forms.CheckBox fillCB;
        private System.Windows.Forms.CheckBox OBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}