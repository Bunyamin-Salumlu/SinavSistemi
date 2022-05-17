
namespace SinavSistemi
{
    partial class FrmSifreGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifreGuncelleme));
            this.lblSGKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSGSifre = new System.Windows.Forms.Label();
            this.lblSGSifreTekrar = new System.Windows.Forms.Label();
            this.txtbxSGKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtbxSGSifre = new System.Windows.Forms.TextBox();
            this.txtbxSGSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnSGGuncelle = new System.Windows.Forms.Button();
            this.pctrbxSGGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSGGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSGKullaniciAdi
            // 
            this.lblSGKullaniciAdi.AutoSize = true;
            this.lblSGKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSGKullaniciAdi.Location = new System.Drawing.Point(85, 30);
            this.lblSGKullaniciAdi.Name = "lblSGKullaniciAdi";
            this.lblSGKullaniciAdi.Size = new System.Drawing.Size(85, 13);
            this.lblSGKullaniciAdi.TabIndex = 0;
            this.lblSGKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblSGSifre
            // 
            this.lblSGSifre.AutoSize = true;
            this.lblSGSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSGSifre.Location = new System.Drawing.Point(129, 65);
            this.lblSGSifre.Name = "lblSGSifre";
            this.lblSGSifre.Size = new System.Drawing.Size(41, 13);
            this.lblSGSifre.TabIndex = 1;
            this.lblSGSifre.Text = "Şifre :";
            // 
            // lblSGSifreTekrar
            // 
            this.lblSGSifreTekrar.AutoSize = true;
            this.lblSGSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSGSifreTekrar.Location = new System.Drawing.Point(88, 100);
            this.lblSGSifreTekrar.Name = "lblSGSifreTekrar";
            this.lblSGSifreTekrar.Size = new System.Drawing.Size(82, 13);
            this.lblSGSifreTekrar.TabIndex = 2;
            this.lblSGSifreTekrar.Text = "Şifre Tekrar :";
            // 
            // txtbxSGKullaniciAdi
            // 
            this.txtbxSGKullaniciAdi.Location = new System.Drawing.Point(176, 27);
            this.txtbxSGKullaniciAdi.Name = "txtbxSGKullaniciAdi";
            this.txtbxSGKullaniciAdi.Size = new System.Drawing.Size(126, 20);
            this.txtbxSGKullaniciAdi.TabIndex = 3;
            // 
            // txtbxSGSifre
            // 
            this.txtbxSGSifre.Location = new System.Drawing.Point(176, 62);
            this.txtbxSGSifre.Name = "txtbxSGSifre";
            this.txtbxSGSifre.PasswordChar = '●';
            this.txtbxSGSifre.Size = new System.Drawing.Size(126, 20);
            this.txtbxSGSifre.TabIndex = 4;
            // 
            // txtbxSGSifreTekrar
            // 
            this.txtbxSGSifreTekrar.Location = new System.Drawing.Point(176, 97);
            this.txtbxSGSifreTekrar.Name = "txtbxSGSifreTekrar";
            this.txtbxSGSifreTekrar.PasswordChar = '●';
            this.txtbxSGSifreTekrar.Size = new System.Drawing.Size(126, 20);
            this.txtbxSGSifreTekrar.TabIndex = 5;
            // 
            // btnSGGuncelle
            // 
            this.btnSGGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSGGuncelle.Location = new System.Drawing.Point(176, 134);
            this.btnSGGuncelle.Name = "btnSGGuncelle";
            this.btnSGGuncelle.Size = new System.Drawing.Size(95, 33);
            this.btnSGGuncelle.TabIndex = 6;
            this.btnSGGuncelle.Text = "Güncelle";
            this.btnSGGuncelle.UseVisualStyleBackColor = true;
            this.btnSGGuncelle.Click += new System.EventHandler(this.btnSGGuncelle_Click);
            // 
            // pctrbxSGGeri
            // 
            this.pctrbxSGGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxSGGeri.Image")));
            this.pctrbxSGGeri.Location = new System.Drawing.Point(12, 12);
            this.pctrbxSGGeri.Name = "pctrbxSGGeri";
            this.pctrbxSGGeri.Size = new System.Drawing.Size(40, 30);
            this.pctrbxSGGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxSGGeri.TabIndex = 7;
            this.pctrbxSGGeri.TabStop = false;
            this.pctrbxSGGeri.Click += new System.EventHandler(this.pctrbxSGGeri_Click);
            // 
            // FrmSifreGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 186);
            this.Controls.Add(this.pctrbxSGGeri);
            this.Controls.Add(this.btnSGGuncelle);
            this.Controls.Add(this.txtbxSGSifreTekrar);
            this.Controls.Add(this.txtbxSGSifre);
            this.Controls.Add(this.txtbxSGKullaniciAdi);
            this.Controls.Add(this.lblSGSifreTekrar);
            this.Controls.Add(this.lblSGSifre);
            this.Controls.Add(this.lblSGKullaniciAdi);
            this.Name = "FrmSifreGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifre Güncelleme";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSGGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSGKullaniciAdi;
        private System.Windows.Forms.Label lblSGSifre;
        private System.Windows.Forms.Label lblSGSifreTekrar;
        private System.Windows.Forms.TextBox txtbxSGKullaniciAdi;
        private System.Windows.Forms.TextBox txtbxSGSifre;
        private System.Windows.Forms.TextBox txtbxSGSifreTekrar;
        private System.Windows.Forms.Button btnSGGuncelle;
        private System.Windows.Forms.PictureBox pctrbxSGGeri;
    }
}