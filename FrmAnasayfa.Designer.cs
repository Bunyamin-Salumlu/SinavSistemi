
namespace SinavSistemi
{
    partial class FrmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.txtbxSinavBilgi = new System.Windows.Forms.TextBox();
            this.lblSinavKural = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrpMnItmAnasayfa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpMnItmSinav = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpMnItmSinavGir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpMnItmIstatistik = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpMnItmSBilgi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpMnItmProfilim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpMnItmBilgilerim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpMnItmSiralama = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpMnItmAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpMnItmSifreDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpMnItmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.pctrbxALogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxALogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxSinavBilgi
            // 
            this.txtbxSinavBilgi.Enabled = false;
            this.txtbxSinavBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxSinavBilgi.Location = new System.Drawing.Point(82, 234);
            this.txtbxSinavBilgi.Multiline = true;
            this.txtbxSinavBilgi.Name = "txtbxSinavBilgi";
            this.txtbxSinavBilgi.Size = new System.Drawing.Size(369, 129);
            this.txtbxSinavBilgi.TabIndex = 0;
            this.txtbxSinavBilgi.Text = resources.GetString("txtbxSinavBilgi.Text");
            // 
            // lblSinavKural
            // 
            this.lblSinavKural.AutoSize = true;
            this.lblSinavKural.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavKural.Location = new System.Drawing.Point(79, 211);
            this.lblSinavKural.Name = "lblSinavKural";
            this.lblSinavKural.Size = new System.Drawing.Size(90, 16);
            this.lblSinavKural.TabIndex = 1;
            this.lblSinavKural.Text = "Sınav Kuralı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrpMnItmAnasayfa,
            this.toolStrpMnItmSinav,
            this.toolStrpMnItmProfilim,
            this.toolStrpMnItmSiralama,
            this.toolStrpMnItmAyarlar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrpMnItmAnasayfa
            // 
            this.toolStrpMnItmAnasayfa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrpMnItmAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmAnasayfa.Image")));
            this.toolStrpMnItmAnasayfa.Name = "toolStrpMnItmAnasayfa";
            this.toolStrpMnItmAnasayfa.Size = new System.Drawing.Size(92, 21);
            this.toolStrpMnItmAnasayfa.Text = "Anasayfa";
            this.toolStrpMnItmAnasayfa.Click += new System.EventHandler(this.toolStrpMnItmAnasayfa_Click);
            // 
            // toolStrpMnItmSinav
            // 
            this.toolStrpMnItmSinav.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrpMnItmSinavGir,
            this.toolStrpMnItmIstatistik,
            this.toolStrpMnItmSBilgi});
            this.toolStrpMnItmSinav.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrpMnItmSinav.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmSinav.Image")));
            this.toolStrpMnItmSinav.Name = "toolStrpMnItmSinav";
            this.toolStrpMnItmSinav.Size = new System.Drawing.Size(69, 21);
            this.toolStrpMnItmSinav.Text = "Sınav";
            // 
            // toolStrpMnItmSinavGir
            // 
            this.toolStrpMnItmSinavGir.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmSinavGir.Image")));
            this.toolStrpMnItmSinavGir.Name = "toolStrpMnItmSinavGir";
            this.toolStrpMnItmSinavGir.Size = new System.Drawing.Size(180, 22);
            this.toolStrpMnItmSinavGir.Text = "Sınava Gir";
            this.toolStrpMnItmSinavGir.Click += new System.EventHandler(this.toolStrpMnItmSinavGir_Click);
            // 
            // toolStrpMnItmIstatistik
            // 
            this.toolStrpMnItmIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmIstatistik.Image")));
            this.toolStrpMnItmIstatistik.Name = "toolStrpMnItmIstatistik";
            this.toolStrpMnItmIstatistik.Size = new System.Drawing.Size(180, 22);
            this.toolStrpMnItmIstatistik.Text = "İstatistik";
            this.toolStrpMnItmIstatistik.Click += new System.EventHandler(this.toolStrpMnItmIstatistik_Click);
            // 
            // toolStrpMnItmSBilgi
            // 
            this.toolStrpMnItmSBilgi.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmSBilgi.Image")));
            this.toolStrpMnItmSBilgi.Name = "toolStrpMnItmSBilgi";
            this.toolStrpMnItmSBilgi.Size = new System.Drawing.Size(180, 22);
            this.toolStrpMnItmSBilgi.Text = "Konu Dağılımı";
            this.toolStrpMnItmSBilgi.Click += new System.EventHandler(this.toolStrpMnItmSBilgi_Click);
            // 
            // toolStrpMnItmProfilim
            // 
            this.toolStrpMnItmProfilim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrpMnItmBilgilerim});
            this.toolStrpMnItmProfilim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrpMnItmProfilim.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmProfilim.Image")));
            this.toolStrpMnItmProfilim.Name = "toolStrpMnItmProfilim";
            this.toolStrpMnItmProfilim.Size = new System.Drawing.Size(86, 21);
            this.toolStrpMnItmProfilim.Text = "Profilim";
            // 
            // toolStrpMnItmBilgilerim
            // 
            this.toolStrpMnItmBilgilerim.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmBilgilerim.Image")));
            this.toolStrpMnItmBilgilerim.Name = "toolStrpMnItmBilgilerim";
            this.toolStrpMnItmBilgilerim.Size = new System.Drawing.Size(180, 22);
            this.toolStrpMnItmBilgilerim.Text = "Bilgilerim";
            this.toolStrpMnItmBilgilerim.Click += new System.EventHandler(this.toolStrpMnItmBilgilerim_Click);
            // 
            // toolStrpMnItmSiralama
            // 
            this.toolStrpMnItmSiralama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrpMnItmSiralama.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmSiralama.Image")));
            this.toolStrpMnItmSiralama.Name = "toolStrpMnItmSiralama";
            this.toolStrpMnItmSiralama.Size = new System.Drawing.Size(89, 21);
            this.toolStrpMnItmSiralama.Text = "Sıralama";
            this.toolStrpMnItmSiralama.Click += new System.EventHandler(this.toolStrpMnItmSiralama_Click);
            // 
            // toolStrpMnItmAyarlar
            // 
            this.toolStrpMnItmAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrpMnItmSifreDegistir,
            this.toolStrpMnItmCikis});
            this.toolStrpMnItmAyarlar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrpMnItmAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmAyarlar.Image")));
            this.toolStrpMnItmAyarlar.Name = "toolStrpMnItmAyarlar";
            this.toolStrpMnItmAyarlar.Size = new System.Drawing.Size(80, 21);
            this.toolStrpMnItmAyarlar.Text = "Ayarlar";
            // 
            // toolStrpMnItmSifreDegistir
            // 
            this.toolStrpMnItmSifreDegistir.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmSifreDegistir.Image")));
            this.toolStrpMnItmSifreDegistir.Name = "toolStrpMnItmSifreDegistir";
            this.toolStrpMnItmSifreDegistir.Size = new System.Drawing.Size(180, 22);
            this.toolStrpMnItmSifreDegistir.Text = "Şifremi değiştir";
            this.toolStrpMnItmSifreDegistir.Click += new System.EventHandler(this.toolStrpMnItmSifreDegistir_Click);
            // 
            // toolStrpMnItmCikis
            // 
            this.toolStrpMnItmCikis.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpMnItmCikis.Image")));
            this.toolStrpMnItmCikis.Name = "toolStrpMnItmCikis";
            this.toolStrpMnItmCikis.Size = new System.Drawing.Size(180, 22);
            this.toolStrpMnItmCikis.Text = "Çıkış";
            this.toolStrpMnItmCikis.Click += new System.EventHandler(this.toolStrpMnItmCikis_Click);
            // 
            // pctrbxALogo
            // 
            this.pctrbxALogo.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxALogo.Image")));
            this.pctrbxALogo.Location = new System.Drawing.Point(82, 50);
            this.pctrbxALogo.Name = "pctrbxALogo";
            this.pctrbxALogo.Size = new System.Drawing.Size(369, 156);
            this.pctrbxALogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxALogo.TabIndex = 3;
            this.pctrbxALogo.TabStop = false;
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 382);
            this.Controls.Add(this.pctrbxALogo);
            this.Controls.Add(this.lblSinavKural);
            this.Controls.Add(this.txtbxSinavBilgi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxALogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxSinavBilgi;
        private System.Windows.Forms.Label lblSinavKural;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmAnasayfa;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmSinav;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmSinavGir;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmIstatistik;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmSBilgi;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmProfilim;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmSiralama;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmAyarlar;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmSifreDegistir;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmCikis;
        private System.Windows.Forms.PictureBox pctrbxALogo;
        private System.Windows.Forms.ToolStripMenuItem toolStrpMnItmBilgilerim;
    }
}