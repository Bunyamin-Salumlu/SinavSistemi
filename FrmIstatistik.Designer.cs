
namespace SinavSistemi
{
    partial class FrmIstatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIstatistik));
            this.pctrbxIGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxIGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxIGeri
            // 
            this.pctrbxIGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxIGeri.Image")));
            this.pctrbxIGeri.Location = new System.Drawing.Point(12, 12);
            this.pctrbxIGeri.Name = "pctrbxIGeri";
            this.pctrbxIGeri.Size = new System.Drawing.Size(40, 30);
            this.pctrbxIGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxIGeri.TabIndex = 3;
            this.pctrbxIGeri.TabStop = false;
            this.pctrbxIGeri.Click += new System.EventHandler(this.pctrbxIGeri_Click);
            // 
            // FrmIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 316);
            this.Controls.Add(this.pctrbxIGeri);
            this.Name = "FrmIstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistik";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxIGeri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxIGeri;
    }
}