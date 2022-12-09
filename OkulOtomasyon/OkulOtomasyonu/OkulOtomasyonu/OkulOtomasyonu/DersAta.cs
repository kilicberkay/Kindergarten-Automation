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
    public partial class DersAta : Form
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public DersAta()
        {
            InitializeComponent();
        }

        private void DersAta_Load(object sender, EventArgs e)
        {
          
            

            SqlConnection cnn = new SqlConnection(connStr);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT UserID,TCKN,AdSoyad FROM tblUserAccounts where isTeacher = 0";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView2.DataSource = dtRecord;

            SqlConnection cnn2 = new SqlConnection(connStr);

            SqlCommand sqlCmd2 = new SqlCommand();
            sqlCmd2.Connection = cnn2;
            sqlCmd2.CommandType = CommandType.Text;
            sqlCmd2.CommandText = "SELECT * FROM tblDersler";
            SqlDataAdapter sqlDataAdap2 = new SqlDataAdapter(sqlCmd2);

            DataTable dtRecord2 = new DataTable();
            sqlDataAdap2.Fill(dtRecord2);
            dataGridView1.DataSource = dtRecord2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var atanacakDersKodu = atanacakDerstxt.Text;
            var OgrenciUserIDKodu = OgrenciUserIDTxt.Text;


            try
            {
                int rows;
                string sorgu = "";
                sorgu = "Insert Into tblNotlar ( UserID, DersID, DersNotu, DersAciklamasi) Values (@UserID, @DersID, @DersNotu, @DersAciklamasi)";


                using (SqlConnection con = new SqlConnection(connStr))
                {
                    var cmd = new SqlCommand(sorgu, con);
                    cmd.Parameters.AddWithValue("@UserID", OgrenciUserIDKodu);
                    cmd.Parameters.AddWithValue("@DersID", atanacakDersKodu);
                    cmd.Parameters.AddWithValue("@DersNotu", "");
                    cmd.Parameters.AddWithValue("@DersAciklamasi", "");
                    con.Open();
                    rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Tebrikler! Ders atama başarılı");


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



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                int value = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                OgrenciUserIDTxt.Text = value.ToString();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                int value = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                atanacakDerstxt.Text = value.ToString();

            }

        }
    }
}
