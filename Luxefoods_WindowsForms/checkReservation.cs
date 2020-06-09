using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxefoods_WindowsForms
{
    public partial class checkReservation : Form
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

        public checkReservation()
        {
            InitializeComponent();
            CenterToScreen();
            if (Login.person != null)
            {
                this.loginButton.Text = Login.person.voornaam + " " + Login.person.achternaam;
            }
            searchReservationById(Login.person.id);
        }

        private void searchReservationById(int Id, DateTime date = new DateTime())
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [user] WHERE id='{Id}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Users");
            adapt.Fill(ds, "Users");
            con.Close();

            DataTable tblUsers = ds.Tables["Users"];

            DataRow[] row = tblUsers.Select();

            listBox1.Items.Clear();

            foreach (var y in row)
            {
                int userId = (int)y.ItemArray[0];

                con.Open();
                read = new SqlCommand($"SELECT * from [reservering] WHERE klantId='{userId}'", con);
                adapt = new SqlDataAdapter(read);
                adapt.FillSchema(ds, SchemaType.Source, "Reserveringen");
                adapt.Fill(ds, "Reserveringen");
                con.Close();

                

                DataTable tblReserveringen = ds.Tables["Reserveringen"];

                listBox1.Items.Clear();
                if (tblReserveringen != null)
                {
                    foreach (DataRow x in tblReserveringen.Rows)
                    {
                        int rowCounter = 0;
                        foreach (var i in row)
                        {
                            if ((int)i.ItemArray[0] == (int)x.ItemArray[2])
                            {
                                break;
                            }
                            else
                            {
                                rowCounter++;
                            }
                        }

                        con.Open();
                        read = new SqlCommand($"SELECT * from [restaurant] WHERE id='{(int)x["restaurantId"]}'", con);
                        adapt = new SqlDataAdapter(read);
                        adapt.FillSchema(ds, SchemaType.Source, "Restauranten");
                        adapt.Fill(ds, "Restauranten");
                        con.Close();

                        DataTable tblRestauranten = ds.Tables["Restauranten"];

                        DataRow[] restaurant = tblRestauranten.Select();

                        string restaurantName = restaurant[(int)x["restaurantId"]-1].ItemArray[1].ToString();
                        string orderId = x["id"].ToString();
                        string orderDate = x["datum"].ToString();
                        string orderTableNr = x["tafelNummer"].ToString();
                        listBox1.Items.Add("Restaurant Name: " + restaurantName + "   Reservation ID: " + orderId + "   Reservation Date: " + orderDate + "   Reservation Table Number: " + orderTableNr);
                    }
                }
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
            Reservation f2 = new Reservation(Login.person.id);
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homeForm = new homePage();
            homeForm.Show();
        }

        private void aboutUsButton_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            aboutUs aboutForm = new aboutUs();
            aboutForm.Show();
        }

        private void menuButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.Show();
        }

        private void loginButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.previousPage = "checkReservations";
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
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
