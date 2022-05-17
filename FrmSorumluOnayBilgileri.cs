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
    public partial class FrmSorumluOnayBilgileri : Form
    {
        public FrmSorumluOnayBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder komut;
        private void FrmSorumluOnayBilgileri_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=SinavSistemi;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select KullaniciID, Ad, Soyad, KullaniciTipi, Onay from KullaniciKayit WHERE KullaniciTipi='Sorumlu'", baglanti);
            komut = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "KullaniciKayit");
            dtGrdSorumluBilgileri.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnSGuncelle_Click(object sender, EventArgs e)
        {
            da.Update(ds, "KullaniciKayit");
            MessageBox.Show("Kayıt güncellendi");
        }
    }
}
