namespace Lab4
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
            this.HintB = new System.Windows.Forms.CheckBox();
            this.ClearB = new System.Windows.Forms.Button();
            this.MessB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HintB
            // 
            this.HintB.AutoSize = true;
            this.HintB.Location = new System.Drawing.Point(35, 46);
            this.HintB.Name = "HintB";
            this.HintB.Size = new System.Drawing.Size(55, 21);
            this.HintB.TabIndex = 0;
            this.HintB.Text = "Hint";
            this.HintB.UseVisualStyleBackColor = true;
            this.HintB.CheckedChanged += new System.EventHandler(this.HintB_CheckedChanged);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(120, 46);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(75, 23);
            this.ClearB.TabIndex = 1;
            this.ClearB.Text = "Clear";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // MessB
            // 
            this.MessB.AutoSize = true;
            this.MessB.Location = new System.Drawing.Point(240, 51);
            this.MessB.Name = "MessB";
            this.MessB.Size = new System.Drawing.Size(46, 17);
            this.MessB.TabIndex = 2;
            this.MessB.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 753);
            this.Controls.Add(this.MessB);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.HintB);
            this.Name = "Form1";
            this.Text = "Eight Queens by Biyao Liang";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox HintB;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.Label MessB;
    }
}

