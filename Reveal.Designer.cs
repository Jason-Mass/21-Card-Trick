
namespace _21_Card_Trick
{
    partial class Reveal
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
            this.pbxReveal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReveal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxReveal
            // 
            this.pbxReveal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxReveal.BackgroundImage = global::_21_Card_Trick.Properties.Resources.Backing;
            this.pbxReveal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxReveal.Location = new System.Drawing.Point(277, 82);
            this.pbxReveal.Name = "pbxReveal";
            this.pbxReveal.Size = new System.Drawing.Size(273, 394);
            this.pbxReveal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxReveal.TabIndex = 0;
            this.pbxReveal.TabStop = false;
            this.pbxReveal.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Reveal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(829, 578);
            this.Controls.Add(this.pbxReveal);
            this.Name = "Reveal";
            this.Text = "Reveal";
            ((System.ComponentModel.ISupportInitialize)(this.pbxReveal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxReveal;
    }
}