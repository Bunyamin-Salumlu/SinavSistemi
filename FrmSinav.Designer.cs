
namespace SinavSistemi
{
    partial class FrmSinav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinav));
            this.pctrbxSinavGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSinavGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxSinavGeri
            // 
            this.pctrbxSinavGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxSinavGeri.Image")));
            this.pctrbxSinavGeri.Location = new System.Drawing.Point(12, 12);
            this.pctrbxSinavGeri.Name = "pctrbxSinavGeri";
            this.pctrbxSinavGeri.Size = new System.Drawing.Size(40, 30);
            this.pctrbxSinavGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxSinavGeri.TabIndex = 2;
            this.pctrbxSinavGeri.TabStop = false;
            this.pctrbxSinavGeri.Click += new System.EventHandler(this.pctrbxSinavGeri_Click);
            // 
            // FrmSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 384);
            this.Controls.Add(this.pctrbxSinavGeri);
            this.Name = "FrmSinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSinavGeri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxSinavGeri;
    }
}