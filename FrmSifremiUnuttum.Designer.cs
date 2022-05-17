namespace SinavSistemi
{
    partial class FrmSifremiUnuttum
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
            this.lblSMail = new System.Windows.Forms.Label();
            this.txtSMail = new System.Windows.Forms.TextBox();
            this.btnSMailGonder = new System.Windows.Forms.Button();
            this.lblSBilgi = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblSMail
            // 
            this.lblSMail.AutoSize = true;
            this.lblSMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSMail.Location = new System.Drawing.Point(15, 45);
            this.lblSMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSMail.Name = "lblSMail";
            this.lblSMail.Size = new System.Drawing.Size(95, 13);
            this.lblSMail.TabIndex = 0;
            this.lblSMail.Text = "Mailinizi Giriniz:";
            // 
            // txtSMail
            // 
            this.txtSMail.BackColor = System.Drawing.SystemColors.Info;
            this.txtSMail.Location = new System.Drawing.Point(130, 42);
            this.txtSMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtSMail.Name = "txtSMail";
            this.txtSMail.Size = new System.Drawing.Size(158, 20);
            this.txtSMail.TabIndex = 1;
            // 
            // btnSMailGonder
            // 
            this.btnSMailGonder.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSMailGonder.Location = new System.Drawing.Point(130, 80);
            this.btnSMailGonder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSMailGonder.Name = "btnSMailGonder";
            this.btnSMailGonder.Size = new System.Drawing.Size(82, 45);
            this.btnSMailGonder.TabIndex = 2;
            this.btnSMailGonder.Text = "Mail Gönder";
            this.btnSMailGonder.UseVisualStyleBackColor = false;
            this.btnSMailGonder.Click += new System.EventHandler(this.btnMailGonder_Click);
            // 
            // lblSBilgi
            // 
            this.lblSBilgi.AutoSize = true;
            this.lblSBilgi.Location = new System.Drawing.Point(15, 204);
            this.lblSBilgi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSBilgi.Name = "lblSBilgi";
            this.lblSBilgi.Size = new System.Drawing.Size(26, 13);
            this.lblSBilgi.TabIndex = 3;
            this.lblSBilgi.Text = "Bilgi";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.RoyalBlue;
            this.progressBar1.Location = new System.Drawing.Point(130, 150);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(105, 19);
            this.progressBar1.TabIndex = 4;
            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(347, 237);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblSBilgi);
            this.Controls.Add(this.btnSMailGonder);
            this.Controls.Add(this.txtSMail);
            this.Controls.Add(this.lblSMail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSMail;
        private System.Windows.Forms.TextBox txtSMail;
        private System.Windows.Forms.Button btnSMailGonder;
        private System.Windows.Forms.Label lblSBilgi;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}