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
using System.Drawing.Text;
using System.Runtime.InteropServices;


namespace Luxefoods_WindowsForms
{

    public partial class Reservation : Form
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
                this.LoginBtn.Text = "Logout";
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


        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void aboutUsButton_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            aboutUs f1 = new aboutUs();
            f1.Show();
            this.Close();
        }

        private void reservationsButton_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                checkReservation reservationForm = new checkReservation(Login.person.id);
                this.Hide();
                reservationForm.Show();
            }
            catch
            {
                MessageBox.Show("Je moet eerst ingelogd zijn.");
            }
        }

        private void contactUsButton_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            contactUs f1 = new contactUs();
            f1.Show();
            this.Close();
        }
        
        private void Reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'luxeFoodsDataSet.reservering' table. You can move, or remove it, as needed.
            this.reserveringTableAdapter.Fill(this.luxeFoodsDataSet.reservering);
            // TODO: This line of code loads data into the 'luxeFoodsDataSet.restaurant' table. You can move, or remove it, as needed.
            this.restaurantTableAdapter.Fill(this.luxeFoodsDataSet.restaurant);

        }


        /*  ! Er zit een fout in deze code kacper, als je het zo doet en je komt met 5 mensen, krijg je 1 tafel. 
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
         */

        //showAvailableTables(int amountOfTables);

        private void availabilityButton_Click(object sender, EventArgs e)
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
            int restaurantId = restaurantComboCox.SelectedIndex + 1;

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

            IEnumerable<int> commonSeats16 = new List<int>();
            IEnumerable<int> commonSeats17 = new List<int>();
            IEnumerable<int> commonSeats18 = new List<int>();
            IEnumerable<int> commonSeats19 = new List<int>();
            IEnumerable<int> commonSeats20 = new List<int>();
            IEnumerable<int> commonSeats21 = new List<int>();
            IEnumerable<int> commonSeats22 = new List<int>();
            List<int> emptyList = new List<int>();

            IEnumerable<int> A1C16 = GlobalListListBoxes[0];
            IEnumerable<int> A1C17 = GlobalListListBoxes[0];
            IEnumerable<int> A1C18 = GlobalListListBoxes[0];
            IEnumerable<int> A1C19 = GlobalListListBoxes[0];
            IEnumerable<int> A1C20 = GlobalListListBoxes[0];
            IEnumerable<int> A1C21 = GlobalListListBoxes[0];
            IEnumerable<int> A1C22 = GlobalListListBoxes[0];

            IEnumerable<int> A2C16 = GlobalListListBoxes[1];
            IEnumerable<int> A2C17 = GlobalListListBoxes[1];
            IEnumerable<int> A2C18 = GlobalListListBoxes[1];
            IEnumerable<int> A2C19 = GlobalListListBoxes[1];
            IEnumerable<int> A2C20 = GlobalListListBoxes[1];
            IEnumerable<int> A2C21 = GlobalListListBoxes[1];
            IEnumerable<int> A2C22 = GlobalListListBoxes[1];

            IEnumerable<int> A3C16 = GlobalListListBoxes[2];
            IEnumerable<int> A3C17 = GlobalListListBoxes[2];
            IEnumerable<int> A3C18 = GlobalListListBoxes[2];
            IEnumerable<int> A3C19 = GlobalListListBoxes[2];
            IEnumerable<int> A3C20 = GlobalListListBoxes[2];
            IEnumerable<int> A3C21 = GlobalListListBoxes[2];
            IEnumerable<int> A3C22 = GlobalListListBoxes[2];

            IEnumerable<int> A4C16 = GlobalListListBoxes[3];
            IEnumerable<int> A4C17 = GlobalListListBoxes[3];
            IEnumerable<int> A4C18 = GlobalListListBoxes[3];
            IEnumerable<int> A4C19 = GlobalListListBoxes[3];
            IEnumerable<int> A4C20 = GlobalListListBoxes[3];
            IEnumerable<int> A4C21 = GlobalListListBoxes[3];
            IEnumerable<int> A4C22 = GlobalListListBoxes[3];

            IEnumerable<int> A5C16 = GlobalListListBoxes[4];
            IEnumerable<int> A5C17 = GlobalListListBoxes[4];
            IEnumerable<int> A5C18 = GlobalListListBoxes[4];
            IEnumerable<int> A5C19 = GlobalListListBoxes[4];
            IEnumerable<int> A5C20 = GlobalListListBoxes[4];
            IEnumerable<int> A5C21 = GlobalListListBoxes[4]; 
            IEnumerable<int> A5C22 = GlobalListListBoxes[4];

            IEnumerable<int> A6C16 = GlobalListListBoxes[5];
            IEnumerable<int> A6C17 = GlobalListListBoxes[5];
            IEnumerable<int> A6C18 = GlobalListListBoxes[5];
            IEnumerable<int> A6C19 = GlobalListListBoxes[5];
            IEnumerable<int> A6C20 = GlobalListListBoxes[5];
            IEnumerable<int> A6C21 = GlobalListListBoxes[5];
            IEnumerable<int> A6C22 = GlobalListListBoxes[5];

            //var TakenTimes = availableTimesWithTables.Select(b => b.takenTime);
            //RBL: Funtcion to add and divide all available tables into hourly availble seats, ready to display

            foreach (TakenSeats x  in availableTimesWithTables)
            {
                if (x.takenTime == availableTimes[0])
                {
                    commonSeats16 = commonSeats16.Append(x.takenSeat);
                }
                if (x.takenTime == availableTimes[1])
                {
                    commonSeats17 = commonSeats17.Append(x.takenSeat);
                }
                if (x.takenTime == availableTimes[2])
                {
                    commonSeats18 = commonSeats18.Append(x.takenSeat);
                }
                if (x.takenTime == availableTimes[3])
                {
                    commonSeats19 = commonSeats19.Append(x.takenSeat);
                }
                if (x.takenTime == availableTimes[4])
                {
                    commonSeats20 = commonSeats20.Append(x.takenSeat);
                }
                if (x.takenTime == availableTimes[5])
                {
                    commonSeats21 = commonSeats21.Append(x.takenSeat);
                }
                if (x.takenTime == availableTimes[6])
                {
                    commonSeats22 = commonSeats22.Append(x.takenSeat);
                }
            }
            
            A1C16 = A1C16.Intersect(commonSeats16);
            List<int> LA1C16 = A1C16.ToList();
            A2C16 = A2C16.Intersect(commonSeats16);
            List<int> LA2C16 = A2C16.ToList();
            A3C16 = A3C16.Intersect(commonSeats16);
            List<int> LA3C16 = A3C16.ToList();
            A4C16 = A4C16.Intersect(commonSeats16);
            List<int> LA4C16 = A4C16.ToList();
            A5C16 = A5C16.Intersect(commonSeats16);
            List<int> LA5C16 = A5C16.ToList();
            A6C16 = A6C16.Intersect(commonSeats16);
            List<int> LA6C16 = A6C16.ToList();

            A1C17 = A1C17.Intersect(commonSeats17);
            List<int> LA1C17 = A1C17.ToList();
            A2C17 = A2C17.Intersect(commonSeats17);
            List<int> LA2C17 = A2C17.ToList();
            A3C17 = A3C17.Intersect(commonSeats17);
            List<int> LA3C17 = A3C17.ToList();
            A4C17 = A4C17.Intersect(commonSeats17);
            List<int> LA4C17 = A4C17.ToList();
            A5C17 = A5C17.Intersect(commonSeats17);
            List<int> LA5C17 = A5C17.ToList();
            A6C17 = A6C17.Intersect(commonSeats17);
            List<int> LA6C17 = A6C17.ToList();
            
            A1C18 = A1C18.Intersect(commonSeats18);
            List<int> LA1C18 = A1C18.ToList();
            A2C18 = A2C18.Intersect(commonSeats18);
            List<int> LA2C18 = A2C18.ToList();
            A3C18 = A3C18.Intersect(commonSeats18);
            List<int> LA3C18 = A3C18.ToList();
            A4C18 = A4C18.Intersect(commonSeats18);
            List<int> LA4C18 = A4C18.ToList();
            A5C18 = A5C18.Intersect(commonSeats18);
            List<int> LA5C18 = A5C18.ToList();
            A6C18 = A6C18.Intersect(commonSeats18);
            List<int> LA6C18 = A6C18.ToList();
            
            A1C19 = A1C19.Intersect(commonSeats19);
            List<int> LA1C19 = A1C19.ToList();
            A2C19 = A2C19.Intersect(commonSeats19);
            List<int> LA2C19 = A2C19.ToList();
            A3C19 = A3C19.Intersect(commonSeats19);
            List<int> LA3C19 = A3C19.ToList();
            A4C19 = A4C19.Intersect(commonSeats19);
            List<int> LA4C19 = A4C19.ToList();
            A5C19 = A5C19.Intersect(commonSeats19);
            List<int> LA5C19 = A5C19.ToList();
            A6C19 = A6C19.Intersect(commonSeats19);
            List<int> LA6C19 = A6C19.ToList();
            
            A1C20 = A1C20.Intersect(commonSeats20);
            List<int> LA1C20 = A1C20.ToList();
            A2C20 = A2C20.Intersect(commonSeats20);
            List<int> LA2C20 = A2C20.ToList();
            A3C20 = A3C20.Intersect(commonSeats20);
            List<int> LA3C20 = A3C20.ToList();
            A4C20 = A4C20.Intersect(commonSeats20);
            List<int> LA4C20 = A4C20.ToList();
            A5C20 = A5C20.Intersect(commonSeats20);
            List<int> LA5C20 = A5C20.ToList();
            A6C20 = A6C20.Intersect(commonSeats20);
            List<int> LA6C20 = A6C20.ToList();

            A1C21 = A1C21.Intersect(commonSeats21);
            List<int> LA1C21 = A1C21.ToList();
            A2C21 = A2C21.Intersect(commonSeats21);
            List<int> LA2C21 = A2C21.ToList();
            A3C21 = A3C21.Intersect(commonSeats21);
            List<int> LA3C21 = A3C21.ToList();
            A4C21 = A4C21.Intersect(commonSeats21);
            List<int> LA4C21 = A4C21.ToList();
            A5C21 = A5C21.Intersect(commonSeats21);
            List<int> LA5C21 = A5C21.ToList();
            A6C21 = A6C21.Intersect(commonSeats21);
            List<int> LA6C21 = A6C21.ToList();

            A1C22 = A1C22.Intersect(commonSeats22);
            List<int> LA1C22 = A1C22.ToList();
            A2C22 = A2C22.Intersect(commonSeats22);
            List<int> LA2C22 = A2C22.ToList();
            A3C22 = A3C22.Intersect(commonSeats22);
            List<int> LA3C22 = A3C22.ToList();
            A4C22 = A4C22.Intersect(commonSeats22);
            List<int> LA4C22 = A4C22.ToList();
            A5C22 = A5C22.Intersect(commonSeats22);
            List<int> LA5C22 = A5C22.ToList();
            A6C22 = A6C22.Intersect(commonSeats22);
            List<int> LA6C22 = A6C22.ToList();



            /*           if (availableTimesWithTables.Select(b => b.takenTime).Equals(availableTimes[0]))
                       {
                           commonSeats16 = availableTimesWithTables.Select(a => a.takenSeat).Intersect(GlobalListListBoxes[0]);
                       }*/


            int people = SeatsComboBox.SelectedIndex;
/*            //DateTime date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            double tableSize = 4.0;
            var tablesNeeded = Math.Ceiling(people / tableSize);*/
            if (AreaComboBox.SelectedIndex == 0)
            {
                if (hourCombobox.SelectedIndex == 0)
                {
                    GenerallistBox.DataSource = LA1C16;
                }
                if (hourCombobox.SelectedIndex == 1)
                {
                    GenerallistBox.DataSource = LA1C17;
                }
                if (hourCombobox.SelectedIndex == 2)
                {
                    GenerallistBox.DataSource = LA1C18;
                }
                if (hourCombobox.SelectedIndex == 3)
                {
                    GenerallistBox.DataSource = LA1C19;
                }
                if (hourCombobox.SelectedIndex == 4)
                {
                    GenerallistBox.DataSource = LA1C20;
                }
                if (hourCombobox.SelectedIndex == 5)
                {
                    GenerallistBox.DataSource = LA1C21;
                }
                if (hourCombobox.SelectedIndex == 6)
                {
                    GenerallistBox.DataSource = LA1C22;
                }
            }
            if (AreaComboBox.SelectedIndex == 1)
            {
                if (hourCombobox.SelectedIndex == 0)
                {
                    GenerallistBox.DataSource = LA2C16;
                }
                if (hourCombobox.SelectedIndex == 1)
                {
                    GenerallistBox.DataSource = LA2C17;
                }
                if (hourCombobox.SelectedIndex == 2)
                {
                    GenerallistBox.DataSource = LA2C18;
                }
                if (hourCombobox.SelectedIndex == 3)
                {
                    GenerallistBox.DataSource = LA2C19;
                }
                if (hourCombobox.SelectedIndex == 4)
                {
                    GenerallistBox.DataSource = LA2C20;
                }
                if (hourCombobox.SelectedIndex == 5)
                {
                    GenerallistBox.DataSource = LA2C21;
                }
                if (hourCombobox.SelectedIndex == 6)
                {
                    GenerallistBox.DataSource = LA2C22;
                }
            }
            if (AreaComboBox.SelectedIndex == 2)
            {
                if (hourCombobox.SelectedIndex == 0)
                {
                    GenerallistBox.DataSource = LA3C16;
                }
                if (hourCombobox.SelectedIndex == 1)
                {
                    GenerallistBox.DataSource = LA3C17;
                }
                if (hourCombobox.SelectedIndex == 2)
                {
                    GenerallistBox.DataSource = LA3C18;
                }
                if (hourCombobox.SelectedIndex == 3)
                {
                    GenerallistBox.DataSource = LA3C19;
                }
                if (hourCombobox.SelectedIndex == 4)
                {
                    GenerallistBox.DataSource = LA3C20;
                }
                if (hourCombobox.SelectedIndex == 5)
                {
                    GenerallistBox.DataSource = LA3C21;
                }
                if (hourCombobox.SelectedIndex == 6)
                {
                    GenerallistBox.DataSource = LA3C22;
                }
            }
            if (AreaComboBox.SelectedIndex == 3)
            {
                if (hourCombobox.SelectedIndex == 0)
                {
                    GenerallistBox.DataSource = LA4C16;
                }
                if (hourCombobox.SelectedIndex == 1)
                {
                    GenerallistBox.DataSource = LA4C17;
                }
                if (hourCombobox.SelectedIndex == 2)
                {
                    GenerallistBox.DataSource = LA4C18;
                }
                if (hourCombobox.SelectedIndex == 3)
                {
                    GenerallistBox.DataSource = LA4C19;
                }
                if (hourCombobox.SelectedIndex == 4)
                {
                    GenerallistBox.DataSource = LA4C20;
                }
                if (hourCombobox.SelectedIndex == 5)
                {
                    GenerallistBox.DataSource = LA4C21;
                }
                if (hourCombobox.SelectedIndex == 6)
                {
                    GenerallistBox.DataSource = LA4C22;
                }
            }
            if (AreaComboBox.SelectedIndex == 4)
            {
                if (hourCombobox.SelectedIndex == 0)
                {
                    GenerallistBox.DataSource = LA5C16;
                }
                if (hourCombobox.SelectedIndex == 1)
                {
                    GenerallistBox.DataSource = LA5C17;
                }
                if (hourCombobox.SelectedIndex == 2)
                {
                    GenerallistBox.DataSource = LA5C18;
                }
                if (hourCombobox.SelectedIndex == 3)
                {
                    GenerallistBox.DataSource = LA5C19;
                }
                if (hourCombobox.SelectedIndex == 4)
                {
                    GenerallistBox.DataSource = LA5C20;
                }
                if (hourCombobox.SelectedIndex == 5)
                {
                    GenerallistBox.DataSource = LA5C21;
                }
                if (hourCombobox.SelectedIndex == 6)
                {
                    GenerallistBox.DataSource = LA5C22;
                }
            }
            if (AreaComboBox.SelectedIndex == 5)
            {
                if (hourCombobox.SelectedIndex == 0)
                {
                    GenerallistBox.DataSource = LA6C16;
                }
                if (hourCombobox.SelectedIndex == 1)
                {
                    GenerallistBox.DataSource = LA6C17;
                }
                if (hourCombobox.SelectedIndex == 2)
                {
                    GenerallistBox.DataSource = LA6C18;
                }
                if (hourCombobox.SelectedIndex == 3)
                {
                    GenerallistBox.DataSource = LA6C19;
                }
                if (hourCombobox.SelectedIndex == 4)
                {
                    GenerallistBox.DataSource = LA6C20;
                }
                if (hourCombobox.SelectedIndex == 5)
                {
                    GenerallistBox.DataSource = LA6C21;
                }
                if (hourCombobox.SelectedIndex == 6)
                {
                    GenerallistBox.DataSource = LA6C22;
                }
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

            // RBL: Ga naar check reservation form zodat ze daar hun reseervatie zien en kunnen kijken of het klopt/het aanpassen
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
            if (hourCombobox.SelectedIndex == 0)
            {
                int hour = 16;
                return hour;
            }
            if (hourCombobox.SelectedIndex == 1)
            {
                int hour = 17;
                return hour;
            }
            if (hourCombobox.SelectedIndex == 2)
            {
                int hour = 18;
                return hour;
            }
            if (hourCombobox.SelectedIndex == 3)
            {
                int hour = 19;
                return hour;
            }
            if (hourCombobox.SelectedIndex == 4)
            {
                int hour = 20;
                return hour;
            }
            if (hourCombobox.SelectedIndex == 5)
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
            string tableNumberString = GenerallistBox.SelectedItem.ToString();
            int tableNumber = Convert.ToInt32(tableNumberString);
            return tableNumber;
        }

        private void PlaceReservationButton_Click(object sender, EventArgs e)
        {
            makeReservation(globalUserId);
        }

        private void menuButton_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            checkReservation reservationForm = new checkReservation(Login.person.id);
            reservationForm.Show();
        }

        private void loginButton_LinkClicked(object sender, EventArgs e)
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

        private void LuxeFoodsLogoLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage HomepageForm = new homePage();
            HomepageForm.Show();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void restaurantComboCox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerallistBox.DataSource = null;
        }

        private void SeatsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerallistBox.DataSource = null;
        }

        private void AreaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerallistBox.DataSource = null;
        }

        private void hourCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerallistBox.DataSource = null;
        }
    }
}
