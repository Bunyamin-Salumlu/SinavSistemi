using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SinavSistemi
{
    public class KullaniciEkleme
    {
        private int kullaniciId;
        private string tckno;
        private string kullaniciadi;
        private string ad;
        private string soyad;
        private string mail;
        private string sifre;
        private string kullanicitipi;

        public int KullaniciID { get { return kullaniciId; } set { this.kullaniciId = value; } }
        public string TckNo { get { return tckno; } set { this.tckno = value; } }
        public string KullaniciAdi { get { return kullaniciadi; } set { this.kullaniciadi = value; } }
        public string Ad { get { return ad; } set { this.ad = value; } }
        public string Soyad { get { return soyad; } set { this.soyad = value; } }
        public string Mail { get { return mail; } set { this.mail = value; } }
        public string Sifre { get { return sifre; } set { this.sifre = value; } }
        public string KullaniciTipi { get { return kullanicitipi; } set { this.kullanicitipi = value; } }

        public string OgrenciOnayi = "True";
        public string SorumluOnayi = "False";

        SqlConnection baglanti;
        public void OgrenciKaydet()
        {
            KullaniciVeritabani vt = new KullaniciVeritabani(baglanti);
            vt.OgrenciEkle(tckno, kullaniciadi, ad, soyad, mail, sifre, kullanicitipi, OgrenciOnayi);
        }
        public void SorumluKaydet()
        {
            KullaniciVeritabani vt = new KullaniciVeritabani(baglanti);
            vt.SorumluEkle(tckno, kullaniciadi, ad, soyad, mail, sifre, kullanicitipi, SorumluOnayi);
        }
    }
}
