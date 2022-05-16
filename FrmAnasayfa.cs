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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void toolStrpMnItmAnasayfa_Click(object sender, EventArgs e)
        {
            FrmAnasayfa anasayfa = new FrmAnasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void toolStrpMnItmSinavGir_Click(object sender, EventArgs e)
        {
            DialogResult start = MessageBox.Show("Sınav başlatılsın mı?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (start == DialogResult.Yes)
            {
                FrmSinav sinav = new FrmSinav();
                sinav.Show();
                this.Close();
            }
        }

        private void toolStrpMnItmIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik istatistik = new FrmIstatistik();
            istatistik.Show();
            this.Close();
        }

        private void toolStrpMnItmSBilgi_Click(object sender, EventArgs e)
        {
            FrmKonuDagilimi bilgi = new FrmKonuDagilimi();
            bilgi.Show();
            this.Hide();
        }

        private void toolStrpMnItmBilgilerim_Click(object sender, EventArgs e)
        {
            FrmKullaniciBilgisi kullanici = new FrmKullaniciBilgisi();
            kullanici.Show();
            this.Hide();
        }

        private void toolStrpMnItmSiralama_Click(object sender, EventArgs e)
        {
            // Sıralam işleme
        }

        private void toolStrpMnItmSifreDegistir_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelleme guncelleme = new FrmSifreGuncelleme();
            guncelleme.Show();
            this.Hide();
        }

        private void toolStrpMnItmCikis_Click(object sender, EventArgs e)
        {
            DialogResult shut = MessageBox.Show("Uygulama kapatılsın mı?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (shut == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
