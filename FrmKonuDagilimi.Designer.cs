
namespace SinavSistemi
{
    partial class FrmKonuDagilimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKonuDagilimi));
            this.pctrbxKonuDagilimi = new System.Windows.Forms.PictureBox();
            this.pctrbxKDGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxKonuDagilimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxKDGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxKonuDagilimi
            // 
            this.pctrbxKonuDagilimi.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxKonuDagilimi.Image")));
            this.pctrbxKonuDagilimi.Location = new System.Drawing.Point(96, 12);
            this.pctrbxKonuDagilimi.Name = "pctrbxKonuDagilimi";
            this.pctrbxKonuDagilimi.Size = new System.Drawing.Size(237, 509);
            this.pctrbxKonuDagilimi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctrbxKonuDagilimi.TabIndex = 0;
            this.pctrbxKonuDagilimi.TabStop = false;
            // 
            // pctrbxKDGeri
            // 
            this.pctrbxKDGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxKDGeri.Image")));
            this.pctrbxKDGeri.Location = new System.Drawing.Point(12, 12);
            this.pctrbxKDGeri.Name = "pctrbxKDGeri";
            this.pctrbxKDGeri.Size = new System.Drawing.Size(40, 30);
            this.pctrbxKDGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxKDGeri.TabIndex = 1;
            this.pctrbxKDGeri.TabStop = false;
            this.pctrbxKDGeri.Click += new System.EventHandler(this.pctrbxGeri_Click);
            // 
            // FrmKonuDagilimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 531);
            this.Controls.Add(this.pctrbxKDGeri);
            this.Controls.Add(this.pctrbxKonuDagilimi);
            this.Name = "FrmKonuDagilimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konu Dağılımı";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxKonuDagilimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxKDGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxKonuDagilimi;
        private System.Windows.Forms.PictureBox pctrbxKDGeri;
    }
}