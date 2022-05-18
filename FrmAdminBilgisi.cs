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
    public partial class FrmAdminBilgisi : Form
    {
        public FrmAdminBilgisi()
        {
            InitializeComponent();
        }

        private void pctrbxABGeri_Click_1(object sender, EventArgs e)
        {
            FrmAdminSayfasi adminsayfa = new FrmAdminSayfasi();
            adminsayfa.Show();
            this.Hide();
        }

        SqlConnection baglanti;
        private void txtbxABTckNo_TextChanged_1(object sender, EventArgs e)
        {
            if (txtbxABTckNo.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            baglanti = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sinavsistemidb"].ConnectionString);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KullaniciKayit where KullaniciTipi='Admin' AND TckNo like '" + txtbxABTckNo.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtbxABKullaniciAdi.Text = dr["KullaniciAdi"].ToString();
                txtbxABAd.Text = dr["Ad"].ToString();
                txtbxABSoyad.Text = dr["Soyad"].ToString();
                txtbxABMail.Text = dr["Mail"].ToString();
            }
            baglanti.Close();
        }
    }
}
