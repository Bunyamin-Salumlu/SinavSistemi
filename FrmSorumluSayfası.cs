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
    public partial class FrmSorumluSayfasi : Form
    {
        public FrmSorumluSayfasi()
        {
            InitializeComponent();
        }

        private void btnSSoruEkle_Click(object sender, EventArgs e)
        {
            FrmSoruEkle soruEkle = new FrmSoruEkle();
            soruEkle.Show();
            this.Hide();
        }

        private void btnSBilgileriniGor_Click(object sender, EventArgs e)
        {
            FrmSorumluBilgisi sorumluBilgisi = new FrmSorumluBilgisi();
            sorumluBilgisi.Show();
            this.Hide();
            MessageBox.Show("Tc kimlik numaranızı girerek bilgilerinizi görebilirsiniz.!");
        }
    }
}
