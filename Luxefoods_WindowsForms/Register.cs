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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            CenterToScreen();
            this.AcceptButton = RegisterBtn;
        }

        static string EncryptPassword(string text)
        {
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(text));
                return Convert.ToBase64String(data);
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if(VoornaamTxtBox.Text == "" || AchternaamTxtBox.Text== "" || TelefoonTxtBox.Text== "" || EmailTxtBox.Text== "" || PasswordTxtBox.Text == "")
            {
                MessageBox.Show("Vul alle velden in.");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-TMQHDKHS;Initial Catalog=LuxeFoods;Integrated Security=True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = $"INSERT INTO [user] (voornaam, achternaam, email, telefoonnummer, password) VALUES  ('{VoornaamTxtBox.Text}', '{AchternaamTxtBox.Text}', '{EmailTxtBox.Text}', '{TelefoonTxtBox.Text}', '{EncryptPassword(PasswordTxtBox.Text)}')";

                    try
                    {
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Saved user");

                        Login form2 = new Login();
                        form2.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }
    }
}
