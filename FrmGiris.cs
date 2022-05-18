using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SinavSistemi
{
    public partial class FrmGiris : Form
    {
        SqlConnection Baglanti;
        SqlCommand komut;
        SqlDataReader dr;
        public static int KullaniciId = -1;
        public FrmGiris()
        {
            InitializeComponent();
        }        

        public void Kontrol()
        {
            string kullaniciadi = txtbxKullaniciAdi.Text;
            string sifre = txtbxSifre.Text;
            string kullanicitipi = cmbxKullaniciTipi.Text;
            string onay = "True";
            Baglanti = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sinavsistemidb"].ConnectionString);
            komut = new SqlCommand();
            Baglanti.Open();
            komut.Connection = Baglanti;
            komut.CommandText = "SELECT * FROM KullaniciKayit where KullaniciAdi='" + kullaniciadi + "' AND Sifre='" + sifre + "' AND KullaniciTipi='" + kullanicitipi + "' AND Onay='" + onay + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                KullaniciId = dr.GetInt32(0);
                if (kullanicitipi == "Admin")
                {
                    FrmAdminSayfasi adminSayfasi = new FrmAdminSayfasi();
                    adminSayfasi.Show();
                    this.Hide();
                }
                else if (kullanicitipi == "Sorumlu")
                {
                    FrmSorumluSayfasi sorumluSayfasi = new FrmSorumluSayfasi();
                    sorumluSayfasi.Show();
                    this.Hide();
                }
                else if (kullanicitipi == "Ogrenci")
                {
                    FrmAnasayfa anasayfa = new FrmAnasayfa();
                    anasayfa.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Lütfen kullanici tipini giriniz..!");
            }

            else
            {
                MessageBox.Show("Kullanıcı bilgilerinizi giriniz ve kontrol ediniz..!");
            }
            Baglanti.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kontrol();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl kayitOl = new FrmKayitOl();
            kayitOl.Show();
            this.Hide();
            FrmGiris giris = new FrmGiris();
            giris.Close();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttum sifremiUnuttum = new FrmSifremiUnuttum();
            sifremiUnuttum.Show();
            this.Hide();
        }
    }
}
