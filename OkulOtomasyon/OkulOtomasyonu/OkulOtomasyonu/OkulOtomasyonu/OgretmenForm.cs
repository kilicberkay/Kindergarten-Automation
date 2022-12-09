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
    public partial class OgretmenForm : Form
    {

        public static string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public string LoginTCKNOgretmen { get; set; }
        public OgretmenForm(string username)
        {
            InitializeComponent();
            this.LoginTCKNOgretmen = username;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            DersEkle dersEkle = new DersEkle();
            dersEkle.Show();
        }

        private void DersAtaButton_Click(object sender, EventArgs e)
        {
            DersAta dersAta = new DersAta();
            dersAta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var secilenID = SecilenNotGirTxt.Text;

            if (secilenID != "")
            {
                try
                {
                    NotGir notGir = new NotGir(secilenID, LoginTCKNOgretmen);
                    this.Hide();
                    notGir.Show();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Şu hata oldu : " + ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Tablodan Veri Seçiniz!!");
            }
        }

        private void OgretmenForm_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connStr);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT nots.ID, acc.TCKN,acc.AdSoyad,drs.DersAdi,drs.DersKodu,nots.DersNotu,nots.DersAciklamasi  FROM tblNotlar nots left join tblDersler drs on drs.ID = nots.DersID left join tblUserAccounts acc on acc.UserID = nots.UserID";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var secilenID = SecilenNotGirTxt.Text;

            if (secilenID != "")
            {
                try
                {
                    NotGir notGir = new NotGir(secilenID, LoginTCKNOgretmen);
                    this.Hide();
                    notGir.Show();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Şu hata oldu : " + ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Tablodan Veri Seçiniz!!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                int value = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                SecilenNotGirTxt.Text = value.ToString();

            }
        }
    }
}
