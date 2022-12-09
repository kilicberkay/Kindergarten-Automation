using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
    public partial class RaporAl : Form
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public string yeniUserName { get; set; }
        public RaporAl(string username)
        {
            InitializeComponent();
            this.yeniUserName = username;
        }

        public RaporYarat raporUser()
        {
            RaporYarat raporYarat = new RaporYarat();

            try
            {
                string strSQL = "SELECT acc.AdSoyad,drs.DersAdi,nots.DersNotu,nots.DersAciklamasi FROM tblNotlar nots left join tblDersler drs on drs.ID = nots.DersID left join tblUserAccounts acc on acc.UserID = nots.UserID where acc.TCKN = N'" + yeniUserName + "' ";
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand com = new SqlCommand(strSQL, con);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {

                    raporYarat.AdSoyad = rdr["AdSoyad"] == null ? string.Empty : rdr["AdSoyad"].ToString();
                    raporYarat.DersAdi = rdr["DersAdi"] == null ? string.Empty : rdr["DersAdi"].ToString();
                    raporYarat.DersNotu = rdr["DersNotu"] == null ? string.Empty : rdr["DersNotu"].ToString();
                    raporYarat.DersAciklamasi = rdr["DersAciklamasi"] == null ? string.Empty : rdr["DersAciklamasi"].ToString();

                }
                return raporYarat;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ben şu hatayı aldım : " + ex.Message.ToString());
                //Error Kaydet
                throw;
            }
        }

        private void RaporAl_Load(object sender, EventArgs e)
        {

            var veri = raporUser();


            var qrText = veri.AdSoyad + " " + veri.DersAdi + " " + veri.DersNotu + " " + veri.DersAciklamasi;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);


            pictureBox1.Image = qrCodeImage;
            pictureBox1.Height = qrCodeImage.Height;
            pictureBox1.Width = qrCodeImage.Width;

            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            //synthesizer.Speak(QRTEXT2);
            var builder = new PromptBuilder();
            builder.StartVoice(new CultureInfo("tr-TR"));
            builder.AppendText(qrText);
            builder.EndVoice();
            synthesizer.Speak(builder);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //var veri = raporUser();


            //var qrText = veri.AdSoyad + ", " + veri.DersAdi + ", " + veri.DersNotu + ", " + veri.DersAciklamasi;

            //var synthesizer = new SpeechSynthesizer();
            //synthesizer.SetOutputToDefaultAudioDevice();
            //synthesizer.Speak(qrText);
            //var builder = new PromptBuilder();
            //builder.StartVoice(new CultureInfo("tr-TR"));
            //builder.AppendText(qrText);
            //builder.EndVoice();
            //synthesizer.Speak(builder);
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

            var veri = raporUser();


            var qrText = veri.AdSoyad + ", " + veri.DersAdi + ", " + veri.DersNotu + ", " + veri.DersAciklamasi;

            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Speak(qrText);
            var builder = new PromptBuilder();
            builder.StartVoice(new CultureInfo("tr-TR"));
            builder.AppendText(qrText);
            builder.EndVoice();
            synthesizer.Speak(builder);
        }
    }
}
