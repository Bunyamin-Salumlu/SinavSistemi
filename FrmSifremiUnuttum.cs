using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Net.Mail;
using System.Data.SqlClient;

namespace SinavSistemi
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }
        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("YazilimSinamaOdev@outlook.com");
            ePosta.To.Add(txtSMail.Text); //göndereceğimiz mail adresi

            ePosta.Subject = konu; //mail konusu
            ePosta.Body = icerik; //mail içeriği 

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("YazilimSinamaOdev@outlook.com", "yazilimyapimi..");
            client.Port = 587;
            client.Host = "smtp.outlook.com";
            client.EnableSsl = true;
            client.Send(ePosta);
            object userState = true;
            bool kontrol = true;
            try
            {
                client.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message);
            }
            return kontrol;
        }
        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            string Sifre;
            string kullaniciadi;
            string kullanicitipi;
          
            try
            {
                SqlConnection baglanti = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sinavsistemidb"].ConnectionString);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand();
                komut.CommandText = "select * from KullaniciKayit  where Mail='" + txtSMail.Text + "'";
                komut.Connection = baglanti;
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    Sifre = oku["Sifre"].ToString();
                    kullaniciadi = oku["KullaniciAdi"].ToString();
                    kullanicitipi = oku["KullaniciTipi"].ToString();

                    lblSBilgi.Visible = true;
                    lblSBilgi.ForeColor = Color.Green;
                    lblSBilgi.Text = "Girmiş Olduğunuz Bilgiler Uyuşuyor Şifreniz Mail Olarak Gönderildi";
                    MessageBox.Show("Mailinize şifreniz gönderildi bakınız. Sonra giriş yapabilirsiniz.!");
                        
                    FrmGiris giris = new FrmGiris();
                    giris.Show();
                    this.Hide();
                    FrmSifremiUnuttum sifremiUnuttum = new FrmSifremiUnuttum();
                    sifremiUnuttum.Close();

                    progressBar1.Visible = true;
                    progressBar1.Maximum = 900000;
                    progressBar1.Minimum = 90;

                    for (int j = 90; j < 900000; j++)
                    {
                        progressBar1.Value = j;
                    }
                    MailGonder("ŞİFRE VE KULLANICI ADI HATIRLATMA ", "Şifreniz: " + Sifre+ " Kullanici adiniz:"+kullaniciadi+" Kullanici Türünüz: "+kullanicitipi);
                    
                    baglanti.Close();
                }
                else
                {
                    lblSBilgi.Visible = true;
                    lblSBilgi.ForeColor = Color.Red;
                    lblSBilgi.Text = "Girmiş Olduğunuz Bilgiler Uyuşmuyor";
                }
            }
            catch (Exception)
            {
                lblSBilgi.Visible = true;
                lblSBilgi.ForeColor = Color.Red;
                lblSBilgi.Text = "Mail Gönderme Hatası";
            } 
        }
    }
}
