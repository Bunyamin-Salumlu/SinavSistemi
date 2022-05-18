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
using System.IO;

namespace SinavSistemi
{
    public partial class FrmSinav : Form
    {
        private int sayac =1000 * 60 * 10;
        private SqlConnection baglanti;
        private List<SorularModel> sorular;
        private int soruIndex = 0;
        private SorularModel selectedModel = null;
       
        public FrmSinav()
        {
            InitializeComponent();
            baglanti = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sinavsistemidb"].ConnectionString);
            sorular = new List<SorularModel>();
            baglanti.Open();
            sorulariGetir();
            selectedModel = sorular[soruIndex];

            
        }
        private void soruyuGoster() {
            MemoryStream mem = new MemoryStream(selectedModel.SoruResmi);
            pctrbxSinavEkrani.Image = Image.FromStream(mem);
            siklariBosalt();

        }
        private void siklariBosalt() {

            rdbtnA.Checked = false;
            rdbtnB.Checked = false;
            rdbtnC.Checked = false;
            rdbtnD.Checked = false;
        }
        private void ileri() {
            if (!siklarBosMu())
            {
                
                if (soruIndex < sorular.Count - 1)
                {
                    cevabıKontrolEt();
                    soruIndex++;
                    selectedModel = sorular[soruIndex];
                    soruyuGoster();
                }
            }
            else {
                MessageBox.Show("Cevap Vermeden İlerleyemezsiniz!");
            }
           
            
        
        }
        private bool siklarBosMu() {
            return rdbtnA.Checked == false && rdbtnB.Checked == false && rdbtnC.Checked == false && rdbtnD.Checked == false;
        }
        private void geri() {
                if (soruIndex > 0)
                {
                cevabıKontrolEt();
                soruIndex--;
                    selectedModel = sorular[soruIndex];
                    soruyuGoster();
                }
              
        }
        private String getSelectedRadioButtonIndex() {

            if (rdbtnA.Checked == true)
            {
                return "A";
            }
            else if (rdbtnB.Checked == true)
            {
                return "B";
            }
            else if (rdbtnC.Checked == true)
            {
                return "C";
            }
            else {
                return "D";
            }
        }
        private void cevabıKontrolEt() {
            int soruId = selectedModel.SoruId;
            int kullaniciId = FrmGiris.KullaniciId;
            //selectedModel.DoğruCevap == getSelectedRadioButtonIndex()

            if (true)
            {

                if (isDataExist(soruId, kullaniciId))
                {

                    //Soru varsa
                    string selectCommand = String.Format("select seviye from sigma where SoruId = {0} and KullaniciId = {1}", soruId, kullaniciId);
                    SqlCommand komut = new SqlCommand();
                    komut.CommandText = selectCommand;
                    komut.Connection = this.baglanti;
                    SqlDataReader dataReader = komut.ExecuteReader();
                    
                    if (dataReader.Read())
                    {
                        int level = dataReader.GetInt32(0);
                        string updateCommandText = String.Format("update  sigma set seviye = {0} where SoruId = {1} and KullaniciID{2}", level + 1,soruId,kullaniciId);
                       // sorguCalistir(updateCommandText);
                    }
                    dataReader.Close();
              
                }
                else {
                     SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.baglanti;
                    cmd.CommandText = "insert into sigma(SoruId,KullaniciID,seviye) values(@SoruId,@KullaniciID,@seviye) ";
                    cmd.Parameters.AddWithValue("@SoruId", soruId);
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciId);
                    cmd.Parameters.AddWithValue("@seviye", 0);
                    cmd.ExecuteNonQuery();

                   
                }
            }
            else {
                string zeroCommand = String.Format("update sigma set seviye = 0 where SoruId = {0} and KullaniciID = {1} ", soruId, kullaniciId);
               // sorguCalistir(zeroCommand);
              
            }
        }
      
        private bool isDataExist(int soruId,int kullaniciId) {
            string existControlCommand = "SELECT COUNT(*) FROM sigma WHERE SoruId =" + soruId + " and KullaniciID =" + kullaniciId;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = existControlCommand;
            komut.Connection = this.baglanti;
            SqlDataReader dataReader = komut.ExecuteReader();
            
            if (dataReader.Read()) {
                int count = dataReader.GetInt32(0);
                if (count > 0)
                {

                    dataReader.Close();

                    return true;
                }
                else {
                    dataReader.Close();
                    return false;
                }
                    
            }
            dataReader.Close();
            
          
            return false;
        }
        private void pctrbxSinavGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa sayfasi = new FrmAnasayfa();
            sayfasi.Show();
            this.Hide();
        }

        private void FrmSinav_Load(object sender, EventArgs e)
        {
            lblSure.Text = "00:00";
            timer1.Start();
            timer1.Interval = 1000;
            soruyuGoster();
        }
        private void sorulariGetir() {
            
            string commandText = " select TOP 10 * from Sorular ORDER BY RAND()";
            SqlCommand komut = new SqlCommand();
            komut.Connection = this.baglanti;
            komut.CommandText = commandText;
           
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.HasRows)
            {


                while (dataReader.Read())
                {
                    SorularModel model = new SorularModel();
                    model.SoruId = (int) dataReader["SoruId"];
                    model.SinifDuzey = dataReader.GetInt32(1);
                    model.DersinAdi = dataReader.GetString(2);
                    model.UniteNo = dataReader.GetInt32(3);
                    model.UniteAdi = dataReader.GetString(4);
                    model.KonuAdi = dataReader.GetString(5);
                    model.SoruNo = dataReader.GetInt32(6);
                    model.KodNo = dataReader.GetString(7);
                    model.SoruResmi =(byte[]) dataReader["SoruResmi"];
                    model.SoruTexti = dataReader.GetString(9);
                    model.DoğruCevap = dataReader.GetString(10);
                    sorular.Add(model);
                }
            }
            else
            {
                MessageBox.Show("Veri bulunamadı");
                bitir();
            }
            dataReader.Close();

                
        }
        private void btnBitir_Click(object sender, EventArgs e)
        {
            bitir();
            
        }
        private void bitir() {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac -= 1000;
            TimeSpan t = TimeSpan.FromMilliseconds(sayac);
            
            lblSure.Text = t.ToString("mm\\:ss");

            if (sayac == 0) {
                lblSure.Text = t.ToString("mm\\:ss");
                MessageBox.Show("Sınavınız Sona Ermiştir");
                timer1.Stop();
                
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            ileri();
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            geri();
        }

        private void FrmSinav_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.baglanti.Close();
        }
    }
}
