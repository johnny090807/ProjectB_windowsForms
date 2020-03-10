using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Luxefoods_WindowsForms
{
    public partial class Login : Form
    {
        static Boolean CheckPassword(string text, string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(password));
                Convert.ToBase64String(data);
                if(text == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
            this.AcceptButton = LoginBtn;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register form1 = new Register();
            form1.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (EmailCheck.Text == "" || PasswordCheck.Text == "")
            {
                MessageBox.Show("Vul alle velden in.");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-TMQHDKHS;Initial Catalog=LuxeFoods;Integrated Security=True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = $"SELECT DISTINCT * FROM [user] WHERE email={EmailCheck.Text}";
                    string password = "";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            password = dr["password"].ToString();
                        }

                    
                        if (CheckPassword(PasswordCheck.Text , password))
                        {
                            MessageBox.Show("Je bent nu ingelogd.");
                        }
                        else
                        {
                            MessageBox.Show("deze gebruiker bestaat niet, of het wachtwoord is verkeerd ingevuld.");
                        }   
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                  
                }
            }
        }
    }
}
