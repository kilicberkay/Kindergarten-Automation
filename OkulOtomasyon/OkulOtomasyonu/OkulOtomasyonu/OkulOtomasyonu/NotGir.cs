using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
    public partial class NotGir : Form
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public string secilenUserID { get; set; }
        public string secilenUserTCKN { get; set; }
        public NotGir(string secilenID,string secilenTCKN)
        {
            InitializeComponent();
            this.secilenUserID = secilenID;
            this.secilenUserTCKN = secilenTCKN;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var DersNotuText = DersNotuGirOgrenciTxt.Text;
            var DersAciklamasiText = DersAciklamaGirTxt.Text;


            try
            {
                int rows;
                string sorgu = "";
                sorgu = "Update tblNotlar Set DersNotu = @DersNotuText, DersAciklamasi = @DersAciklamasiText Where ID = @secilenUserID ";


                using (SqlConnection con = new SqlConnection(connStr))
                {
                    var cmd = new SqlCommand(sorgu, con);
                    cmd.Parameters.AddWithValue("@DersNotuText", DersNotuText);
                    cmd.Parameters.AddWithValue("@DersAciklamasiText", DersAciklamasiText);
                    cmd.Parameters.AddWithValue("@secilenUserID", secilenUserID);
                    con.Open();
                    rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Tebrikler! Not kaydı başarılıdır!");
                        
                        this.Close();
                        OgretmenForm ogretmen = new OgretmenForm(secilenUserTCKN.ToString());
                        ogretmen.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ders kaydedilemedi!!");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ben şu hatayı aldım : " + ex.Message.ToString());
                //Error Kaydet
                throw;
            }
        }
    }
}
