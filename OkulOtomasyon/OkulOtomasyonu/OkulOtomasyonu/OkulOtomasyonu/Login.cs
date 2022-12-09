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
    public partial class Login : Form
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = userNameTextBox.Text;
            var password = passwordTextBox.Text;


            if (!System.Text.RegularExpressions.Regex.IsMatch(username, "^[0-9]*$"))
            {
                MessageBox.Show("TCKN sadece rakam içermelidir..");
                return;
            }

            if (username.Length != 11)
            {
                MessageBox.Show("TCKN eksik ya da yanlış girdiniz.");
                return;
            }

            try
            {
                string sorgu = "";
                sorgu = "SELECT TCKN,Sifre FROM tblUserAccounts where TCKN=@username AND Sifre=@password";


                using (SqlConnection con = new SqlConnection(connStr))
                {
                    var cmd = new SqlCommand(sorgu, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    con.Open();
                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                        if (ogrenciRadioButton.Checked == true)
                        {
                            //Öğrenci Form aç
                            OgrenciForm ogrenciForm = new OgrenciForm(username);
                            this.Hide();
                            ogrenciForm.Show();
                            

                        }
                        else if (ogretmenRadioButton.Checked == true)
                        {
                            //Öğretmen Form aç
                            OgretmenForm ogretmenForm = new OgretmenForm(username);
                            this.Hide();
                            ogretmenForm.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
