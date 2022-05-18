using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SinavSistemi
{
    public class KullaniciVeritabani
    {
        SqlConnection Baglanti;
        SqlCommand komut;
        SqlDataReader dr;

        public KullaniciVeritabani(SqlConnection baglanti)
        {
            this.Baglanti = baglanti;
            Baglanti = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sinavsistemidb"].ConnectionString);
        }

        public void OgrenciEkle(string tckno, string kullaniciadi, string ad, string soyad, string mail, string sifre, string kullanicitipi, string ogrencionayi)
        {
            int kayitlimi = 0;

            komut = new SqlCommand();
            komut.Connection = Baglanti;
            Baglanti.Open();
            komut.CommandText = "select TckNo, KullaniciAdi, Ad, Soyad, Mail, Sifre, KullaniciTipi, Onay from KullaniciKayit where TckNo='" + tckno + "'and KullaniciAdi='" + kullaniciadi + "' and Ad='" + ad + "' and Soyad='" + soyad + "' and Mail='" + mail + "'and Sifre='" + sifre + "'and KullaniciTipi='" + kullanicitipi + "'and Onay='" + ogrencionayi + "'";
            dr = komut.ExecuteReader();

            if (dr.Read())//Kullanıcı bulunduysa kayıtlı demektir.
                kayitlimi = 1;

            Baglanti.Close();

            if (kayitlimi == 1)//1'e eşitse kayıtlı demektir.
            {
                System.Windows.Forms.MessageBox.Show("\nKayıt etmek istediğiniz kullanıcı zaten kayıtlı.\n");
            }
            else //Kayıtlı değilse kayıt et
            {
                komut = new SqlCommand();
                komut.Connection = Baglanti;
                Baglanti.Open();

                komut.CommandText = "insert into KullaniciKayit(TckNo,KullaniciAdi,Ad,Soyad,Mail,Sifre,KullaniciTipi,Onay) values('" + tckno + "','" + kullaniciadi + "','" + ad + "','" + soyad + "', '" + mail + "','" + sifre + "','" + kullanicitipi + "','" + ogrencionayi + "')";
                komut.ExecuteNonQuery();
                Baglanti.Close();
                System.Windows.Forms.MessageBox.Show("Kaydınız başarıyla yapıldı.");
            }
        }

        public void SorumluEkle(string tckno, string kullaniciadi, string ad, string soyad, string mail, string sifre, string kullanicitipi, string sorumluonayi)
        {
            int kayitlimi = 0;
            komut = new SqlCommand();
            komut.Connection = Baglanti;
            Baglanti.Open();
            komut.CommandText = "select TckNo, KullaniciAdi, Ad, Soyad, Mail, Sifre, KullaniciTipi, Onay from KullaniciKayit where TckNo='" + tckno + "' and KullaniciAdi='" + kullaniciadi + "' and Ad='" + ad + "' and Soyad='" + soyad + "' and Mail='" + mail + "'and Sifre='" + sifre + "'and KullaniciTipi='" + kullanicitipi + "'and Onay='" + sorumluonayi + "'";
            dr = komut.ExecuteReader();

            if (dr.Read())//Kullanıcı bulunduysa kayıtlı demektir.
                kayitlimi = 1;

            Baglanti.Close();

            if (kayitlimi == 1)//1'e eşitse kayıtlı demektir.
            {
                System.Windows.Forms.MessageBox.Show("\nKayıt etmek istediğiniz kullanıcı zaten kayıtlı.\n");
            }
            else //Kayıtlı değilse kayıt et
            {
                komut = new SqlCommand();
                komut.Connection = Baglanti;
                Baglanti.Open();

                komut.CommandText = "insert into KullaniciKayit(TckNo,KullaniciAdi,Ad,Soyad,Mail,Sifre,KullaniciTipi,Onay) values('" + tckno + "','" + kullaniciadi + "','" + ad + "','" + soyad + "', '" + mail + "','" + sifre + "','" + kullanicitipi + "','" + sorumluonayi + "')";
                komut.ExecuteNonQuery();
                Baglanti.Close();
                System.Windows.Forms.MessageBox.Show("Kaydınız başarıyla yapıldı.");
            }
        }
    }
}

