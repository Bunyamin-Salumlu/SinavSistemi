
namespace SinavSistemi
{
    partial class FrmKayitOl
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
            this.lblKAd = new System.Windows.Forms.Label();
            this.lblKSifre = new System.Windows.Forms.Label();
            this.btnKKaydet = new System.Windows.Forms.Button();
            this.txtbxKAd = new System.Windows.Forms.TextBox();
            this.txtbxKSifre = new System.Windows.Forms.TextBox();
            this.lblKGirisTipi = new System.Windows.Forms.Label();
            this.cmbxKKullaniciTipi = new System.Windows.Forms.ComboBox();
            this.lblKSoyad = new System.Windows.Forms.Label();
            this.txtbxKSoyad = new System.Windows.Forms.TextBox();
            this.lblKKullaniciAdi = new System.Windows.Forms.Label();
            this.txtbxKKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKMail = new System.Windows.Forms.Label();
            this.txtbxKMail = new System.Windows.Forms.TextBox();
            this.lblKTckNo = new System.Windows.Forms.Label();
            this.txtbxKTckNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKAd
            // 
            this.lblKAd.AutoSize = true;
            this.lblKAd.Location = new System.Drawing.Point(59, 136);
            this.lblKAd.Name = "lblKAd";
            this.lblKAd.Size = new System.Drawing.Size(26, 13);
            this.lblKAd.TabIndex = 0;
            this.lblKAd.Text = "Ad :";
            // 
            // lblKSifre
            // 
            this.lblKSifre.AutoSize = true;
            this.lblKSifre.Location = new System.Drawing.Point(51, 253);
            this.lblKSifre.Name = "lblKSifre";
            this.lblKSifre.Size = new System.Drawing.Size(34, 13);
            this.lblKSifre.TabIndex = 1;
            this.lblKSifre.Text = "Şifre :";
            // 
            // btnKKaydet
            // 
            this.btnKKaydet.Location = new System.Drawing.Point(105, 286);
            this.btnKKaydet.Name = "btnKKaydet";
            this.btnKKaydet.Size = new System.Drawing.Size(88, 44);
            this.btnKKaydet.TabIndex = 3;
            this.btnKKaydet.Text = "Kaydet";
            this.btnKKaydet.UseVisualStyleBackColor = true;
            this.btnKKaydet.Click += new System.EventHandler(this.btnKKaydet_Click);
            // 
            // txtbxKAd
            // 
            this.txtbxKAd.Location = new System.Drawing.Point(91, 133);
            this.txtbxKAd.Name = "txtbxKAd";
            this.txtbxKAd.Size = new System.Drawing.Size(121, 20);
            this.txtbxKAd.TabIndex = 4;
            // 
            // txtbxKSifre
            // 
            this.txtbxKSifre.Location = new System.Drawing.Point(91, 250);
            this.txtbxKSifre.Name = "txtbxKSifre";
            this.txtbxKSifre.Size = new System.Drawing.Size(121, 20);
            this.txtbxKSifre.TabIndex = 5;
            // 
            // lblKGirisTipi
            // 
            this.lblKGirisTipi.AutoSize = true;
            this.lblKGirisTipi.Location = new System.Drawing.Point(13, 22);
            this.lblKGirisTipi.Name = "lblKGirisTipi";
            this.lblKGirisTipi.Size = new System.Drawing.Size(72, 13);
            this.lblKGirisTipi.TabIndex = 9;
            this.lblKGirisTipi.Text = "Kullanıcı Tipi :";
            // 
            // cmbxKKullaniciTipi
            // 
            this.cmbxKKullaniciTipi.FormattingEnabled = true;
            this.cmbxKKullaniciTipi.Items.AddRange(new object[] {
            "Admin",
            "Sorumlu",
            "Ogrenci"});
            this.cmbxKKullaniciTipi.Location = new System.Drawing.Point(91, 19);
            this.cmbxKKullaniciTipi.Name = "cmbxKKullaniciTipi";
            this.cmbxKKullaniciTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbxKKullaniciTipi.TabIndex = 8;
            // 
            // lblKSoyad
            // 
            this.lblKSoyad.AutoSize = true;
            this.lblKSoyad.Location = new System.Drawing.Point(42, 171);
            this.lblKSoyad.Name = "lblKSoyad";
            this.lblKSoyad.Size = new System.Drawing.Size(43, 13);
            this.lblKSoyad.TabIndex = 10;
            this.lblKSoyad.Text = "Soyad :";
            // 
            // txtbxKSoyad
            // 
            this.txtbxKSoyad.Location = new System.Drawing.Point(91, 168);
            this.txtbxKSoyad.Name = "txtbxKSoyad";
            this.txtbxKSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtbxKSoyad.TabIndex = 11;
            // 
            // lblKKullaniciAdi
            // 
            this.lblKKullaniciAdi.AutoSize = true;
            this.lblKKullaniciAdi.Location = new System.Drawing.Point(15, 101);
            this.lblKKullaniciAdi.Name = "lblKKullaniciAdi";
            this.lblKKullaniciAdi.Size = new System.Drawing.Size(70, 13);
            this.lblKKullaniciAdi.TabIndex = 12;
            this.lblKKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // txtbxKKullaniciAdi
            // 
            this.txtbxKKullaniciAdi.Location = new System.Drawing.Point(91, 98);
            this.txtbxKKullaniciAdi.Name = "txtbxKKullaniciAdi";
            this.txtbxKKullaniciAdi.Size = new System.Drawing.Size(121, 20);
            this.txtbxKKullaniciAdi.TabIndex = 13;
            // 
            // lblKMail
            // 
            this.lblKMail.AutoSize = true;
            this.lblKMail.Location = new System.Drawing.Point(53, 212);
            this.lblKMail.Name = "lblKMail";
            this.lblKMail.Size = new System.Drawing.Size(32, 13);
            this.lblKMail.TabIndex = 14;
            this.lblKMail.Text = "Mail :";
            // 
            // txtbxKMail
            // 
            this.txtbxKMail.Location = new System.Drawing.Point(91, 209);
            this.txtbxKMail.Name = "txtbxKMail";
            this.txtbxKMail.Size = new System.Drawing.Size(121, 20);
            this.txtbxKMail.TabIndex = 15;
            // 
            // lblKTckNo
            // 
            this.lblKTckNo.AutoSize = true;
            this.lblKTckNo.Location = new System.Drawing.Point(12, 58);
            this.lblKTckNo.Name = "lblKTckNo";
            this.lblKTckNo.Size = new System.Drawing.Size(73, 13);
            this.lblKTckNo.TabIndex = 16;
            this.lblKTckNo.Text = "Tc Kimlik No :";
            // 
            // txtbxKTckNo
            // 
            this.txtbxKTckNo.Location = new System.Drawing.Point(91, 55);
            this.txtbxKTckNo.Name = "txtbxKTckNo";
            this.txtbxKTckNo.Size = new System.Drawing.Size(121, 20);
            this.txtbxKTckNo.TabIndex = 17;
            // 
            // FrmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 345);
            this.Controls.Add(this.txtbxKTckNo);
            this.Controls.Add(this.lblKTckNo);
            this.Controls.Add(this.txtbxKMail);
            this.Controls.Add(this.lblKMail);
            this.Controls.Add(this.txtbxKKullaniciAdi);
            this.Controls.Add(this.lblKKullaniciAdi);
            this.Controls.Add(this.txtbxKSoyad);
            this.Controls.Add(this.lblKSoyad);
            this.Controls.Add(this.lblKGirisTipi);
            this.Controls.Add(this.cmbxKKullaniciTipi);
            this.Controls.Add(this.txtbxKSifre);
            this.Controls.Add(this.txtbxKAd);
            this.Controls.Add(this.btnKKaydet);
            this.Controls.Add(this.lblKSifre);
            this.Controls.Add(this.lblKAd);
            this.Name = "FrmKayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKAd;
        private System.Windows.Forms.Label lblKSifre;
        private System.Windows.Forms.Button btnKKaydet;
        private System.Windows.Forms.TextBox txtbxKAd;
        private System.Windows.Forms.TextBox txtbxKSifre;
        private System.Windows.Forms.Label lblKGirisTipi;
        private System.Windows.Forms.ComboBox cmbxKKullaniciTipi;
        private System.Windows.Forms.Label lblKSoyad;
        private System.Windows.Forms.TextBox txtbxKSoyad;
        private System.Windows.Forms.Label lblKKullaniciAdi;
        private System.Windows.Forms.TextBox txtbxKKullaniciAdi;
        private System.Windows.Forms.Label lblKMail;
        private System.Windows.Forms.TextBox txtbxKMail;
        private System.Windows.Forms.Label lblKTckNo;
        private System.Windows.Forms.TextBox txtbxKTckNo;
    }
}