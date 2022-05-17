
namespace SinavSistemi
{
    partial class FrmAdminSayfasi
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
            this.btnABilgileriniGör = new System.Windows.Forms.Button();
            this.btnASorumluOnay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABilgileriniGör
            // 
            this.btnABilgileriniGör.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnABilgileriniGör.Location = new System.Drawing.Point(58, 68);
            this.btnABilgileriniGör.Name = "btnABilgileriniGör";
            this.btnABilgileriniGör.Size = new System.Drawing.Size(117, 52);
            this.btnABilgileriniGör.TabIndex = 0;
            this.btnABilgileriniGör.Text = "Bilgilerini Gör";
            this.btnABilgileriniGör.UseVisualStyleBackColor = true;
            this.btnABilgileriniGör.Click += new System.EventHandler(this.btnABilgileriniGör_Click);
            // 
            // btnASorumluOnay
            // 
            this.btnASorumluOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnASorumluOnay.Location = new System.Drawing.Point(58, 155);
            this.btnASorumluOnay.Name = "btnASorumluOnay";
            this.btnASorumluOnay.Size = new System.Drawing.Size(117, 50);
            this.btnASorumluOnay.TabIndex = 2;
            this.btnASorumluOnay.Text = "Sorumlu Onayı";
            this.btnASorumluOnay.UseVisualStyleBackColor = true;
            this.btnASorumluOnay.Click += new System.EventHandler(this.btnASorumluOnay_Click);
            // 
            // FrmAdminSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 272);
            this.Controls.Add(this.btnASorumluOnay);
            this.Controls.Add(this.btnABilgileriniGör);
            this.Name = "FrmAdminSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Sayfası";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnABilgileriniGör;
        private System.Windows.Forms.Button btnASorumluOnay;
    }
}