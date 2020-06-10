using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxefoods_WindowsForms
{
    public partial class aboutUs : Form
    {
        public aboutUs()
        {
            InitializeComponent();
            CenterToScreen();
            if (Login.person != null)
            {
                this.LoginBtn.Text = "Logout";
            }
            AboutBtn.BackColor = Color.FromArgb(100, Color.Black);
        }

        private void AvailabilityTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
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

       
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LuxeFoodsLogoLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homeForm = new homePage();
            homeForm.Show();

        }

        private void menuButton_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            checkReservation reservationForm = new checkReservation();
            reservationForm.Show();
        }

        private void reservationsButton_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                Reservation reservationForm = new Reservation(Login.person.id);
                this.Hide();
                reservationForm.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("Je moet eerst ingelogd zijn.");
            }

        }

        private void contactUsButton_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            contactUs contactForm = new contactUs();
            contactForm.Show();
        }

        private void loginButton_LinkClicked(object sender, EventArgs e)
        {
            Login.previousPage = "AboutUs";
            if (Login.person != null)
            {
                this.Hide();
                Template form1 = new Template();
                form1.Show();
            }
            else
            {
                this.Hide();
                Login form2 = new Login();
                form2.Show();
            }
        }

        private void FullscreenBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FullscreenBtn.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.expand;
                WindowState = FormWindowState.Normal;
            }
            else
            {
                FullscreenBtn.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.compress;
                WindowState = FormWindowState.Maximized;
            }
        }
    }

    /*
     * ----- CHECK AVAILABILITY BUTTON -----
     * People = seats.value
     * Date = dateTimePicker1.value
     * TableSize = 4
     * TablesNeeded = People // TableSize
     * ShowAvailableTables(TablesNeeded)
     * 
     * 
     * 
     * ----- ShowShowAvailableTables(int amountOfTables) -----
     * fetch data from the database
     * look for amounrOfTables in the same zone for the same time
     * 
     *
     * 
     * 
     */
}
