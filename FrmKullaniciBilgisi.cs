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
    public partial class FrmKullaniciBilgisi : Form
    {
        public FrmKullaniciBilgisi()
        {
            InitializeComponent();
        }

        private void pctrbxKBGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa sayfasi = new FrmAnasayfa();
            sayfasi.Show();
            this.Hide();
        }

        SqlConnection baglanti;
        private void txtbxKBTckNo_TextChanged(object sender, EventArgs e)
        {
            if (txtbxKBTckNo.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            baglanti = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sinavsistemidb"].ConnectionString);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KullaniciKayit where KullaniciTipi='Ogrenci' AND TckNo like '" + txtbxKBTckNo.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtbxKBKullaniciAdi.Text = dr["KullaniciAdi"].ToString();
                txtbxKBAd.Text = dr["Ad"].ToString();
                txtbxKBSoyad.Text = dr["Soyad"].ToString();
                txtbxKBMail.Text = dr["Mail"].ToString();
                txtbxKBKullaniciTipi.Text = dr["KullaniciTipi"].ToString();
            }
            baglanti.Close();
        }
    }
}
