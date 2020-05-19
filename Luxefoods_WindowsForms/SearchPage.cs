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
using System.Runtime.InteropServices;

namespace Luxefoods_WindowsForms
{
    /// <summary>
    /// Display Keyword Result (All reservations) (FINISHED)
    ///     - Display all reservations by someones firstname or lastname (DONE)
    ///     - Display all reservations by someones id (DONE)
    ///     - Display all reservations by someones email (DONE)
    ///     - Display all reservations by someones phone number (DONE)
    /// When clicked on a result take the result info and go to adminOrderReviewDashboard (FINISHED)
    ///     - Create a list with clickable options and then add a "Edit Reservation" (DONE)
    /// Add the same search bar as in the dashboard (FINISHED)
    ///     - After new keywords refresh the list again (DONE)
    /// Add go back button (FINISHED)
    ///     - Takes back to Dashboard (DONE)
    /// </summary>
    public partial class SearchPage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private string globalPrevious;
        private string globalOption;
        private string globalKeywords;
        private int globalAdminID;
        public SearchPage(string option, int adminID, string keywords, string previous = "")
        {
            globalOption = option;
            globalKeywords = keywords;
            globalPrevious = previous;
            globalAdminID = adminID;
            InitializeComponent();
            label2.Text = "Looking for: " + keywords + " by: " +option;
            if (option == "Name") {
                searchReservationByName(keywords);
            } else if (option == "ID")
            {
                searchReservationById(int.Parse(keywords));
            } else if (option == "E-Mail")
            {
                searchReservationByEmail(keywords);
            } else if (option == "Phone Number")
            {
                searchReservationByPhoneNumber(keywords);
            }
            EditReservationButton.Hide();
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

        private void searchReservationByName(string name)
        {
            var names = name.Split();

            // Search for firstName and Last name if 2 names added
            if (names.Length >= 2)
            {
                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                DataSet ds = new DataSet();
                con.Open();
                SqlCommand read = new SqlCommand($"SELECT * from [user] WHERE voornaam='{names[0]}' or achternaam='{names[1]}' or voornaam='{names[1]}' or achternaam='{names[0]}'", con);
                SqlDataAdapter adapt = new SqlDataAdapter(read);
                adapt.FillSchema(ds, SchemaType.Source, "Users");
                adapt.Fill(ds, "Users");
                con.Close();

                DataTable tblUsers = ds.Tables["Users"];

                DataRow[] row = tblUsers.Select();

                searchResultsList.Items.Clear();

                foreach (var y in row)
                {
                    int userId = (int) y.ItemArray[0];

                    con.Open();
                    read = new SqlCommand($"SELECT * from [reservering] WHERE klantId='{userId}'", con);
                    adapt = new SqlDataAdapter(read);
                    adapt.FillSchema(ds, SchemaType.Source, "Reserveringen");
                    adapt.Fill(ds, "Reserveringen");
                    con.Close();

                    DataTable tblReserveringen = ds.Tables["Reserveringen"];

                    searchResultsList.Items.Clear();
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

                            string orderId = x["Id"].ToString();
                            string customerId = row[rowCounter].ItemArray[0].ToString();
                            string customerFirstName = row[rowCounter].ItemArray[1].ToString();
                            string customerLastName = row[rowCounter].ItemArray[2].ToString();
                            string customerEmail = row[rowCounter].ItemArray[3].ToString();
                            string customerPhone = row[rowCounter].ItemArray[4].ToString();
                            string orderDate = x["datum"].ToString();
                            string orderTableNr = x["tafelNummer"].ToString();
                            searchResultsList.Items.Add("Reservation ID: " + orderId + "   Customer ID: " + customerId + "   Customer Name: " + customerFirstName + " " + customerLastName + "   Customer Email: " + customerEmail + "   Customer Phone Number: " + customerPhone + "   Reservation Date: " + orderDate + "   Reservation Table Number: " + orderTableNr);
                        }

                    }
                }
            }
            // Search for FirtName if only one name
            // If nothing then search for LastName 
            else
            {
                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                DataSet ds = new DataSet();
                con.Open();
                SqlCommand read = new SqlCommand($"SELECT * from [user] WHERE voornaam='{names[0]}' or achternaam='{names[0]}'", con);
                SqlDataAdapter adapt = new SqlDataAdapter(read);
                adapt.FillSchema(ds, SchemaType.Source, "Users");
                adapt.Fill(ds, "Users");
                con.Close();

                DataTable tblUsers = ds.Tables["Users"];

                DataRow[] row = tblUsers.Select();

                searchResultsList.Items.Clear();

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

                    searchResultsList.Items.Clear();
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

                            string orderId = x["Id"].ToString();
                            string customerId = row[rowCounter].ItemArray[0].ToString();
                            string customerFirstName = row[rowCounter].ItemArray[1].ToString();
                            string customerLastName = row[rowCounter].ItemArray[2].ToString();
                            string customerEmail = row[rowCounter].ItemArray[3].ToString();
                            string customerPhone = row[rowCounter].ItemArray[4].ToString();
                            string orderDate = x["datum"].ToString();
                            string orderTableNr = x["tafelNummer"].ToString();
                            searchResultsList.Items.Add("Reservation ID: " + orderId + "   Customer ID: " + customerId + "   Customer Name: " + customerFirstName + " " + customerLastName + "   Customer Email: " + customerEmail + "   Customer Phone Number: " + customerPhone + "   Reservation Date: " + orderDate + "   Reservation Table Number: " + orderTableNr);
                        }

                    }
                }
            }
        }

        private void searchReservationById(int Id)
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

            searchResultsList.Items.Clear();

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

                searchResultsList.Items.Clear();
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

                        string orderId = x["Id"].ToString();
                        string customerId = row[rowCounter].ItemArray[0].ToString();
                        string customerFirstName = row[rowCounter].ItemArray[1].ToString();
                        string customerLastName = row[rowCounter].ItemArray[2].ToString();
                        string customerEmail = row[rowCounter].ItemArray[3].ToString();
                        string customerPhone = row[rowCounter].ItemArray[4].ToString();
                        string orderDate = x["datum"].ToString();
                        string orderTableNr = x["tafelNummer"].ToString();
                        searchResultsList.Items.Add("Reservation ID: " + orderId + "   Customer ID: " + customerId + "   Customer Name: " + customerFirstName + " " + customerLastName + "   Customer Email: " + customerEmail + "   Customer Phone Number: " + customerPhone + "   Reservation Date: " + orderDate + "   Reservation Table Number: " + orderTableNr);
                    }
                }
            }
        }

        private void searchReservationByEmail(string email)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [user] WHERE email='{email}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Users");
            adapt.Fill(ds, "Users");
            con.Close();

            DataTable tblUsers = ds.Tables["Users"];

            DataRow[] row = tblUsers.Select();

            searchResultsList.Items.Clear();

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

                searchResultsList.Items.Clear();
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

                        string orderId = x["Id"].ToString();
                        string customerId = row[rowCounter].ItemArray[0].ToString();
                        string customerFirstName = row[rowCounter].ItemArray[1].ToString();
                        string customerLastName = row[rowCounter].ItemArray[2].ToString();
                        string customerEmail = row[rowCounter].ItemArray[3].ToString();
                        string customerPhone = row[rowCounter].ItemArray[4].ToString();
                        string orderDate = x["datum"].ToString();
                        string orderTableNr = x["tafelNummer"].ToString();
                        searchResultsList.Items.Add("Reservation ID: " + orderId + "   Customer ID: " + customerId + "   Customer Name: " + customerFirstName + " " + customerLastName + "   Customer Email: " + customerEmail + "   Customer Phone Number: " + customerPhone + "   Reservation Date: " + orderDate + "   Reservation Table Number: " + orderTableNr);
                    }
                }
            }
        }

        private void searchReservationByPhoneNumber(string phoneNumber)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [user] WHERE telefoonnummer='{phoneNumber}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Users");
            adapt.Fill(ds, "Users");
            con.Close();

            DataTable tblUsers = ds.Tables["Users"];

            DataRow[] row = tblUsers.Select();

            searchResultsList.Items.Clear();

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

                searchResultsList.Items.Clear();
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

                        string orderId = x["Id"].ToString();
                        string customerId = row[rowCounter].ItemArray[0].ToString();
                        string customerFirstName = row[rowCounter].ItemArray[1].ToString();
                        string customerLastName = row[rowCounter].ItemArray[2].ToString();
                        string customerEmail = row[rowCounter].ItemArray[3].ToString();
                        string customerPhone = row[rowCounter].ItemArray[4].ToString();
                        string orderDate = x["datum"].ToString();
                        string orderTableNr = x["tafelNummer"].ToString();
                        searchResultsList.Items.Add("Reservation ID: " + orderId + "   Customer ID: " + customerId + "   Customer Name: " + customerFirstName + " " + customerLastName + "   Customer Email: " + customerEmail + "   Customer Phone Number: " + customerPhone + "   Reservation Date: " + orderDate + "   Reservation Table Number: " + orderTableNr);
                    }
                }
            }
        }

        private void searchResultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchResultsList.SelectedItem != null)
            {
                EditReservationButton.Show();
            }
            else
            {
                EditReservationButton.Hide();
            }
        }

        private void EditReservationButton_Click(object sender, EventArgs e)
        {
            try
            {
                string strSource = searchResultsList.SelectedItem.ToString();
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
                    AdminOrderReviewDashboard adminOrderReviewDashboard = new AdminOrderReviewDashboard(intId, globalAdminID, "search", globalOption, globalKeywords);
                    adminOrderReviewDashboard.Show();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void SearchComboBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text != "" && SearchComboBox.SelectedItem != null)
            {
                int i = 0;
                if (SearchComboBox.SelectedItem.ToString() == "ID" && !(int.TryParse(inputField.Text, out i)))
                {
                    MessageBox.Show("Please write a correct ID");
                }
                else if (SearchComboBox.SelectedItem.ToString() == "Name" && int.TryParse(inputField.Text, out i))
                {
                    MessageBox.Show("Please write a correct name");
                }
                else if (SearchComboBox.SelectedItem.ToString() == "Phone Number" && !(int.TryParse(inputField.Text, out i)))
                {
                    MessageBox.Show("Please write a correct phone number");
                }
                else if (SearchComboBox.SelectedItem.ToString() == "E-Mail" && !(IsValidEmail(inputField.Text)))
                {
                    MessageBox.Show("Please write a correct E-Mail Adress");
                } 
                else if (SearchComboBox.SelectedItem.ToString() == "ID" && int.TryParse(inputField.Text, out i))
                {
                    searchReservationById(int.Parse(inputField.Text));
                    label2.Text = "Looking for: " + inputField.Text + " by: " + "ID";
                }
                else if (SearchComboBox.SelectedItem.ToString() == "Name" && !(int.TryParse(inputField.Text, out i)))
                {
                    searchReservationByName(inputField.Text);
                    label2.Text = "Looking for: " + inputField.Text + " by: " + "Name";
                }
                else if (SearchComboBox.SelectedItem.ToString() == "Phone Number" && int.TryParse(inputField.Text, out i))
                {
                    searchReservationByPhoneNumber(inputField.Text);
                    label2.Text = "Looking for: " + inputField.Text + " by: " + "Phone Number";
                }
                else if (SearchComboBox.SelectedItem.ToString() == "E-Mail" && IsValidEmail(inputField.Text))
                {
                    searchReservationByEmail(inputField.Text);
                    label2.Text = "Looking for: " + inputField.Text + " by: " + "E-Mail";
                }
                else
                {
                    MessageBox.Show("Something went wrong, try again!");
                }
            }
            else
            {
                MessageBox.Show("Enter Something or Choose The Filter Type!");
            }
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

        private void goBackButton_Click(object sender, EventArgs e)
        {
            if (globalPrevious == "dashboard")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard(globalAdminID);
                dashboard.Show();
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
    }
}
    
