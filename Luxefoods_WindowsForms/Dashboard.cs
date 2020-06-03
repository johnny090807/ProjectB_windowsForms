using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Luxefoods_WindowsForms
{
    public partial class Dashboard : Form
    {
        // Allows the user to drag the window
        // This piece of code was taken from StackOverFlow https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private int globalAdminID;
        public Dashboard(int adminID)
        {
            globalAdminID = adminID;
            InitializeComponent();
            CenterToScreen();
            fillChart(DateTime.Now);
            fillListBox();
            fillReservationListBox(DateTime.Now);
            fillAdminInfo(adminID);
            EditReservationButton.Hide();
            //WindowState = FormWindowState.Maximized;
        }

        private void fillAdminInfo(int adminID)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds2 = new DataSet();
            con.Open();
            SqlCommand customerInfo = new SqlCommand($"SELECT * from [user] WHERE id='{adminID}'", con);
            SqlDataAdapter da = new SqlDataAdapter(customerInfo);
            da.FillSchema(ds2, SchemaType.Source, "Customer");
            da.Fill(ds2, "Customer");
            con.Close();
            DataTable tblCustomerInfo = ds2.Tables["Customer"];
            foreach (DataRow i in tblCustomerInfo.Rows)
            {
                label1.Text = "Welcome " + i["voornaam"].ToString() + "!";
            }
        }

        private void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void fillChart(DateTime date, int restaurantId = 1)
        {
            List<DateTime> Datums = new List<DateTime>();

            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT datum from [reservering] WHERE datum between '{date.Year} - {date.Month} - {date.Day}  00:00:00' and '{date.Year} - {date.Month} - {date.Day} 23:59:59' and restaurantId='{restaurantId}'", con);
            using (SqlDataReader reader = read.ExecuteReader())
            {
                while (reader.Read())
                {
                    Datums.Add(reader.GetDateTime(0));
                }

                con.Close();
            }

            chart1.Series["Customers"].Points.Clear();


            int openTime = 7;
            int time = 16;
            for (var i = 0; i < openTime; i++)
            {
                int count = 0;
                foreach (var x in Datums) {
                    if (x.TimeOfDay.Hours == time) {
                        count++;
                    }
                }

                chart1.Series["Customers"].Points.AddXY(time + ":00-" + (time+1) + ":00", count);
                time++;
            }

            chart1.Titles.Clear();
            chart1.Titles.Add("Reservations for " + date.ToShortDateString());
        }

        private void fillListBox()
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [restaurant]", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Restaurants");
            adapt.Fill(ds, "Restaurants");
            con.Close();

            DataTable tblRestaurants;
            tblRestaurants = ds.Tables["Restaurants"];

            if (tblRestaurants != null)
            {
                restaurantListBox.ValueMember = "id";
                restaurantListBox.DisplayMember = "naam";
                restaurantListBox.DataSource = tblRestaurants;
            }
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dashboardRefresher();
        }

        private void listIndexChange(object sender, EventArgs e)
        {
            dashboardRefresher();
        }

        private void dashboardRefresher()
        {
            if (monthCalendar1.SelectionStart.ToShortDateString() == monthCalendar1.SelectionEnd.ToShortDateString())
            {
                var pickedDate = monthCalendar1.SelectionStart;
                fillChart(pickedDate, (int)restaurantListBox.SelectedValue);
                fillReservationListBox(pickedDate, (int)restaurantListBox.SelectedValue);
            }
        }

        private void fillReservationListBox(DateTime date, int restaurantId = 1)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT Id, klantId, datum, tafelNummer from [reservering] WHERE datum between '{date.Year} - {date.Month} - {date.Day}  00:00:00' and '{date.Year} - {date.Month} - {date.Day} 23:59:59' and restaurantId='{restaurantId}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Reserveringen");
            adapt.Fill(ds, "Reserveringen");
            con.Close();

            DataTable tblReserveringen;
            tblReserveringen = ds.Tables["Reserveringen"];

            ordersListBox.Items.Clear();

            if (tblReserveringen != null)
            {
                DataSet ds2 = new DataSet();
                foreach (DataRow x in tblReserveringen.Rows)
                {
                    con.Open();
                    SqlCommand customerInfo = new SqlCommand($"SELECT * from [user] WHERE id='{x["klantId"]}'", con);
                    SqlDataAdapter da = new SqlDataAdapter(customerInfo);
                    da.FillSchema(ds2, SchemaType.Source, "Customer");
                    da.Fill(ds2, "Customer");
                    con.Close();

                    DataTable tblCustomerInfo = ds2.Tables["Customer"];

                    DataRow[] row = tblCustomerInfo.Select();
                    int rowCounter = 0;
                    foreach (var i in row)
                    {
                        if ((int) i.ItemArray[0] == (int) x.ItemArray[1])
                        {
                            break;
                        } else
                        {
                            rowCounter++;
                        }
                    }

                    string orderId = x["Id"].ToString();
                    string customerId = row[rowCounter].ItemArray[0].ToString();
                    string customerFirstName = row[rowCounter].ItemArray[1].ToString();
                    string customerLastName = row[rowCounter].ItemArray[2].ToString();
                    string customerEmail = row[rowCounter].ItemArray[3].ToString();
                    string customerPhone = row[rowCounter].ItemArray[4].ToString();
                    string orderDate = x["datum"].ToString();
                    string orderTableNr = x["tafelNummer"].ToString();
                    ordersListBox.Items.Add("Reservation ID: " + orderId + "   Customer ID: " + customerId + "   Customer Name: " + customerFirstName + " " + customerLastName + "   Customer Email: " + customerEmail + "   Customer Phone Number: " + customerPhone + "   Reservation Date: " + orderDate + "   Reservation Table Number: " + orderTableNr);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersListBox.SelectedItem != null)
            {
                EditReservationButton.Show();
            } else
            {
                EditReservationButton.Hide();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strSource = ordersListBox.SelectedItem.ToString();
                string strStart = "Reservation ID:";
                string strEnd = "Customer ID:";
                if (strSource.Contains(strStart) && strSource.Contains(strEnd))
                {
                    int start, end;
                    start = strSource.IndexOf(strStart, 0) + strStart.Length;
                    end = strSource.IndexOf(strEnd, start);
                    string reservationID = strSource.Substring(start, end - start);

                    string ID = string.Empty;

                    for (int i = 0; i < reservationID.Length; i++)
                    {
                        if (Char.IsDigit(reservationID[i]))
                        {
                            ID += reservationID[i];
                        }
                    }

                    int intId = Int32.Parse(ID);

                    this.Hide();
                    AdminOrderReviewDashboard adminOrderReviewDashboard = new AdminOrderReviewDashboard(intId, globalAdminID, "dashboard");
                    adminOrderReviewDashboard.Show();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text != "" && SearchComboBox.SelectedItem != null)
            {
                int i = 0;
                if (SearchComboBox.SelectedItem.ToString() == "ID" && !(int.TryParse(inputField.Text, out i)))
                {
                    MessageBox.Show("Please write a correct ID");
                } else if (SearchComboBox.SelectedItem.ToString() == "Name" && int.TryParse(inputField.Text, out i))
                {
                    MessageBox.Show("Please write a correct name");
                } else if (SearchComboBox.SelectedItem.ToString() == "Phone Number" && !(int.TryParse(inputField.Text, out i)))
                {
                    MessageBox.Show("Please write a correct phone number");
                } else if (SearchComboBox.SelectedItem.ToString() == "E-Mail" && !(IsValidEmail(inputField.Text)))
                {
                    MessageBox.Show("Please write a correct E-Mail Adress");
                } else
                {
                    this.Hide();
                    SearchPage searchPage = new SearchPage(SearchComboBox.SelectedItem.ToString(), globalAdminID, inputField.Text, "dashboard");
                    searchPage.Show();
                }
            } else
            {
                MessageBox.Show("Enter Something or Choose The Filter Type!");
            }
        }

        private void SearchComboBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
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

        private void logoutButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.previousPage = "Dashboard";
            if(Login.person != null)
            {
                this.Hide();
                Template form1 = new Template();
                form1.Show();
            }
            else
            {
                this.Hide();
                Login form1 = new Login();
                form1.Show();
            }
        }
    }
}