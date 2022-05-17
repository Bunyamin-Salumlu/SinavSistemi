using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SinavSistemi
{
    public partial class FrmSoruEkle : Form
    {
        SqlConnection Baglanti;
        SqlCommand komut;
        SqlDataReader dr;
        public FrmSoruEkle()
        {
            InitializeComponent();
        }
        private void pctrbxSoruResmiEkle_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Soru Ekle";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);    // masaüstünü göstermesi için
            openFileDialog1.Filter = "JPEG (*.jpg; *jpeg; *jpe)|*.jpg; *jpeg; *jpe|All files (*.*)|*.*";        // dosya filtrelemesi
           
            
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            foreach (string s in openFileDialog1.FileNames)     // multi select özelliği için kullanılabilir
                            {
                                pctrbxSoruResmiEkle.ImageLocation = s;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Dosya okunamadı!" + ex.Message);
                }
            }
        }

        private void btnSEkle_Click(object sender, EventArgs e)
        {
            if (pctrbxSoruResmiEkle.ImageLocation.ToString() != "")       // dosya var mı
            {
                byte[] ImageByteArray = File.ReadAllBytes(pctrbxSoruResmiEkle.ImageLocation.ToString());
                //ImageConverter ımageConverter = new ImageConverter();
                //byte[] ImageByteArray= (System.Byte[])ımageConverter.ConvertTo(pctrBxSoruGörseliEkle.ImageLocation.ToString(),Type.GetType("System.Byte[]"));
                using (SqlConnection connection = new SqlConnection("server=.; Initial Catalog=SinavSistemi;Integrated Security=SSPI"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Sorular (SinifDuzeyi,DersinAdi,UniteNo,UniteAdi,KonuAdi,SoruNo,KodNo,SoruResmi,SoruTexti,DogruCevap) VALUES (@sinifduzeyi,@dersinadi,@uniteno,@uniteadi,@konuadi,@soruno,@kodno,@soruresmi,@sorutexti,@dogrucevap)";
                        command.Parameters.AddWithValue("@sinifduzeyi", Convert.ToInt32(cmbxSinifDuzeyi.Text));
                        command.Parameters.AddWithValue("@dersinadi", cmbxDersinAdi.Text);
                        command.Parameters.AddWithValue("@uniteno", Convert.ToInt32(cmbxUniteNo.Text));
                        command.Parameters.AddWithValue("@uniteadi", cmbxUniteAdi.Text);
                        command.Parameters.AddWithValue("@konuadi", txtbxKonuAdi.Text);
                        command.Parameters.AddWithValue("@soruno", Convert.ToInt32(txtbxSoruNo.Text));
                        command.Parameters.AddWithValue("@kodno", txtbxKodNo.Text);
                        command.Parameters.AddWithValue("@soruresmi", ImageByteArray);
                        command.Parameters.AddWithValue("@sorutexti", txtbxAciklama.Text);
                        command.Parameters.AddWithValue("@dogrucevap", cmbxDogruCevap.Text);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();

                            MessageBox.Show("Başarılı!");
                        }
                        catch (SqlException se)
                        {
                            MessageBox.Show(se.ToString());
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Resim seç!");
            }
        }
    }
}
