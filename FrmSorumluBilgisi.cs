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
    public partial class FrmSorumluBilgisi : Form
    {
        public FrmSorumluBilgisi()
        {
            InitializeComponent();
        }

        private void pctrbxSBGeri_Click(object sender, EventArgs e)
        {
            FrmSorumluSayfasi adminsayfa = new FrmSorumluSayfasi();
            adminsayfa.Show();
            this.Hide();
        }

        SqlConnection baglanti;
        private void txtbxSBTckNo_TextChanged(object sender, EventArgs e)
        {
            if (txtbxSBTckNo.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            baglanti = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sinavsistemidb"].ConnectionString);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KullaniciKayit where KullaniciTipi='Sorumlu' AND Onay='True' AND TckNo like '" + txtbxSBTckNo.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtbxSBKullaniciAdi.Text = dr["KullaniciAdi"].ToString();
                txtbxSBAd.Text = dr["Ad"].ToString();
                txtbxSBSoyad.Text = dr["Soyad"].ToString();
                txtbxSBMail.Text = dr["Mail"].ToString();
            }
            baglanti.Close();
        }
    }
}
