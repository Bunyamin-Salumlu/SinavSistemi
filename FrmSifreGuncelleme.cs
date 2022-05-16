using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class FrmSifreGuncelleme : Form
    {
        public FrmSifreGuncelleme()
        {
            InitializeComponent();
        }

        private void btnSGGuncelle_Click(object sender, EventArgs e)
        {
            SifreGuncelleme guncelle = new SifreGuncelleme();
            if (!guncelle.KullaniciAdKontrol(txtbxSGKullaniciAdi.Text))
            {
                MessageBox.Show("Bu kullanıcı adında bir kullanıcı bulunmamaktadır.");
                txtbxSGKullaniciAdi.Text = "";
            }
            else
            {
                guncelle.Sifreyiguncelle(txtbxSGKullaniciAdi.Text, txtbxSGSifre.Text);
                MessageBox.Show("Şifreniz güncellendi..!");
            }
        }

        private void pctrbxSGGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa sayfasi = new FrmAnasayfa();
            sayfasi.Show();
            this.Hide();
        }
    }
}
