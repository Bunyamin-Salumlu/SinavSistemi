
namespace SinavSistemi
{
    partial class FrmSorumluSayfasi
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
            this.btnSSoruEkle = new System.Windows.Forms.Button();
            this.btnSBilgileriniGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSSoruEkle
            // 
            this.btnSSoruEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSSoruEkle.Location = new System.Drawing.Point(51, 117);
            this.btnSSoruEkle.Name = "btnSSoruEkle";
            this.btnSSoruEkle.Size = new System.Drawing.Size(120, 50);
            this.btnSSoruEkle.TabIndex = 0;
            this.btnSSoruEkle.Text = "Soru Ekle";
            this.btnSSoruEkle.UseVisualStyleBackColor = true;
            this.btnSSoruEkle.Click += new System.EventHandler(this.btnSSoruEkle_Click);
            // 
            // btnSBilgileriniGor
            // 
            this.btnSBilgileriniGor.Location = new System.Drawing.Point(51, 40);
            this.btnSBilgileriniGor.Name = "btnSBilgileriniGor";
            this.btnSBilgileriniGor.Size = new System.Drawing.Size(120, 51);
            this.btnSBilgileriniGor.TabIndex = 1;
            this.btnSBilgileriniGor.Text = "Bilgilerini Gör";
            this.btnSBilgileriniGor.UseVisualStyleBackColor = true;
            // 
            // FrmSorumluSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 229);
            this.Controls.Add(this.btnSBilgileriniGor);
            this.Controls.Add(this.btnSSoruEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmSorumluSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorumlu Sayfası";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSSoruEkle;
        private System.Windows.Forms.Button btnSBilgileriniGor;
    }
}