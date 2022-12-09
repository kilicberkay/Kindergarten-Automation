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
    public partial class DersEkle : Form
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public DersEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dersAdi = DersAdiTextBox.Text;
            var dersKodu = DersKoduTextBox.Text;


            try
            {
                int rows;
                string sorgu = "";
                sorgu = "Insert Into tblDersler ( DersAdi, DersKodu) Values (@DersAdi, @DersKodu)";


                using (SqlConnection con = new SqlConnection(connStr))
                {
                    var cmd = new SqlCommand(sorgu, con);
                    cmd.Parameters.AddWithValue("@DersAdi", dersAdi);
                    cmd.Parameters.AddWithValue("@DersKodu", dersKodu);
                    con.Open();
                    rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Tebrikler! Ders kaydı başarılı");

                       
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
