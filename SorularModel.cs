using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi
{
    internal class SorularModel
    {
        public int SoruId { get; set; }
        public int SinifDuzey { get; set; }
        public string DersinAdi { get; set; }
        public int UniteNo { get; set; }
        public string UniteAdi { get; set; }
        public string KonuAdi { get; set; }
        public int SoruNo { get; set; }
        public string KodNo { get; set; }
        public byte[] SoruResmi { get; set; }
        public string SoruTexti { get; set; }
        public string DoğruCevap { get; set; }

        public SorularModel(int soruId, int sinifDuzey, string dersinAdi, int uniteNo, string uniteAdi, string konuAdi, int soruNo, string kodNo, byte[] soruResmi, string soruTexti, string doğruCevap)
        {
            SoruId = soruId;
            SinifDuzey = sinifDuzey;
            DersinAdi = dersinAdi;
            UniteNo = uniteNo;
            UniteAdi = uniteAdi;
            KonuAdi = konuAdi;
            SoruNo = soruNo;
            KodNo = kodNo;
            SoruResmi = soruResmi;
            SoruTexti = soruTexti;
            DoğruCevap = doğruCevap;
        }

        public SorularModel()
        {
        }
    }
}
