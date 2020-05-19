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
        public static User person = null;
        public class User
        {
            public int id { get; set; }
            public string voornaam { get; set; }
            public string achternaam { get; set; }
            public string email { get; set; }
            public string telefoonnummer { get; set; }
            public string password { get; set; }
            public bool admin{ get; set; }
            public User(int ID, string first, string last, string e, string t, string pass, bool Admin = false)
            {
                id = ID;
                voornaam = first;
                achternaam = last;
                email = e;
                telefoonnummer = t;
                password = pass;
                admin = Admin;
            }
        }
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
            this.AcceptButton = LoginBtn;
            this.SetStyle(ControlStyles.UserPaint, true);
            if (person != null)
            {
                this.Hide();
                Template form2 = new Template();
                form2.Show();
            }
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
                            person = new User((int) dr["id"] ,dr["voornaam"].ToString(), dr["achternaam"].ToString(), dr["email"].ToString(), dr["telefoonnummer"].ToString(), dr["password"].ToString(), (bool)dr["admin"]);
                        }
                        if (typedPassword == password)
                        {
                            this.Hide();
                            if (person.admin)
                            {
                                Dashboard dashboardForm = new Dashboard(person.id);
                                dashboardForm.Show();
                            } else
                            {
                                FormCollection fc = Application.OpenForms;
                                foreach (Form frm in fc)
                                {
                                    if (frm.Name == "MenuSpecial")
                                    {
                                        Menu menuForm = new Menu();
                                        menuForm.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        Register registerForm = new Register();
                                        registerForm.Show();
                                        this.Hide();
                                    }
                                }
                            }
                        }
                        else
                        {
                            person = null;
                            MessageBox.Show("deze gebruiker bestaat niet, of het wachtwoord is verkeerd ingevuld.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            menuForm.Show();
            this.Hide();
        }
        
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}

