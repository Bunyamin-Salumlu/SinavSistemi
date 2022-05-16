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
    public partial class FrmKonuDagilimi : Form
    {
        public FrmKonuDagilimi()
        {
            InitializeComponent();
        }

        private void pctrbxGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa sayfasi = new FrmAnasayfa();
            sayfasi.Show();
            this.Hide();
        }
    }
}
