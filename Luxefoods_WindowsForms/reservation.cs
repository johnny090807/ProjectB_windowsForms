using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Luxefoods_WindowsForms
{

    public partial class Reservation : Form
    {
        List<List<int>> GlobalListListBoxes;
        private int globalUserId;
        public Reservation(int userId)
        {
            InitializeComponent();
            globalUserId = userId;
            CenterToScreen();
            List<int> listArea1 = new List<int> { 1, 2, 3, 4, 7, 8, 9, 10, 14, 15, 16, 17, 20, 21, 22 };
            List<int> listArea2 = new List<int> { 5, 6, 11, 12, 18, 19, 31, 32, 33, 34, 35 };
            List<int> listArea3 = new List<int> { 23, 24, 25, 26, 27, 28, 29, 30 };
            List<int> listArea4 = new List<int> { 36, 37, 38, 39, 40, 41, 42, 43 };
            List<int> listArea5 = new List<int> { 44, 45, 46, 47, 48, 49 };
            List<int> listArea6 = new List<int> { 50, 51, 52, 53, 54, 55 };
            GlobalListListBoxes = new List<List<int>> { listArea1, listArea2, listArea3, listArea4, listArea5, listArea6 };
            fillCalender();
            if (Login.person != null)
            {
                this.loginButton.Text = Login.person.voornaam + " " + Login.person.achternaam;
            }
        }

        public class TakenSeats
        {
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

        SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void fillCalender()
        {
            dateTimePicker1.MinDate = DateTime.Now;
            if (dateTimePicker1.Value.Hour > 23)
            {
                dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, (dateTimePicker1.Value.Day + 1), 16, 0, 0);
            }
            else if (dateTimePicker1.Value.Hour < 16)
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
            }
            else if (DateTime.Now.Month == 12)
            {
                var maxMonth = 2;
                var maxYear = DateTime.Now.Year + 1;
                maxDate = new DateTime(maxYear, maxMonth, DateTime.Now.Day);
                dateTimePicker1.MaxDate = maxDate;
            }
            else
            {
                var maxMonth = DateTime.Now.Month + 2;
                maxDate = new DateTime(DateTime.Now.Year, maxMonth, DateTime.Now.Day);
                dateTimePicker1.MaxDate = maxDate;
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
            checkReservation f2 = new checkReservation();
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

        private void Reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'luxeFoodsDataSet.reservering' table. You can move, or remove it, as needed.
            this.reserveringTableAdapter.Fill(this.luxeFoodsDataSet.reservering);
            // TODO: This line of code loads data into the 'luxeFoodsDataSet.restaurant' table. You can move, or remove it, as needed.
            this.restaurantTableAdapter.Fill(this.luxeFoodsDataSet.restaurant);

        }

        //showAvailableTables(int amountOfTables);

        private void availabilityButton_Click(object sender, EventArgs e)
        {
            int people = SeatsComboBox.SelectedIndex;
            DateTime date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            double tableSize = 4.0;
            var tablesNeeded = Math.Ceiling(people / tableSize);
            if (AreaComboBox.SelectedIndex == 0)
            {
                listBox1617.DataSource = GlobalListListBoxes[0];
                listBox1718.DataSource = GlobalListListBoxes[0];
                listBox1819.DataSource = GlobalListListBoxes[0];
                listBox1920.DataSource = GlobalListListBoxes[0];
                listBox2021.DataSource = GlobalListListBoxes[0];
                listBox2122.DataSource = GlobalListListBoxes[0];
                listBox2223.DataSource = GlobalListListBoxes[0];
            }
            if (AreaComboBox.SelectedIndex == 1)
            {
                listBox1617.DataSource = GlobalListListBoxes[1];
                listBox1718.DataSource = GlobalListListBoxes[1];
                listBox1819.DataSource = GlobalListListBoxes[1];
                listBox1920.DataSource = GlobalListListBoxes[1];
                listBox2021.DataSource = GlobalListListBoxes[1];
                listBox2122.DataSource = GlobalListListBoxes[1];
                listBox2223.DataSource = GlobalListListBoxes[1];
            }
            if (AreaComboBox.SelectedIndex == 2)
            {
                listBox1617.DataSource = GlobalListListBoxes[2];
                listBox1718.DataSource = GlobalListListBoxes[2];
                listBox1819.DataSource = GlobalListListBoxes[2];
                listBox1920.DataSource = GlobalListListBoxes[2];
                listBox2021.DataSource = GlobalListListBoxes[2];
                listBox2122.DataSource = GlobalListListBoxes[2];
                listBox2223.DataSource = GlobalListListBoxes[2];
            }
            if (AreaComboBox.SelectedIndex == 3)
            {
                listBox1617.DataSource = GlobalListListBoxes[3];
                listBox1718.DataSource = GlobalListListBoxes[3];
                listBox1819.DataSource = GlobalListListBoxes[3];
                listBox1920.DataSource = GlobalListListBoxes[3];
                listBox2021.DataSource = GlobalListListBoxes[3];
                listBox2122.DataSource = GlobalListListBoxes[3];
                listBox2223.DataSource = GlobalListListBoxes[3];
            }
            if (AreaComboBox.SelectedIndex == 4)
            {
                listBox1617.DataSource = GlobalListListBoxes[4];
                listBox1718.DataSource = GlobalListListBoxes[4];
                listBox1819.DataSource = GlobalListListBoxes[4];
                listBox1920.DataSource = GlobalListListBoxes[4];
                listBox2021.DataSource = GlobalListListBoxes[4];
                listBox2122.DataSource = GlobalListListBoxes[4];
                listBox2223.DataSource = GlobalListListBoxes[4];
            }
            if (AreaComboBox.SelectedIndex == 5)
            {
                listBox1617.DataSource = GlobalListListBoxes[5];
                listBox1718.DataSource = GlobalListListBoxes[5];
                listBox1819.DataSource = GlobalListListBoxes[5];
                listBox1920.DataSource = GlobalListListBoxes[5];
                listBox2021.DataSource = GlobalListListBoxes[5];
                listBox2122.DataSource = GlobalListListBoxes[5];
                listBox2223.DataSource = GlobalListListBoxes[5];
            }
            if (AreaComboBox.SelectedIndex == 6)
            {
                listBox1617.DataSource = GlobalListListBoxes[6];
                listBox1718.DataSource = GlobalListListBoxes[6];
                listBox1819.DataSource = GlobalListListBoxes[6];
                listBox1920.DataSource = GlobalListListBoxes[6];
                listBox2021.DataSource = GlobalListListBoxes[6];
                listBox2122.DataSource = GlobalListListBoxes[6];
                listBox2223.DataSource = GlobalListListBoxes[6];
            }
            //showAvailableTables(tablesNeeded);
        }

        void makeReservation(int userId)
        {
            List<string> RestaurantNames = new List<string>();

            //Maak een request naar de database om alle restaurant namen in een List op te slaan (Nodig?)
            SqlCommand read = new SqlCommand("select * from restaurant", connection);
            connection.Open();
            using (SqlDataReader reader = read.ExecuteReader())
            {
                while (reader.Read())
                {
                    RestaurantNames.Add(reader.GetString(1));

                }

                // Connectie met database beindigen
                connection.Close();
            }

            // RBL: Restaurant kiezen en naar string converten// Functie maken om restaurantId van geselecteerd restaurant te selecteren
            string restaurantChoice = restaurantComboCox.SelectedItem.ToString();
            int restaurantId = restaurantComboCox.SelectedIndex+1;

            // RBL: DateTime implementeren in class
            DateTime date = dateTimePicker1.Value;

            // RBL: Initializeer aantal Lists
            List<DateTime> availableTimes = new List<DateTime>() {
                new DateTime(date.Year, date.Month, date.Day, 16, 00, 00),
                new DateTime(date.Year, date.Month, date.Day, 17, 00, 00),
                new DateTime(date.Year, date.Month, date.Day, 18, 00, 00),
                new DateTime(date.Year, date.Month, date.Day, 19, 00, 00),
                new DateTime(date.Year, date.Month, date.Day, 20, 00, 00),
                new DateTime(date.Year, date.Month, date.Day, 21, 00, 00),
                new DateTime(date.Year, date.Month, date.Day, 22, 00, 00)
            };
            List<TakenSeats> takenTimesWithTables = new List<TakenSeats>();
            List<TakenSeats> availableTimesWithTables = new List<TakenSeats>();

            // (RBL: Aanpassen?)
            // Algorithm om een List vol te maken met alle mogelijke tijden om te reserveren y = aantal restauranten (1-2), i = lengte van de availableTimes List (max 7) en x = de max mogelijke tafels (max 55)
            for (int y = 1; y < RestaurantNames.Count + 1; y++)
            {
                for (int i = 0; i < availableTimes.Count; i++)
                {
                    for (int x = 1; x <= 55; x++)
                    {
                        availableTimesWithTables.Add(new TakenSeats(availableTimes[i], x, y));
                    }
                }
            }

            //RBL: Vragen aan Kacper:
            // - Klopt het dat takenseats de list is waar de tafels in gedisplayed worden? Zie line 232
            // - 
            // Request naar Databse sturen om alle gereserveerde tijden op de eerder gegeven datum te krijgen en in takenTimesWithTables List te zetten
            SqlCommand readCommand = new SqlCommand("select datum, tafelNummer, restaurantId from reservering where datum between '" + date.Month + "/" + date.Day + "/" + date.Year + "' and '" + date.Month + "/" + date.Day + "/" + date.Year + " 23:59:59'", connection);
            connection.Open();
            using (SqlDataReader reader = readCommand.ExecuteReader())
            {

                //(RBL: Weergeven in table vanuit list, of direct vanuit DB in table zetten?)
                //(RBL: Oplossing voor weergave: Maak een clickable box, filter deze op tijd (bijv. 16:00-17:00) en op tafelnummer bijv area 1 is 1-20 en geef deze weer in het eerste vakje, maak deze voor alle vakjes)
                //De ontvangen data in eigen TakenSeats class zetten om die dan in een list te zetten zodat het makkelijker terug te vinden           while (reader.Read())
                while (reader.Read())
                {
                    TakenSeats p1 = new TakenSeats(reader.GetDateTime(0), reader.GetInt32(1), reader.GetInt32(2));
                    takenTimesWithTables.Add(p1);
                }

                // Connectie met database beindigen
                connection.Close();
            }

            //(RBL: aanpassen, restaurantID bestaat niet in deze versie)(RBL: Edit, restaurantId bestaat weer, testen of het nog werkt. mogelijke bug cause!) 
            // Kijken welke tafels al gereserveerd waren en die van de availableTimesWithTables verwijderen
            foreach (TakenSeats x in takenTimesWithTables)
            {
                foreach (TakenSeats i in availableTimesWithTables.ToList())
                {

                    // Als restauranten niet zelfde iD hebben gelijk verwijderen
                    if (i.restaurantId != restaurantId)
                    {
                        availableTimesWithTables.Remove(i);
                    }

                    // Overige restauranten die zelfde tafel nummer, reserverings tijd en restaurant id hebben ook verwijderen
                    if ((x.takenSeat == i.takenSeat) && (x.takenTime == i.takenTime) && (x.restaurantId == restaurantId))
                    {
                        availableTimesWithTables.Remove(i);
                    }
                }
            }

            //(RBL: Aanpassen naar winform ipv consolewriteline)
            //Alleen de overgebleven werkelijke availableTimesWithTables laten zien
            Console.WriteLine("Those are all the available times for " + date.Year + "-" + date.Month + "-" + date.Day + ": ");
            foreach (TakenSeats x in availableTimesWithTables)
            {
                Console.WriteLine(x.takenTime + " and seat nr. " + x.takenSeat);
            }

            // RBL: dateParse is aangepast naar date, hierdoor botst het met eerder vermelde date van kacper hier. variable naam correct aanpassen
            // De uur van int naar een TimeSpan converteren en aan de date string toevoegen (date blijft nog steeds een string)
            int hour = SelectHour();
            TimeSpan ts = new TimeSpan(hour, 0, 0);
            date = new DateTime(date.Year, date.Month, date.Day, ts.Hours, ts.Minutes, ts.Seconds);
            string dateStr = $"{date.Year}/{date.Month}/{date.Day} {ts.Hours}:{ts.Minutes}:{ts.Seconds}";


            // RBL: Aanpassen van keuze via typen naar aangeklikte mogelijkheid in de table/form
            //Tafel keuze
            int tableNumber = SelectTableNumber();

            // RBL: De checks aanpassen, bij allemaal een pop up window met "Helaas is deze tafel in de tussentijd gereserveerd, kies aub een nieuwe tafel/tijd" ipv writeline.
            // Checken of alles klopt

            bool submitChecked = false;

            while (!submitChecked)
            {

                DialogResult beforeSubmit = MessageBox.Show("Your reservation is Finished!\nThis is how you reservation looks like:\nUserId: " + userId + ", RestaurantId: " + restaurantId + ", Date: " + dateStr + ", Table Number: " + tableNumber + "\n Do you want to Submit the reservation?", "Check before submitting", MessageBoxButtons.YesNo);

                if (beforeSubmit == DialogResult.Yes)
                {
                    bool trueData = true;

                    // Security check om te kijken of de uiteindelijke data zeker beschikbaar is
                    foreach (TakenSeats x in takenTimesWithTables)
                    {

                        // Als gereserveerde tijd zelfde is als gekozen tijd en tafel nummer zelfde is als gekozen tafel nummer en restaurant ids zijn ook zelfde dan is die plek als gereserveerd door iemand anders
                        if (x.takenTime == date && x.takenSeat == tableNumber && x.restaurantId == restaurantId)
                        {
                            MessageBox.Show("There is already an reservation made for this time and table! Please choose another time or table.", "Oops, our bad.", MessageBoxButtons.OK);
                            trueData = false;
                            break;
                        }
                    }

                    // Als dit niet klopt dan sturen wij de data naar de database
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open && trueData)
                    {

                        // SQL Command om de RestaurantId, UserId, date en tableNumber in de database in de juiste plekken te zetten
                        string q = $"INSERT INTO [reservering] (restaurantId, klantId, datum, tafelNummer) VALUES  ('{restaurantId}', '{userId}', '{dateStr}', '{tableNumber}')";

                        try
                        {

                            // de SQL command in een command zetten met de erbij toegevoegde connection string
                            SqlCommand cmd = new SqlCommand(q, connection);

                            // Execute een non query command in de database
                            cmd.ExecuteNonQuery();


                            MessageBox.Show("Reservation has succesfully been submitted");
                            submitChecked = !submitChecked;
                        }
                        catch (Exception ex)
                        {
                            //Error handler, print gelijk de error uit
                            MessageBox.Show(ex.Message);
                        }
                    }

                    // Connectie met database beindigen
                    connection.Close();

                    //Als 2 dan reservering annuleren
                }
                else if (beforeSubmit == DialogResult.No)
                {
                    MessageBox.Show("We've cancelled the reservation, please try again");
                    submitChecked = !submitChecked;
                }
            }
        }

        int SelectHour()
        {
            if (listBox1617.SelectedItem != null)
            {
                int hour = 16;
                return hour;
            }
            if (listBox1718.SelectedItem != null)
            {
                int hour = 17;
                return hour;
            }
            if (listBox1819.SelectedItem != null)
            {
                int hour = 18;
                return hour;
            }
            if (listBox1920.SelectedItem != null)
            {
                int hour = 19;
                return hour;
            }
            if (listBox2021.SelectedItem != null)
            {
                int hour = 20;
                return hour;
            }
            if (listBox2122.SelectedItem != null)
            {
                int hour = 21;
                return hour;
            }
            else
            {
                int hour = 22;
                return hour;
            }

        }
        int SelectTableNumber()
        {
            if (listBox1617.SelectedItem != null)
            {
                string tableNumberString = listBox1617.SelectedItem.ToString();
                int tableNumber = Convert.ToInt32(tableNumberString);
                return tableNumber;
            }
            if (listBox1718.SelectedItem != null)
            {
                string tableNumberString = listBox1718.SelectedItem.ToString();
                int tableNumber = Convert.ToInt32(tableNumberString);
                return tableNumber;
            }
            if (listBox1819.SelectedItem != null)
            {
                string tableNumberString = listBox1819.SelectedItem.ToString();
                int tableNumber = Convert.ToInt32(tableNumberString);
                return tableNumber;
            }
            if (listBox1920.SelectedItem != null)
            {
                string tableNumberString = listBox1920.SelectedItem.ToString();
                int tableNumber = Convert.ToInt32(tableNumberString);
                return tableNumber;
            }
            if (listBox2021.SelectedItem != null)
            {
                string tableNumberString = listBox2021.SelectedItem.ToString();
                int tableNumber = Convert.ToInt32(tableNumberString);
                return tableNumber;
            }
            if (listBox2122.SelectedItem != null)
            {
                string tableNumberString = listBox2122.SelectedItem.ToString();
                int tableNumber = Convert.ToInt32(tableNumberString);
                return tableNumber;
            }
            else
            {
                string tableNumberString = listBox2223.SelectedItem.ToString();
                int tableNumber = Convert.ToInt32(tableNumberString);
                return tableNumber;
            }

        }

        private void listBox1617_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1617.SelectedIndex != 20)
            {
                listBox1718.SelectedItem = null;
                listBox1819.SelectedItem = null;
                listBox1920.SelectedItem = null;
                listBox2021.SelectedItem = null;
                listBox2122.SelectedItem = null;
                listBox2223.SelectedItem = null;
            }
        }

        private void listBox1718_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1718.SelectedIndex != 20)
            {
                listBox1617.SelectedItem = null;
                listBox1819.SelectedItem = null;
                listBox1920.SelectedItem = null;
                listBox2021.SelectedItem = null;
                listBox2122.SelectedItem = null;
                listBox2223.SelectedItem = null;
            }

        }

        private void listBox1819_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1819.SelectedIndex != 20)
            {
                listBox1718.SelectedItem = null;
                listBox1617.SelectedItem = null;
                listBox1920.SelectedItem = null;
                listBox2021.SelectedItem = null;
                listBox2122.SelectedItem = null;
                listBox2223.SelectedItem = null;
            }
        }

        private void listBox1920_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1920.SelectedIndex != 20)
            {
                listBox1718.SelectedItem = null;
                listBox1819.SelectedItem = null;
                listBox1617.SelectedItem = null;
                listBox2021.SelectedItem = null;
                listBox2122.SelectedItem = null;
                listBox2223.SelectedItem = null;
            }
        }

        private void listBox2021_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2021.SelectedIndex != 20)
            {
                listBox1718.SelectedItem = null;
                listBox1819.SelectedItem = null;
                listBox1920.SelectedItem = null;
                listBox1617.SelectedItem = null;
                listBox2122.SelectedItem = null;
                listBox2223.SelectedItem = null;
            }
        }

        private void listBox2122_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2122.SelectedIndex != 20)
            {
                listBox1718.SelectedItem = null;
                listBox1819.SelectedItem = null;
                listBox1920.SelectedItem = null;
                listBox2021.SelectedItem = null;
                listBox1617.SelectedItem = null;
                listBox2223.SelectedItem = null;
            }
        }

        private void listBox2223_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2223.SelectedIndex != 20)
            {
                listBox1718.SelectedItem = null;
                listBox1819.SelectedItem = null;
                listBox1920.SelectedItem = null;
                listBox2021.SelectedItem = null;
                listBox2122.SelectedItem = null;
                listBox1617.SelectedItem = null;
            }
        }

        private void PlaceReservationButton_Click(object sender, EventArgs e)
        {
            makeReservation(globalUserId);
            
        }

        private void menuButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            checkReservation reservationForm = new checkReservation();
            reservationForm.Show();
        }

        private void loginButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.previousPage = "Reservation";
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
    }
}
