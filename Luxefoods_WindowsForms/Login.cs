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
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
            this.AcceptButton = LoginBtn;
            this.SetStyle(ControlStyles.UserPaint, true);
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
                string q = $"SELECT DISTINCT * FROM [user] WHERE email='{EmailCheck.Text}'";
                string password = "";
                string typedPassword = EncryptPassword(PasswordCheck.Text);
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
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
                        if (typedPassword == password)
                        {
                            MessageBox.Show("Je bent nu ingelogd.");
                            this.Hide();
                            reservation registerForm = new reservation();
                            registerForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("deze gebruiker bestaat niet, of het wachtwoord is verkeerd ingevuld.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void label4_Hover_Enter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void label4_Hover_Leave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Hover_Enter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_Hover_Leave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

