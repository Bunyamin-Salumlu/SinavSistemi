using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SinavSistemi
{
    public class SifreGuncelleme
    {
        SqlConnection Baglanti;
        SqlCommand komut;
        SqlDataReader dr;
        public SifreGuncelleme()
        {
            Baglanti = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sinavsistemidb"].ConnectionString);
        }
        public bool Sifreyiguncelle(string kullaniciadi, string sifre)
        {
            bool kontol = false;
            komut = new SqlCommand("Update KullaniciKayit" + " Set Sifre='" + sifre + "'  where KullaniciAdi='" + kullaniciadi + "'", Baglanti);
            Baglanti.Open();
            if (komut.ExecuteNonQuery() != -1)
            {
                kontol = true;
            }
            Baglanti.Close();
            return kontol;
        }
        public bool KullaniciAdKontrol(string kullaniciadi)
        {
            bool result = false;

            komut = new SqlCommand("SELECT * FROM KullaniciKayit WHERE KullaniciAdi = '" + kullaniciadi + "'", Baglanti);
            Baglanti.Open();
            var oku = komut.ExecuteReader();
            if (oku.Read())
            {
                result = true;
            }
            Baglanti.Close();
            return result;
        }
    }
}
