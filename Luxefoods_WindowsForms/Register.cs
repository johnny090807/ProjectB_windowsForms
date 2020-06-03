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
            
            if (VoornaamTxtBox.Text == "Voornaam" || AchternaamTxtBox.Text == "Achternaam" || TelefoonTxtBox.Text == "Telefoon nummer" || EmailTxtBox.Text == "Email" || PasswordTxtBox.Text == "Wachtwoord" || VerifyPasswordTxtBox.Text == "Vul nog een keer het wachtwoord in")
            {
                ErrorMessageLabel.Text = "Fill everything in.";
                return;
            }
            if(PasswordTxtBox.Text.Length < 8 || PasswordTxtBox.Text == "Password")
            {
                ErrorMessageLabel.Text = "Password needs to be longer";
                return;
            }
            if (!Regex.IsMatch(EmailTxtBox.Text, EmailPattern))
            {
                ErrorMessageLabel.Text = "Please provide real email";
                return;
            }
            if (PasswordTxtBox.Text != VerifyPasswordTxtBox.Text)
            {
                ErrorMessageLabel.Text = "Passwords do not match";
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = $"INSERT INTO [user] (voornaam, achternaam, email, telefoonnummer, password, admin) VALUES  ('{VoornaamTxtBox.Text}', '{AchternaamTxtBox.Text}', '{EmailTxtBox.Text}', '{TelefoonTxtBox.Text}', '{EncryptPassword(PasswordTxtBox.Text)}', '0')";

                    try
                    {
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show($"Thanks for creating an account! {VoornaamTxtBox.Text} {AchternaamTxtBox.Text}");
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
            this.CheckWhichFormWasOpened();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void EnterTxtBox(object sender, EventArgs e)
        {
            TextBox clickedTextbox = (TextBox)sender;
            if (clickedTextbox.Text == "Voornaam")
            {
                clickedTextbox.Text = "";
            }
            else if (clickedTextbox.Text == "Achternaam")
            {
                clickedTextbox.Text = "";
            }
            else if (clickedTextbox.Text == "Email")
            {
                clickedTextbox.Text = "";
            }
            else if (clickedTextbox.Text == "Telefoon nummer")
            {
                clickedTextbox.Text = "";
            }
        }
        private void LeaveTxtBox(object sender, EventArgs e)
        {
            TextBox clickedTextbox = (TextBox)sender;
            if (clickedTextbox.TabIndex == 0 && clickedTextbox.Text == "")
            {
                clickedTextbox.Text = "Voornaam";
            }
            else if (clickedTextbox.TabIndex == 1 && clickedTextbox.Text == "")
            {
                clickedTextbox.Text = "Achternaam";
            }
            else if (clickedTextbox.TabIndex == 2 && clickedTextbox.Text == "")
            {
                clickedTextbox.Text = "Email";
            }
            else if (clickedTextbox.TabIndex == 3 && clickedTextbox.Text == "")
            {
                clickedTextbox.Text = "Telefoon nummer";
            }
        }
        public void CheckWhichFormWasOpened()
        {
            string previousPage = Login.previousPage;
            if (previousPage == "Menu")
            {
                Menu menuForm = new Menu();
                menuForm.Show();
                this.Hide();
            }
            else if (previousPage == "Reservation")
            {
                this.Hide();
                Reservation reservationForm = new Reservation(Login.person.id);
                reservationForm.Show();
            }
            else if (previousPage == "Dashboard")
            {
                this.Hide();
                Dashboard dashboardForm = new Dashboard(person.id);
                dashboardForm.Show();
            }
            else if (previousPage == "checkReservations")
            {
                this.Hide();
                checkReservation checkReservationForm = new checkReservation();
                checkReservationForm.Show();
            }
            else if (previousPage == "ContactUs")
            {
                this.Hide();
                contactUs contactForm = new contactUs();
                contactForm.Show();
            }
            else if (previousPage == "AboutUs")
            {
                this.Hide();
                aboutUs aboutForm = new aboutUs();
                aboutForm.Show();
            }
            else if (previousPage == "Home")
            {
                this.Hide();
                homePage homeForm = new homePage();
                homeForm.Show();
            }
            else
            {
                this.Hide();
                Register registerForm = new Register();
                registerForm.Show();
            }

            }
    }
}
