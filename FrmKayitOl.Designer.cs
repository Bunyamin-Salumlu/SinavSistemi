
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
            this.lblKAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKAd.Location = new System.Drawing.Point(59, 136);
            this.lblKAd.Name = "lblKAd";
            this.lblKAd.Size = new System.Drawing.Size(31, 15);
            this.lblKAd.TabIndex = 0;
            this.lblKAd.Text = "Ad :";
            // 
            // lblKSifre
            // 
            this.lblKSifre.AutoSize = true;
            this.lblKSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKSifre.Location = new System.Drawing.Point(51, 253);
            this.lblKSifre.Name = "lblKSifre";
            this.lblKSifre.Size = new System.Drawing.Size(45, 15);
            this.lblKSifre.TabIndex = 1;
            this.lblKSifre.Text = "Şifre :";
            // 
            // btnKKaydet
            // 
            this.btnKKaydet.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnKKaydet.Location = new System.Drawing.Point(118, 289);
            this.btnKKaydet.Name = "btnKKaydet";
            this.btnKKaydet.Size = new System.Drawing.Size(82, 45);
            this.btnKKaydet.TabIndex = 3;
            this.btnKKaydet.Text = "Kaydet";
            this.btnKKaydet.UseVisualStyleBackColor = false;
            this.btnKKaydet.Click += new System.EventHandler(this.btnKKaydet_Click);
            // 
            // txtbxKAd
            // 
            this.txtbxKAd.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxKAd.Location = new System.Drawing.Point(118, 135);
            this.txtbxKAd.Name = "txtbxKAd";
            this.txtbxKAd.Size = new System.Drawing.Size(121, 20);
            this.txtbxKAd.TabIndex = 4;
            // 
            // txtbxKSifre
            // 
            this.txtbxKSifre.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxKSifre.Location = new System.Drawing.Point(118, 252);
            this.txtbxKSifre.Name = "txtbxKSifre";
            this.txtbxKSifre.PasswordChar = '●';
            this.txtbxKSifre.Size = new System.Drawing.Size(121, 20);
            this.txtbxKSifre.TabIndex = 5;
            // 
            // lblKGirisTipi
            // 
            this.lblKGirisTipi.AutoSize = true;
            this.lblKGirisTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKGirisTipi.Location = new System.Drawing.Point(13, 22);
            this.lblKGirisTipi.Name = "lblKGirisTipi";
            this.lblKGirisTipi.Size = new System.Drawing.Size(99, 15);
            this.lblKGirisTipi.TabIndex = 9;
            this.lblKGirisTipi.Text = "Kullanıcı Tipi :";
            // 
            // cmbxKKullaniciTipi
            // 
            this.cmbxKKullaniciTipi.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxKKullaniciTipi.FormattingEnabled = true;
            this.cmbxKKullaniciTipi.Items.AddRange(new object[] {
            "Admin",
            "Sorumlu",
            "Ogrenci"});
            this.cmbxKKullaniciTipi.Location = new System.Drawing.Point(118, 21);
            this.cmbxKKullaniciTipi.Name = "cmbxKKullaniciTipi";
            this.cmbxKKullaniciTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbxKKullaniciTipi.TabIndex = 8;
            // 
            // lblKSoyad
            // 
            this.lblKSoyad.AutoSize = true;
            this.lblKSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKSoyad.Location = new System.Drawing.Point(42, 171);
            this.lblKSoyad.Name = "lblKSoyad";
            this.lblKSoyad.Size = new System.Drawing.Size(54, 15);
            this.lblKSoyad.TabIndex = 10;
            this.lblKSoyad.Text = "Soyad :";
            // 
            // txtbxKSoyad
            // 
            this.txtbxKSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxKSoyad.Location = new System.Drawing.Point(118, 170);
            this.txtbxKSoyad.Name = "txtbxKSoyad";
            this.txtbxKSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtbxKSoyad.TabIndex = 11;
            // 
            // lblKKullaniciAdi
            // 
            this.lblKKullaniciAdi.AutoSize = true;
            this.lblKKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKKullaniciAdi.Location = new System.Drawing.Point(15, 101);
            this.lblKKullaniciAdi.Name = "lblKKullaniciAdi";
            this.lblKKullaniciAdi.Size = new System.Drawing.Size(95, 15);
            this.lblKKullaniciAdi.TabIndex = 12;
            this.lblKKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // txtbxKKullaniciAdi
            // 
            this.txtbxKKullaniciAdi.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxKKullaniciAdi.Location = new System.Drawing.Point(118, 100);
            this.txtbxKKullaniciAdi.Name = "txtbxKKullaniciAdi";
            this.txtbxKKullaniciAdi.Size = new System.Drawing.Size(121, 20);
            this.txtbxKKullaniciAdi.TabIndex = 13;
            // 
            // lblKMail
            // 
            this.lblKMail.AutoSize = true;
            this.lblKMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKMail.Location = new System.Drawing.Point(53, 212);
            this.lblKMail.Name = "lblKMail";
            this.lblKMail.Size = new System.Drawing.Size(43, 15);
            this.lblKMail.TabIndex = 14;
            this.lblKMail.Text = "Mail :";
            // 
            // txtbxKMail
            // 
            this.txtbxKMail.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxKMail.Location = new System.Drawing.Point(118, 211);
            this.txtbxKMail.Name = "txtbxKMail";
            this.txtbxKMail.Size = new System.Drawing.Size(121, 20);
            this.txtbxKMail.TabIndex = 15;
            // 
            // lblKTckNo
            // 
            this.lblKTckNo.AutoSize = true;
            this.lblKTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKTckNo.Location = new System.Drawing.Point(12, 58);
            this.lblKTckNo.Name = "lblKTckNo";
            this.lblKTckNo.Size = new System.Drawing.Size(96, 15);
            this.lblKTckNo.TabIndex = 16;
            this.lblKTckNo.Text = "Tc Kimlik No :";
            // 
            // txtbxKTckNo
            // 
            this.txtbxKTckNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxKTckNo.Location = new System.Drawing.Point(118, 57);
            this.txtbxKTckNo.Name = "txtbxKTckNo";
            this.txtbxKTckNo.Size = new System.Drawing.Size(121, 20);
            this.txtbxKTckNo.TabIndex = 17;
            // 
            // FrmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(277, 350);
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
            this.Text = "Kayıt Ol";
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