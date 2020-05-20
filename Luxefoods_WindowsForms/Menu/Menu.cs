using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxefoods_WindowsForms
{
    public partial class Menu : Form
    {

        Button clickedButton = new Button();
        public Login.User person = Login.person;
        public Menu()
        {
            InitializeComponent();/*
            MenuPanel.Height = SpecialsBTN.Height;
            MenuPanel.Top = SpecialsBTN.Top;*/
            faqANS1.Visible = false;
            faqANS3.Visible = false;
            faqANS2.Visible = false;
            faqANS4.Visible = false;
            openChildForm(new MenuSpecial());
            if(person != null)
            {
                this.LoginBTN.Text = person.voornaam + " " + person.achternaam;
            }
            this.addButtonsToPanel();
            
        }
       
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login.previousPage = "Menu";
            if(Login.person != null)
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

        private void getMenuItems(object sender, EventArgs e)
        { 
            openChildForm(new MenuSpecial());
            clickedButton = (Button)sender;
            MenuPanel.Height = clickedButton.Height;
            MenuPanel.Top = clickedButton.Top;
            
        }
                
        private void faqBTN1_Click(object sender, EventArgs e)
        {
            faqANS1.Visible = !faqANS1.Visible;
        }

        private void faqBTN3_Click(object sender, EventArgs e)
        {
            faqANS3.Visible = !faqANS3.Visible;
        }

        private void faqBTN2_Click(object sender, EventArgs e)
        {
            faqANS2.Visible = !faqANS2.Visible;
        }

        private void faqBTN4_Click(object sender, EventArgs e)
        {
            faqANS4.Visible = !faqANS4.Visible;
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FullscreenBtn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void addButtonsToPanel()
        {
            string q = $"SELECT * FROM restaurant";
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
                    int i = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        Button extraButton = new Button
                        {
                            ForeColor = System.Drawing.Color.White,
                            BackColor = System.Drawing.Color.Black,
                            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center,
                            Dock = System.Windows.Forms.DockStyle.Top
                        };
                        extraButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
                        extraButton.FlatAppearance.BorderSize = 0;
                        extraButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                        extraButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                        extraButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                        extraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        extraButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        extraButton.ForeColor = System.Drawing.Color.White;
                        extraButton.Location = new System.Drawing.Point(0 + 80 * i, 0);
                        extraButton.Name = dr["naam"].ToString();
                        extraButton.Size = new System.Drawing.Size(228, 75);
                        extraButton.TabIndex = 0;
                        extraButton.Text = dr["naam"].ToString();
                        extraButton.UseVisualStyleBackColor = false;
                        extraButton.Click += new System.EventHandler(this.getMenuItems);
                        SideBar.Controls.Add(extraButton);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int iteration = 6;
            for(int i = 0; i < iteration; i++)
            {
                
            }
        }

        private void AboutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            aboutUs aboutForm = new aboutUs();
            aboutForm.Show();
        }

        private void ContactBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactUs contactForm = new contactUs();
            contactForm.Show();
        }

        private void ReservationsBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation reservationForm = new Reservation();
            reservationForm.Show();
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homeForm = new homePage();
            homeForm.Show();
        }
    }
}
