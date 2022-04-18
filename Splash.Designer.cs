
namespace _21_Card_Trick
{
    partial class Splash
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
            this.txt_Title1 = new System.Windows.Forms.TextBox();
            this.txt_Title2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Title1
            // 
            this.txt_Title1.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_Title1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Title1.Font = new System.Drawing.Font("Old English Text MT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Title1.Location = new System.Drawing.Point(187, 138);
            this.txt_Title1.Name = "txt_Title1";
            this.txt_Title1.ReadOnly = true;
            this.txt_Title1.Size = new System.Drawing.Size(428, 53);
            this.txt_Title1.TabIndex = 4;
            this.txt_Title1.TabStop = false;
            this.txt_Title1.Text = "21 Cards";
            this.txt_Title1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Title2
            // 
            this.txt_Title2.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Title2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Title2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_Title2.Location = new System.Drawing.Point(64, 229);
            this.txt_Title2.Name = "txt_Title2";
            this.txt_Title2.ReadOnly = true;
            this.txt_Title2.Size = new System.Drawing.Size(672, 28);
            this.txt_Title2.TabIndex = 5;
            this.txt_Title2.TabStop = false;
            this.txt_Title2.Text = "The Ultimate Artificial Intelligence Application ";
            this.txt_Title2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::_21_Card_Trick.Properties.Resources.Splash_Deck;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 324);
            this.Controls.Add(this.txt_Title2);
            this.Controls.Add(this.txt_Title1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Shown += new System.EventHandler(this.Splash_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Title1;
        private System.Windows.Forms.TextBox txt_Title2;
    }
}