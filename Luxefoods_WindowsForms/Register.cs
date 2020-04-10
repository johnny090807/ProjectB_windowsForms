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
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(text));
                return Convert.ToBase64String(data);
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (VoornaamTxtBox.Text == "" || AchternaamTxtBox.Text == "" || TelefoonTxtBox.Text == "" || EmailTxtBox.Text == "" || PasswordTxtBox.Text == "" || VerifyPasswordTxtBox.Text == "")
            {
                MessageBox.Show("Fill everything in.");
            }
            else if(PasswordTxtBox.TextLength < 8)
            {
                MessageBox.Show("Password needs to be longer");
            }
            else if(PasswordTxtBox.Text != VerifyPasswordTxtBox.Text)
            {
                label6.Text = "Password doesn't match";
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
                        this.Hide();
                        Login form2 = new Login();
                        form2.Show();
                        this.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void label7_Hover_Enter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void label7_Hover_Leave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Hover_Enter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_Hover_Leave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }
    }
}
