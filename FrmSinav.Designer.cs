
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinav));
            this.pctrbxSinavGeri = new System.Windows.Forms.PictureBox();
            this.pctrbxSinavEkrani = new System.Windows.Forms.PictureBox();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.rdbtnA = new System.Windows.Forms.RadioButton();
            this.rdbtnB = new System.Windows.Forms.RadioButton();
            this.rdbtnC = new System.Windows.Forms.RadioButton();
            this.rdbtnD = new System.Windows.Forms.RadioButton();
            this.lblSure = new System.Windows.Forms.Label();
            this.btnBitir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSinavGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSinavEkrani)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxSinavGeri
            // 
            this.pctrbxSinavGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxSinavGeri.Image")));
            this.pctrbxSinavGeri.Location = new System.Drawing.Point(16, 15);
            this.pctrbxSinavGeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctrbxSinavGeri.Name = "pctrbxSinavGeri";
            this.pctrbxSinavGeri.Size = new System.Drawing.Size(53, 37);
            this.pctrbxSinavGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxSinavGeri.TabIndex = 2;
            this.pctrbxSinavGeri.TabStop = false;
            this.pctrbxSinavGeri.Click += new System.EventHandler(this.pctrbxSinavGeri_Click);
            // 
            // pctrbxSinavEkrani
            // 
            this.pctrbxSinavEkrani.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pctrbxSinavEkrani.Location = new System.Drawing.Point(71, 95);
            this.pctrbxSinavEkrani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctrbxSinavEkrani.Name = "pctrbxSinavEkrani";
            this.pctrbxSinavEkrani.Size = new System.Drawing.Size(591, 252);
            this.pctrbxSinavEkrani.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxSinavEkrani.TabIndex = 3;
            this.pctrbxSinavEkrani.TabStop = false;
            // 
            // btnOnceki
            // 
            this.btnOnceki.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOnceki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnceki.Location = new System.Drawing.Point(71, 354);
            this.btnOnceki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(119, 41);
            this.btnOnceki.TabIndex = 4;
            this.btnOnceki.Text = "ÖNCEKİ";
            this.btnOnceki.UseVisualStyleBackColor = false;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSonraki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonraki.Location = new System.Drawing.Point(543, 354);
            this.btnSonraki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(119, 41);
            this.btnSonraki.TabIndex = 6;
            this.btnSonraki.Text = "SONRAKİ";
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // rdbtnA
            // 
            this.rdbtnA.AutoSize = true;
            this.rdbtnA.BackColor = System.Drawing.Color.Thistle;
            this.rdbtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnA.Location = new System.Drawing.Point(217, 362);
            this.rdbtnA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnA.Name = "rdbtnA";
            this.rdbtnA.Size = new System.Drawing.Size(42, 24);
            this.rdbtnA.TabIndex = 7;
            this.rdbtnA.TabStop = true;
            this.rdbtnA.Text = "A";
            this.rdbtnA.UseVisualStyleBackColor = false;
            // 
            // rdbtnB
            // 
            this.rdbtnB.AutoSize = true;
            this.rdbtnB.BackColor = System.Drawing.Color.Thistle;
            this.rdbtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnB.Location = new System.Drawing.Point(300, 362);
            this.rdbtnB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnB.Name = "rdbtnB";
            this.rdbtnB.Size = new System.Drawing.Size(43, 24);
            this.rdbtnB.TabIndex = 8;
            this.rdbtnB.TabStop = true;
            this.rdbtnB.Text = "B";
            this.rdbtnB.UseVisualStyleBackColor = false;
            // 
            // rdbtnC
            // 
            this.rdbtnC.AutoSize = true;
            this.rdbtnC.BackColor = System.Drawing.Color.Thistle;
            this.rdbtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnC.Location = new System.Drawing.Point(383, 362);
            this.rdbtnC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnC.Name = "rdbtnC";
            this.rdbtnC.Size = new System.Drawing.Size(43, 24);
            this.rdbtnC.TabIndex = 9;
            this.rdbtnC.TabStop = true;
            this.rdbtnC.Text = "C";
            this.rdbtnC.UseVisualStyleBackColor = false;
            // 
            // rdbtnD
            // 
            this.rdbtnD.AutoSize = true;
            this.rdbtnD.BackColor = System.Drawing.Color.Thistle;
            this.rdbtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnD.Location = new System.Drawing.Point(465, 362);
            this.rdbtnD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnD.Name = "rdbtnD";
            this.rdbtnD.Size = new System.Drawing.Size(44, 24);
            this.rdbtnD.TabIndex = 10;
            this.rdbtnD.TabStop = true;
            this.rdbtnD.Text = "D";
            this.rdbtnD.UseVisualStyleBackColor = false;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(565, 55);
            this.lblSure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(88, 24);
            this.lblSure.TabIndex = 12;
            this.lblSure.Text = "00:00:00";
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitir.Location = new System.Drawing.Point(563, 422);
            this.btnBitir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(99, 55);
            this.btnBitir.TabIndex = 13;
            this.btnBitir.Text = "BİTİR";
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(719, 494);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.rdbtnD);
            this.Controls.Add(this.rdbtnC);
            this.Controls.Add(this.rdbtnB);
            this.Controls.Add(this.rdbtnA);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.pctrbxSinavEkrani);
            this.Controls.Add(this.pctrbxSinavGeri);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSinav_FormClosed);
            this.Load += new System.EventHandler(this.FrmSinav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSinavGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSinavEkrani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxSinavGeri;
        private System.Windows.Forms.PictureBox pctrbxSinavEkrani;
        private System.Windows.Forms.Button btnOnceki;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.RadioButton rdbtnA;
        private System.Windows.Forms.RadioButton rdbtnB;
        private System.Windows.Forms.RadioButton rdbtnC;
        private System.Windows.Forms.RadioButton rdbtnD;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Timer timer1;
    }
}