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
using System.Text.RegularExpressions;

namespace Luxefoods_WindowsForms
{
    public partial class Register : Form
    {

        public Login.User person = Login.person;
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
            string EmailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            
            if (VoornaamTxtBox.text == "Voornaam" || AchternaamTxtBox.text == "Achternaam" || TelefoonTxtBox.text == "Telefoon nummer" || EmailTxtBox.text == "Email" || PasswordTxtBox.text == "Wachtwoord" || VerifyPasswordTxtBox.text == "Vul nog een keer het wachtwoord in")
            {
                ErrorMessageLabel.Text = "Fill everything in.";
                return;
            }
            if(PasswordTxtBox.text.Length < 8 || PasswordTxtBox.text == "Password")
            {
                ErrorMessageLabel.Text = "Password needs to be longer";
                return;
            }
            if (!Regex.IsMatch(EmailTxtBox.text, EmailPattern))
            {
                ErrorMessageLabel.Text = "Please provide real email";
                return;
            }
            if (PasswordTxtBox.text != VerifyPasswordTxtBox.text)
            {
                ErrorMessageLabel.Text = "Passwords do not match";
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = $"INSERT INTO [user] (voornaam, achternaam, email, telefoonnummer, password, admin) VALUES  ('{VoornaamTxtBox.text}', '{AchternaamTxtBox.text}', '{EmailTxtBox.text}', '{TelefoonTxtBox.text}', '{EncryptPassword(PasswordTxtBox.text)}', '0')";

                    try
                    {
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show($"Thanks for creating an account! {VoornaamTxtBox.text} {AchternaamTxtBox.text}");
                        this.Hide();
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
            //Template form2 = new Template();
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void EnterTxtBox(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuTextbox clickedTextbox = (Bunifu.Framework.UI.BunifuTextbox)sender;
            if (clickedTextbox.text == "Voornaam")
            {
                clickedTextbox.text = "";
            }
            else if (clickedTextbox.text == "Achternaam")
            {
                clickedTextbox.text = "";
            }
            else if (clickedTextbox.text == "Email")
            {
                clickedTextbox.text = "";
            }
            else if (clickedTextbox.text == "Telefoon nummer")
            {
                clickedTextbox.text = "";
            }
            else if (clickedTextbox.text == "Wachtwoord")
            {
                clickedTextbox.text = "";
            }
            else if (clickedTextbox.text == "Vul nog een keer het wachtwoord in")
            {
                clickedTextbox.text = "";
            }
        }
        private void LeaveTxtBox(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuTextbox clickedTextbox = (Bunifu.Framework.UI.BunifuTextbox)sender;
            if (clickedTextbox.TabIndex == 0 && clickedTextbox.text == "")
            {
                clickedTextbox.text = "Voornaam";
            }
            else if (clickedTextbox.TabIndex == 1 && clickedTextbox.text == "")
            {
                clickedTextbox.text = "Achternaam";
            }
            else if (clickedTextbox.TabIndex == 2 && clickedTextbox.text == "")
            {
                clickedTextbox.text = "Email";
            }
            else if (clickedTextbox.TabIndex == 3 && clickedTextbox.text == "")
            {
                clickedTextbox.text = "Telefoon nummer";
            }
            else if (clickedTextbox.TabIndex == 4 && clickedTextbox.text == "")
            {
                clickedTextbox.text = "Wachtwoord";
            }
            else if (clickedTextbox.TabIndex == 5 && clickedTextbox.text == "")
            {
                clickedTextbox.text = "Vul nog een keer het wachtwoord in";
            }
        }
    }
}
