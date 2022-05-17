
namespace SinavSistemi
{
    partial class FrmSorumluOnayBilgileri
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
            this.dtGrdSorumluBilgileri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSorumluBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdSorumluBilgileri
            // 
            this.dtGrdSorumluBilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdSorumluBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdSorumluBilgileri.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtGrdSorumluBilgileri.Location = new System.Drawing.Point(12, 12);
            this.dtGrdSorumluBilgileri.Name = "dtGrdSorumluBilgileri";
            this.dtGrdSorumluBilgileri.Size = new System.Drawing.Size(449, 172);
            this.dtGrdSorumluBilgileri.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sorumlu kimi seçiyorsanız True olarak yazıp güncelleyiniz.!\r\n\r\n";
            // 
            // btnSGuncelle
            // 
            this.btnSGuncelle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSGuncelle.Location = new System.Drawing.Point(186, 217);
            this.btnSGuncelle.Name = "btnSGuncelle";
            this.btnSGuncelle.Size = new System.Drawing.Size(82, 45);
            this.btnSGuncelle.TabIndex = 6;
            this.btnSGuncelle.Text = "Güncelle";
            this.btnSGuncelle.UseVisualStyleBackColor = false;
            this.btnSGuncelle.Click += new System.EventHandler(this.btnSGuncelle_Click);
            // 
            // FrmSorumluOnayBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(477, 284);
            this.Controls.Add(this.btnSGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGrdSorumluBilgileri);
            this.Name = "FrmSorumluOnayBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorumlu Onay Bilgileri";
            this.Load += new System.EventHandler(this.FrmSorumluOnayBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSorumluBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGrdSorumluBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSGuncelle;
    }
}