namespace CvEv3
{
    partial class CvE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CvE));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.legCheckBox = new System.Windows.Forms.CheckBox();
            this.finCheckBox = new System.Windows.Forms.CheckBox();
            this.medCheckBox = new System.Windows.Forms.CheckBox();
            this.markCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 208);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(461, 229);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enhance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // legCheckBox
            // 
            this.legCheckBox.AutoSize = true;
            this.legCheckBox.Location = new System.Drawing.Point(13, 78);
            this.legCheckBox.Name = "legCheckBox";
            this.legCheckBox.Size = new System.Drawing.Size(52, 17);
            this.legCheckBox.TabIndex = 2;
            this.legCheckBox.Tag = "";
            this.legCheckBox.Text = "Legal";
            this.legCheckBox.UseVisualStyleBackColor = true;
            // 
            // finCheckBox
            // 
            this.finCheckBox.AutoSize = true;
            this.finCheckBox.Location = new System.Drawing.Point(13, 102);
            this.finCheckBox.Name = "finCheckBox";
            this.finCheckBox.Size = new System.Drawing.Size(68, 17);
            this.finCheckBox.TabIndex = 3;
            this.finCheckBox.Text = "Financial";
            this.finCheckBox.UseVisualStyleBackColor = true;
            // 
            // medCheckBox
            // 
            this.medCheckBox.AutoSize = true;
            this.medCheckBox.Location = new System.Drawing.Point(13, 126);
            this.medCheckBox.Name = "medCheckBox";
            this.medCheckBox.Size = new System.Drawing.Size(63, 17);
            this.medCheckBox.TabIndex = 4;
            this.medCheckBox.Text = "Medical";
            this.medCheckBox.UseVisualStyleBackColor = true;
            // 
            // markCheckBox
            // 
            this.markCheckBox.AutoSize = true;
            this.markCheckBox.Location = new System.Drawing.Point(12, 150);
            this.markCheckBox.Name = "markCheckBox";
            this.markCheckBox.Size = new System.Drawing.Size(73, 17);
            this.markCheckBox.TabIndex = 5;
            this.markCheckBox.Text = "Marketing";
            this.markCheckBox.UseVisualStyleBackColor = true;
            // 
            // CvE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 486);
            this.Controls.Add(this.markCheckBox);
            this.Controls.Add(this.medCheckBox);
            this.Controls.Add(this.finCheckBox);
            this.Controls.Add(this.legCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CvE";
            this.Text = "CvE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox legCheckBox;
        private System.Windows.Forms.CheckBox finCheckBox;
        private System.Windows.Forms.CheckBox medCheckBox;
        private System.Windows.Forms.CheckBox markCheckBox;

    }
}

