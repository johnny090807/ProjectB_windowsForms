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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            MenuPanel.Height = SpecialsBTN.Height;
            MenuPanel.Top = SpecialsBTN.Top;
            faqANS1.Visible = false;
            faqANS2.Visible = false;
            faqANS3.Visible = false;
            faqANS4.Visible = false;
            openChildForm(new MenuSpecial());
        }
       
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ContactBTN_Click(object sender, EventArgs e)
        {

        }

        private void MenuBTN_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuPanel.Height = FishBTN.Height;
            MenuPanel.Top = FishBTN.Top;
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuSoups());
            MenuPanel.Height = SoupBTN.Height;
            MenuPanel.Top = SoupBTN.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MenuPanel.Height = DessertBTN.Height;
            MenuPanel.Top = DessertBTN.Top;
        }

        private void SpecialsBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuSpecial());
            MenuPanel.Height = SpecialsBTN.Height;
            MenuPanel.Top = SpecialsBTN.Top;
            
        }

        private void HorsBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuHors());
            MenuPanel.Height = HorsBTN.Height;
            MenuPanel.Top = HorsBTN.Top;
        }

        private void MainBTN_Click(object sender, EventArgs e)
        {
            MenuPanel.Height = MainBTN.Height;
            MenuPanel.Top = MainBTN.Top;
        }

        private void SaladeBTN_Click(object sender, EventArgs e)
        {
            MenuPanel.Height = SaladeBTN.Height;
            MenuPanel.Top = SaladeBTN.Top;
        }

        private void WineBTN_Click(object sender, EventArgs e)
        {
            MenuPanel.Height = WineBTN.Height;
            MenuPanel.Top = WineBTN.Top;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (faqANS1.Visible == true)
                faqANS1.Visible = false;
            else
                faqANS1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void faqANS2_Click(object sender, EventArgs e)
        {

        }

        private void faqBTN3_Click(object sender, EventArgs e)
        {
               if (faqANS2.Visible == true)
                faqANS2.Visible = false;
            else
                faqANS2.Visible = true;
        }

        private void faqBTN2_Click(object sender, EventArgs e)
        {
            if (faqANS3.Visible == true)
                faqANS3.Visible = false;
            else
                faqANS3.Visible = true;
        }

        private void faqBTN4_Click(object sender, EventArgs e)
        {
            if (faqANS4.Visible == true)
                faqANS4.Visible = false;
            else
                faqANS4.Visible = true;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(childForm);
            ContainerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
