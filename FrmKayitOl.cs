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
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti;
        SqlCommand komut;
        SqlDataReader dr;

        private void btnKKaydet_Click(object sender, EventArgs e)
        {
            KullaniciEkleme kullaniciEkleme = new KullaniciEkleme();
            kullaniciEkleme.KullaniciAdi = txtbxKKullaniciAdi.Text;
            kullaniciEkleme.Ad = txtbxKAd.Text;
            kullaniciEkleme.Soyad = txtbxKSoyad.Text;
            kullaniciEkleme.Mail = txtbxKMail.Text;
            kullaniciEkleme.Sifre = txtbxKSifre.Text;
            kullaniciEkleme.KullaniciTipi = cmbxKKullaniciTipi.Text;

            if (cmbxKKullaniciTipi.Text == "Admin")
            {
                
            }
            else if(cmbxKKullaniciTipi.Text=="Sorumlu")
            {
                kullaniciEkleme.SorumluKaydet();
                FrmGiris giris = new FrmGiris();
                giris.Show();
                this.Hide();
                FrmKayitOl kayitOl = new FrmKayitOl();
                kayitOl.Close();
            }
            else
            {
                kullaniciEkleme.OgrenciKaydet();
                FrmGiris giris = new FrmGiris();
                giris.Show();
                this.Hide();
                FrmKayitOl kayitOl = new FrmKayitOl();
                kayitOl.Close();
            }   
        }
    }
}
