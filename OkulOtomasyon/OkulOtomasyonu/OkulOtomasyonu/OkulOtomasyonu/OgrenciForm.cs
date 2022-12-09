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
    public partial class OgrenciForm : Form
    {

        public static string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public string LoginTCKNOgrenci { get; set; }
        public OgrenciForm(string username)
        {
            InitializeComponent();
            this.LoginTCKNOgrenci = username;
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connStr);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT nots.ID, acc.TCKN,acc.AdSoyad,drs.DersAdi,drs.DersKodu,nots.DersNotu,nots.DersAciklamasi  FROM tblNotlar nots left join tblDersler drs on drs.ID = nots.DersID left join tblUserAccounts acc on acc.UserID = nots.UserID where acc.TCKN = N'" + LoginTCKNOgrenci + "' ";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporAl raporAl = new RaporAl(LoginTCKNOgrenci);
            raporAl.Show();
        }
    }
}
