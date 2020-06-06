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
    public partial class checkReservation : Form
    {
        public checkReservation()
        {
            InitializeComponent();
            CenterToScreen();
            if (Login.person != null)
            {
                this.LoginBtn.Text = "Logout";
            }
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
        private void aboutUsButton_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            aboutUs f1 = new aboutUs();
            f1.ShowDialog();
            this.Close();
        }

        private void reservationsButton_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                Reservation f2 = new Reservation(Login.person.id);
                this.Hide();
                f2.ShowDialog();
                this.Close();

            }
            catch(Exception er)
            {
                MessageBox.Show("Je moet ingelogd zijn.");
            }
        }

        private void contactUsButton_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            contactUs f1 = new contactUs();
            f1.ShowDialog();
            this.Close();
        }

        private void homePageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homeForm = new homePage();
            homeForm.Show();
        }

        private void aboutUsButton_LinkClicked_1(object sender, EventArgs e)
        {
            this.Hide();
            aboutUs aboutForm = new aboutUs();
            aboutForm.Show();
        }

        private void menuButton_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.Show();
        }

        private void loginButton_LinkClicked(object sender, EventArgs e)
        {
            Login.previousPage = "checkReservations";
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
}
