namespace Lab5
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
            this.label1 = new System.Windows.Forms.Label();
            this.EnterL = new System.Windows.Forms.Label();
            this.StartInt = new System.Windows.Forms.TextBox();
            this.CountL = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.GenerateB = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.Comment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Numeric Palindromes";
            // 
            // EnterL
            // 
            this.EnterL.AutoSize = true;
            this.EnterL.Location = new System.Drawing.Point(103, 140);
            this.EnterL.Name = "EnterL";
            this.EnterL.Size = new System.Drawing.Size(272, 17);
            this.EnterL.TabIndex = 1;
            this.EnterL.Text = "Enter a starting integer(0-1,000,000,000):";
            // 
            // StartInt
            // 
            this.StartInt.Location = new System.Drawing.Point(379, 139);
            this.StartInt.Name = "StartInt";
            this.StartInt.Size = new System.Drawing.Size(165, 22);
            this.StartInt.TabIndex = 2;
            // 
            // CountL
            // 
            this.CountL.AutoSize = true;
            this.CountL.Location = new System.Drawing.Point(553, 140);
            this.CountL.Name = "CountL";
            this.CountL.Size = new System.Drawing.Size(132, 17);
            this.CountL.TabIndex = 3;
            this.CountL.Text = "Enter count(1-100):";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(684, 139);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(158, 22);
            this.Count.TabIndex = 4;
            // 
            // GenerateB
            // 
            this.GenerateB.Location = new System.Drawing.Point(489, 191);
            this.GenerateB.Name = "GenerateB";
            this.GenerateB.Size = new System.Drawing.Size(118, 28);
            this.GenerateB.TabIndex = 5;
            this.GenerateB.Text = "Generate";
            this.GenerateB.UseVisualStyleBackColor = true;
            this.GenerateB.Click += new System.EventHandler(this.GenerateB_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.ItemHeight = 16;
            this.ResultBox.Location = new System.Drawing.Point(463, 238);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(173, 164);
            this.ResultBox.TabIndex = 6;
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Location = new System.Drawing.Point(445, 420);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(0, 17);
            this.Comment.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 538);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.GenerateB);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.CountL);
            this.Controls.Add(this.StartInt);
            this.Controls.Add(this.EnterL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Palindromes by Biyao Liang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EnterL;
        private System.Windows.Forms.TextBox StartInt;
        private System.Windows.Forms.Label CountL;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Button GenerateB;
        private System.Windows.Forms.ListBox ResultBox;
        private System.Windows.Forms.Label Comment;
    }
}

