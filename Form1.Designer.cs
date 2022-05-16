
namespace SinavSistemi
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtbxSifre = new System.Windows.Forms.TextBox();
            this.cmbxKullaniciTipi = new System.Windows.Forms.ComboBox();
            this.lblGirisTipi = new System.Windows.Forms.Label();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.pctrbxGiriLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGiriLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(31, 176);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(71, 211);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(31, 13);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(12, 240);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(90, 37);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(108, 240);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(90, 37);
            this.btnKayitOl.TabIndex = 3;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtbxKullaniciAdi
            // 
            this.txtbxKullaniciAdi.Location = new System.Drawing.Point(108, 173);
            this.txtbxKullaniciAdi.Name = "txtbxKullaniciAdi";
            this.txtbxKullaniciAdi.Size = new System.Drawing.Size(121, 20);
            this.txtbxKullaniciAdi.TabIndex = 4;
            // 
            // txtbxSifre
            // 
            this.txtbxSifre.Location = new System.Drawing.Point(108, 208);
            this.txtbxSifre.Name = "txtbxSifre";
            this.txtbxSifre.PasswordChar = '●';
            this.txtbxSifre.Size = new System.Drawing.Size(121, 20);
            this.txtbxSifre.TabIndex = 5;
            // 
            // cmbxKullaniciTipi
            // 
            this.cmbxKullaniciTipi.FormattingEnabled = true;
            this.cmbxKullaniciTipi.Items.AddRange(new object[] {
            "Admin",
            "Sorumlu",
            "Ogrenci"});
            this.cmbxKullaniciTipi.Location = new System.Drawing.Point(108, 137);
            this.cmbxKullaniciTipi.Name = "cmbxKullaniciTipi";
            this.cmbxKullaniciTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbxKullaniciTipi.TabIndex = 6;
            // 
            // lblGirisTipi
            // 
            this.lblGirisTipi.AutoSize = true;
            this.lblGirisTipi.Location = new System.Drawing.Point(33, 140);
            this.lblGirisTipi.Name = "lblGirisTipi";
            this.lblGirisTipi.Size = new System.Drawing.Size(69, 13);
            this.lblGirisTipi.TabIndex = 7;
            this.lblGirisTipi.Text = "Kullanıcı Tipi:";
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(204, 240);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(90, 37);
            this.btnSifremiUnuttum.TabIndex = 8;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = true;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // pctrbxGiriLogo
            // 
            this.pctrbxGiriLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGiriLogo.Image")));
            this.pctrbxGiriLogo.Location = new System.Drawing.Point(60, 12);
            this.pctrbxGiriLogo.Name = "pctrbxGiriLogo";
            this.pctrbxGiriLogo.Size = new System.Drawing.Size(185, 110);
            this.pctrbxGiriLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxGiriLogo.TabIndex = 9;
            this.pctrbxGiriLogo.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 292);
            this.Controls.Add(this.pctrbxGiriLogo);
            this.Controls.Add(this.btnSifremiUnuttum);
            this.Controls.Add(this.lblGirisTipi);
            this.Controls.Add(this.cmbxKullaniciTipi);
            this.Controls.Add(this.txtbxSifre);
            this.Controls.Add(this.txtbxKullaniciAdi);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGiriLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtbxKullaniciAdi;
        private System.Windows.Forms.TextBox txtbxSifre;
        private System.Windows.Forms.ComboBox cmbxKullaniciTipi;
        private System.Windows.Forms.Label lblGirisTipi;
        private System.Windows.Forms.Button btnSifremiUnuttum;
        private System.Windows.Forms.PictureBox pctrbxGiriLogo;
    }
}

