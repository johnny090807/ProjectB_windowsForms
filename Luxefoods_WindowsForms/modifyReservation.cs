﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxefoods_WindowsForms
{
    public partial class Modify_reservation : Form
    {
        // Allows the user to drag the window
        // This piece of code was taken from StackOverFlow https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Modify_reservation()
        {
            InitializeComponent();
            CenterToScreen();
            if (Login.person != null)
            {
                this.loginButton.Text = Login.person.voornaam + " " + Login.person.achternaam;
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

        private void aboutUsButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            aboutUs f1 = new aboutUs();
            f1.ShowDialog();
            this.Close();
        }

        private void reservationsButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            checkReservation f2 = new checkReservation(Login.person.id);
            f2.ShowDialog();
            this.Close();
        }

        private void contactUsButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            contactUs f1 = new contactUs();
            f1.ShowDialog();
            this.Close();
        }

        private void loginButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.previousPage = "ModifyReservation";
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

        private void menuButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.Show();
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
