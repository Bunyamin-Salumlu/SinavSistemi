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
    public partial class FrmAdminSayfasi : Form
    {
        public FrmAdminSayfasi()
        {
            InitializeComponent();
        }

        private void btnASorumluOnay_Click(object sender, EventArgs e)
        {
            FrmSorumluOnayBilgileri onayBilgileri = new FrmSorumluOnayBilgileri();
            onayBilgileri.Show();
            this.Hide();
        }

        private void btnABilgileriniGör_Click(object sender, EventArgs e)
        {
            FrmAdminBilgisi adminBilgisi = new FrmAdminBilgisi();
            adminBilgisi.Show();
            this.Hide();
            MessageBox.Show("Tc kimlik numaranızı girerek bilgilerinizi görebilirsiniz.!");
        }
    }
}
