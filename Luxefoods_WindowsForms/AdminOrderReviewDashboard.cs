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
    public partial class AdminOrderReviewDashboard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public class TakenSeats
        {
            //20-04-2020 16:00:00
            public DateTime takenTime { get; set; }
            public int takenSeat { get; set; }
            public int restaurantId { get; set; }
            public TakenSeats(DateTime takentime, int takenseat, int restaurantid)
            {
                takenTime = takentime;
                takenSeat = takenseat;
                restaurantId = restaurantid;
            }
        }
        private int globalId;
        private string globalPrevious;
        private string globalOption;
        private string globalKeywords;
        private int globalAdminID;
        public AdminOrderReviewDashboard(int ID, int adminID, string previous = "", string option = "", string keywords = "")
        {
            /*  TODO
             * Edit Details of the order (FINISHED)
             * Show Customer Contact Info (DONE)
             * Edit Customer Info Button (FINISHED)
             *  - Should take to seperate window where the you can change customers info (DONE)
             * Option to delete order 
             * Option to go back to the Dasboard (DONE)
             */
            globalId = ID;
            globalPrevious = previous;
            globalOption = option;
            globalKeywords = keywords;
            globalAdminID = adminID;
            InitializeComponent();
            fillDashboard(ID);
            fillComboBox(ID);
            setDateTimePicker(ID);
            EditButton.Hide();
            updateAvailableSeats();
        }

        private int globalCustomerId;

        private void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void fillDashboard(int ID)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [reservering] WHERE Id='{ID}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Reserveringen");
            adapt.Fill(ds, "Reserveringen");
            con.Close();

            DataTable tblReserveringen;
            tblReserveringen = ds.Tables["Reserveringen"];

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
                    foreach (DataRow i in tblCustomerInfo.Rows)
                    {
                        CustomerId.Text = "Customer #" + i["id"].ToString();
                        CustomerName.Text = "Name: " + i["voornaam"].ToString() + " " + i["achternaam"].ToString();
                        CustomerEmail.Text = "E-mail: " + i["email"].ToString();
                        CustomerPhone.Text = "Phone Number: " + i["telefoonnummer"].ToString();
                        customerNameTextBox.Text = i["voornaam"].ToString() + " " + i["achternaam"].ToString();
                        customerEmailTextBox.Text = i["email"].ToString();
                        customerPhoneTextBox.Text = i["telefoonnummer"].ToString();
                        globalCustomerId = (int)i["id"];
                    }
                }
            }
            DataRow drTblR = tblReserveringen.Rows[0];
            OriginalSeatNr.Text = "Orginele Tafel Nummer: " + drTblR["tafelNummer"].ToString();
            OrderId.Text = "Order ID #" + ID;
        }

        private void fillComboBox(int ID)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [restaurant]", con);
            SqlCommand read2 = new SqlCommand($"SELECT restaurantId from [reservering] WHERE Id='{ID}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            SqlDataAdapter adapt2 = new SqlDataAdapter(read2);
            adapt.FillSchema(ds, SchemaType.Source, "Restaurants");
            adapt.Fill(ds, "Restaurants");
            adapt2.FillSchema(ds, SchemaType.Source, "RestaurantId");
            adapt2.Fill(ds, "RestaurantId");
            con.Close();

            DataTable tblRestaurants = ds.Tables["Restaurants"];
            DataTable tblRestaurantsId = ds.Tables["RestaurantId"];
            DataRowCollection rest = tblRestaurants.Rows;
            string restaurantName = "";
            if (tblRestaurants != null)
            {
                RestaurantPicker.ValueMember = "id";
                RestaurantPicker.DisplayMember = "naam";
                RestaurantPicker.DataSource = tblRestaurants;
                foreach (DataRow x in tblRestaurantsId.Rows)
                {
                    RestaurantPicker.SelectedIndex = ((int)x["restaurantId"] - 1);
                    restaurantName = rest[(int)x["restaurantId"] - 1].ItemArray[1].ToString();
                }
            }
            OriginalRestaurantLabel.Text = "The original restaurant was: \n" + restaurantName;
        }

        private void setDateTimePicker(int ID)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT datum from [reservering] WHERE Id='{ID}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Datum");
            adapt.Fill(ds, "Datum");
            con.Close();

            DataTable tblDate = ds.Tables["Datum"];

            foreach (DataRow x in tblDate.Rows)
            {
                dateTimePicker1.Value = (DateTime)x["datum"];
                OriginalTimeLabel.Text = "The Original Order Date was: " + x["datum"].ToString();
            }

            dateTimePicker1.MinDate = DateTime.Now;
            if (dateTimePicker1.Value.Hour > 22)
            {
                dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, (dateTimePicker1.Value.Day+1), 16, 0, 0);
            } else if (dateTimePicker1.Value.Hour < 16)
            {
                dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, (dateTimePicker1.Value.Day), 16, 0, 0);
            }

            DateTime maxDate;
            if (DateTime.Now.Month == 11)
            {
                var maxMonth = 1;
                var maxYear = DateTime.Now.Year + 1;
                maxDate = new DateTime(maxYear, maxMonth, DateTime.Now.Day);
                dateTimePicker1.MaxDate = maxDate;
            } else if (DateTime.Now.Month == 12)
            {
                var maxMonth = 2;
                var maxYear = DateTime.Now.Year + 1;
                maxDate = new DateTime(maxYear, maxMonth, DateTime.Now.Day);
                dateTimePicker1.MaxDate = maxDate;
            } else
            {
                var maxMonth = DateTime.Now.Month + 2;
                maxDate = new DateTime(DateTime.Now.Year, maxMonth, DateTime.Now.Day);
                dateTimePicker1.MaxDate = maxDate;
            }
        }

        private void checkDataChanged(int ID)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [reservering] WHERE Id='{ID}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Reservering");
            adapt.Fill(ds, "Reservering");
            con.Close();

            DataTable tblReservering = ds.Tables["Reservering"];

            int seatNr = 0;

            if (availableSeatsListBox.SelectedItem != null)
            {
                if (availableSeatsListBox.SelectedItem.ToString() != "Current Seat")
                {
                    string strSource = availableSeatsListBox.SelectedItem.ToString();
                    string strStart = "Seat nr: ";
                    if (strSource.Contains(strStart))
                    {
                        int start, end;
                        start = strSource.IndexOf(strStart, 0) + strStart.Length;
                        end = strSource.Length;
                        string reservationID = strSource.Substring(start, end - start);

                        string seatNrStr = string.Empty;

                        for (int i = 0; i < reservationID.Length; i++)
                        {
                            if (Char.IsDigit(reservationID[i]))
                            {
                                seatNrStr += reservationID[i];
                            }
                        }

                        seatNr = Int32.Parse(seatNrStr);
                    }
                } 
            }
            

            foreach (DataRow x in tblReservering.Rows)
            {
                if (((int)x["restaurantId"] != (int)RestaurantPicker.SelectedValue) || ((DateTime)x["datum"] != dateTimePicker1.Value) || ((int) x["tafelNummer"] != seatNr && (DateTime)x["datum"] == dateTimePicker1.Value && seatNr != 0))
                {
                    EditButton.Show();
                } else
                {
                    EditButton.Hide();
                }
            }
        }

        private void checkCustomerDataChanged(int customerId)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [user] WHERE id='{customerId}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "CustomerInfo");
            adapt.Fill(ds, "CustomerInfo");
            con.Close();

            DataTable tblCustomerInfo = ds.Tables["CustomerInfo"];

            var names = customerNameTextBox.Text.Split();

            if (names.Length >= 2)
            {
                foreach (DataRow x in tblCustomerInfo.Rows)
                {

                    if ((string)x["voornaam"] != names[0] || (string)x["achternaam"] != names[1] || (string)x["email"] != customerEmailTextBox.Text || (string)x["telefoonnummer"] != customerPhoneTextBox.Text)
                    {
                        AcceptChangeButton.Show();
                    }
                    else
                    {
                        AcceptChangeButton.Hide();
                    }
                }
            } 
            else if (names.Length >= 1)
            {
                foreach (DataRow x in tblCustomerInfo.Rows)
                {

                    if ((string)x["voornaam"] != names[0] || (string)x["achternaam"] != names[0] || (string)x["email"] != customerEmailTextBox.Text || (string)x["telefoonnummer"] != customerPhoneTextBox.Text)
                    {
                        AcceptChangeButton.Show();
                    }
                    else
                    {
                        AcceptChangeButton.Hide();
                    }
                }
            }
        }

        private void RestaurantPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataChanged(globalId);
            updateAvailableSeats();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkDataChanged(globalId);
            updateAvailableSeats();

            if (dateTimePicker1.Value.Hour > 22)
            {
                dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, (dateTimePicker1.Value.Day + 1), 16, 0, 0);
            }
            else if (dateTimePicker1.Value.Hour < 16)
            {
                dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, (dateTimePicker1.Value.Day), 16, 0, 0);
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (RestaurantPicker.SelectedItem != null && availableSeatsListBox.SelectedItem != null)
            {
                try
                {
                    int seatNr = 0;

                    if (availableSeatsListBox.SelectedItem != null)
                    {
                        if (availableSeatsListBox.SelectedItem.ToString() != "Current Seat")
                        {
                            string strSource = availableSeatsListBox.SelectedItem.ToString();
                            string strStart = "Seat nr: ";
                            if (strSource.Contains(strStart))
                            {
                                int start, end;
                                start = strSource.IndexOf(strStart, 0) + strStart.Length;
                                end = strSource.Length;
                                string reservationID = strSource.Substring(start, end - start);

                                string seatNrStr = string.Empty;

                                for (int i = 0; i < reservationID.Length; i++)
                                {
                                    if (Char.IsDigit(reservationID[i]))
                                    {
                                        seatNrStr += reservationID[i];
                                    }
                                }

                                seatNr = Int32.Parse(seatNrStr);

                                int restaurantId = (RestaurantPicker.SelectedIndex + 1);
                                //YYYY - MM - DD
                                string date = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString() + " " + dateTimePicker1.Value.Hour + ":00:00";
                                //int tafelNummer =
                                SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                                SqlCommand Command = new SqlCommand($"UPDATE [reservering] SET datum='{date}', restaurantId='{restaurantId}', tafelNummer='{seatNr}' WHERE Id='{globalId}'", connection);
                                connection.Open();

                                // Execute de SQL UPDATE Request
                                Command.ExecuteNonQuery();

                                // Connectie met database beindigen
                                connection.Close();

                                MessageBox.Show("Succesfully Edited The Order!");
                                fillDashboard(globalId);
                                fillComboBox(globalId);
                                setDateTimePicker(globalId);
                                checkDataChanged(globalId);
                                updateAvailableSeats();
                            }
                        }
                        else
                        {
                            int restaurantId = (RestaurantPicker.SelectedIndex + 1);
                            //YYYY - MM - DD
                            string date = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString() + " " + dateTimePicker1.Value.Hour + ":00:00";
                            //int tafelNummer =
                            SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                            SqlCommand Command = new SqlCommand($"UPDATE [reservering] SET datum='{date}', restaurantId='{restaurantId}' WHERE Id='{globalId}'", connection);
                            connection.Open();

                            // Execute de SQL UPDATE Request
                            Command.ExecuteNonQuery();

                            // Connectie met database beindigen
                            connection.Close();

                            MessageBox.Show("Succesfully Edited The Order!");
                            fillDashboard(globalId);
                            fillComboBox(globalId);
                            setDateTimePicker(globalId);
                            checkDataChanged(globalId);
                            updateAvailableSeats();
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            } else
            {
                MessageBox.Show("Please select the restaurant and seat");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

            goBackButton.Enabled = !goBackButton.Enabled;
            RestaurantPicker.Enabled = !RestaurantPicker.Enabled;
            dateTimePicker1.Enabled = !dateTimePicker1.Enabled;
            EditCustomerInfoButton.Enabled = !EditCustomerInfoButton.Enabled;
            EditButton.Enabled = !EditButton.Enabled;
            DeleteButton.Enabled = !DeleteButton.Enabled;
        }

        private void EditCustomerInfoButton_Click(object sender, EventArgs e)
        {
            showCustomerEdit();
        }

        private void AcceptChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var names = customerNameTextBox.Text.Split();
                SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand Command = new SqlCommand($"UPDATE [user] SET voornaam='{names[0]}', achternaam='{names[1]}', email='{customerEmailTextBox.Text}', telefoonnummer='{customerPhoneTextBox.Text}' WHERE Id='{globalCustomerId}'", connection);
                connection.Open();

                // Execute de SQL UPDATE Request
                Command.ExecuteNonQuery();

                // Connectie met database beindigen
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            fillDashboard(globalId);
            hideCustomerEdit();
        }

        private void CancelChangeButton_Click(object sender, EventArgs e)
        {
            hideCustomerEdit();
        }

        private void showCustomerEdit()
        {
            CustomerName.Hide();
            customerNameTextBox.Show();
            CustomerEmail.Hide();
            customerEmailTextBox.Show();
            CustomerPhone.Hide();
            customerPhoneTextBox.Show();
            EditCustomerInfoButton.Hide();
            CancelChangeButton.Show();
            checkCustomerDataChanged(globalCustomerId);
        }

        private void hideCustomerEdit()
        {
            CustomerName.Show();
            customerNameTextBox.Hide();
            CustomerEmail.Show();
            customerEmailTextBox.Hide();
            CustomerPhone.Show();
            customerPhoneTextBox.Hide();
            EditCustomerInfoButton.Show();
            CancelChangeButton.Hide();
            AcceptChangeButton.Hide();
        }
        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            checkCustomerDataChanged(globalCustomerId);
        }

        private void customerEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            checkCustomerDataChanged(globalCustomerId);
        }

        private void customerPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            checkCustomerDataChanged(globalCustomerId);
        }

        private void updateAvailableSeats()
        {
            List<DateTime> availableTimes = new List<DateTime>() {
                new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 16, 00, 00),
                new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 17, 00, 00),
                new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 18, 00, 00),
                new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 19, 00, 00),
                new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 20, 00, 00),
                new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 21, 00, 00),
                new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 22, 00, 00)
            };
            List<TakenSeats> takenTimesWithTables = new List<TakenSeats>();
            List<TakenSeats> availableTimesWithTables = new List<TakenSeats>();

            // Algorithm om een List vol te maken met alle mogelijke tijden om te reserveren y = aantal restauranten (1-2), i = lengte van de availableTimes List (max 7) en x = de max mogelijke tafels (max 55)
            for (int y = 1; y < RestaurantPicker.Items.Count + 1; y++)
            {
                for (int i = 0; i < availableTimes.Count; i++)
                {
                    for (int x = 1; x <= 55; x++)
                    {
                        availableTimesWithTables.Add(new TakenSeats(availableTimes[i], x, y));
                    }
                }
            }

            SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            // Request naar Databse sturen om alle gereserveerde tijden op de eerder gegeven datum te krijgen en in takenTimesWithTables List te zetten
            SqlCommand readCommand = new SqlCommand("select datum, tafelNummer, restaurantId from reservering where datum between '" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Year + " " + dateTimePicker1.Value.Hour + ":00:00" + "' and '" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Year + " " + dateTimePicker1.Value.Hour + ":59:59'", connection);
            connection.Open();
            using (SqlDataReader reader = readCommand.ExecuteReader())
            {

                // De ontvangen data in eigen TakenSeats class zetten om die dan in een list te zetten zodat het makkelijker terug te vinden is.
                while (reader.Read())
                {
                    TakenSeats p1 = new TakenSeats(reader.GetDateTime(0), reader.GetInt32(1), reader.GetInt32(2));
                    takenTimesWithTables.Add(p1);
                }

                // Connectie met database beindigen
                connection.Close();
            }

            // Kijken welke tafels al gereserveerd waren en die van de availableTimesWithTables verwijderen

            foreach (TakenSeats i in availableTimesWithTables.ToList())
            {
                // Als restauranten niet zelfde iD hebben gelijk verwijderen
                if (i.restaurantId != RestaurantPicker.SelectedIndex + 1)
                {
                    availableTimesWithTables.Remove(i);
                }

                if (i.takenTime.Hour != dateTimePicker1.Value.Hour)
                {
                    availableTimesWithTables.Remove(i);
                }

                foreach (TakenSeats x in takenTimesWithTables)
                {
                    // Overige restauranten die zelfde tafel nummer, reserverings tijd en restaurant id hebben ook verwijderen
                    if ((x.takenSeat == i.takenSeat) && (x.takenTime == i.takenTime) && (x.restaurantId == RestaurantPicker.SelectedIndex + 1))
                    {
                        availableTimesWithTables.Remove(i);
                    }
                }
            }

            availableSeatsListBox.Items.Clear();

            availableSeatsListBox.Items.Add("Current Seat");

            //Alleen de overgebleven werkelijke availableTimesWithTables laten zien
            foreach (TakenSeats x in availableTimesWithTables)
            {
                availableSeatsListBox.Items.Add("Seat nr: " + x.takenSeat);
            }
        }

        private void availableSeatsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataChanged(globalId);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            if (globalPrevious == "dashboard")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard(globalAdminID);
                dashboard.Show();
            } else if (globalPrevious == "search")
            {
                this.Hide();
                SearchPage search = new SearchPage(globalOption, globalAdminID, globalKeywords, "dashboard");
                search.Show();
            }
        }

        private void panelNoButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

            goBackButton.Enabled = !goBackButton.Enabled;
            RestaurantPicker.Enabled = !RestaurantPicker.Enabled;
            dateTimePicker1.Enabled = !dateTimePicker1.Enabled;
            EditCustomerInfoButton.Enabled = !EditCustomerInfoButton.Enabled;
            EditButton.Enabled = !EditButton.Enabled;
            DeleteButton.Enabled = !DeleteButton.Enabled;
        }

        private void panelYesButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand Command = new SqlCommand($"DELETE FROM [reservering] WHERE Id='{globalId}'", connection);
                connection.Open();

                // Execute de SQL UPDATE Request
                Command.ExecuteNonQuery();

                // Connectie met database beindigen
                connection.Close();
                MessageBox.Show("The Order Has Been Successfully Deleted");
                panel2.Visible = false;

                goBackButton.Enabled = !goBackButton.Enabled;
                RestaurantPicker.Enabled = !RestaurantPicker.Enabled;
                dateTimePicker1.Enabled = !dateTimePicker1.Enabled;
                EditCustomerInfoButton.Enabled = !EditCustomerInfoButton.Enabled;
                EditButton.Enabled = !EditButton.Enabled;
                DeleteButton.Enabled = !DeleteButton.Enabled;

                if (globalPrevious == "dashboard")
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard(globalAdminID);
                    dashboard.Show();
                }
                else if (globalPrevious == "search")
                {
                    this.Hide();
                    SearchPage search = new SearchPage(globalOption, globalAdminID, globalKeywords, "dashboard");
                    search.Show();
                }
            } catch (Exception err)
            {
                MessageBox.Show(err.Message);
                panel2.Visible = false;

                goBackButton.Enabled = !goBackButton.Enabled;
                RestaurantPicker.Enabled = !RestaurantPicker.Enabled;
                dateTimePicker1.Enabled = !dateTimePicker1.Enabled;
                EditCustomerInfoButton.Enabled = !EditCustomerInfoButton.Enabled;
                EditButton.Enabled = !EditButton.Enabled;
                DeleteButton.Enabled = !DeleteButton.Enabled;
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
