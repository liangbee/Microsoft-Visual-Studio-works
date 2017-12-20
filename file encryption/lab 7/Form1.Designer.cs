namespace lab_7
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
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // FilePathBox
            // 
            this.FilePathBox.Location = new System.Drawing.Point(69, 85);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(338, 22);
            this.FilePathBox.TabIndex = 1;
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(66, 143);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(36, 17);
            this.Key.TabIndex = 2;
            this.Key.Text = "Key:";
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(69, 178);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(136, 22);
            this.KeyBox.TabIndex = 3;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(69, 241);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 27);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(196, 241);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 27);
            this.DecryptButton.TabIndex = 5;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // FileButton
            // 
            this.FileButton.BackgroundImage = global::lab_7.Properties.Resources.OpenPH;
            this.FileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FileButton.Location = new System.Drawing.Point(423, 70);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(55, 52);
            this.FileButton.TabIndex = 6;
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 321);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "File Encrypt/ Decrypt by Biyao Liang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button FileButton;
    }
}

