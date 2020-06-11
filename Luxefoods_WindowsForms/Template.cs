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
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
            CenterToScreen();
            this.label1.Text = Login.person.voornaam;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            CheckWhichFormWasOpened();
            
        }

        private void ExitButton_Hover_Enter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Red;
        }

        private void ExitButton_Hover_Leave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Black;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeButton_Hover_Enter(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.Red;
        }
        private void MinimizeButton_Hover_Leave(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.Black;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login.person = null;
            this.Hide();
            Menu form1 = new Menu();
            form1.Show();
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
            else if (previousPage == "checkReservations")
            {
                this.Hide();
                checkReservation checkReservationForm = new checkReservation(Login.person.id);
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
