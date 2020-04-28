using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ReservationApp_BackEnd
{
    // Class that stores data of takenSeats
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

    class Program
    {
        //Connection string to connect with the database
        SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        static void Main(string[] args)
        {
            string val;
            int a = 0;
            Console.WriteLine("Welcome to the Back-End API of LuxeFoods reservation system!\n\n");

            int userId = 0;

            Console.WriteLine("\nEnter your Email: ");
            string userEmail = Console.ReadLine();
            Console.WriteLine("\nEnter your Password: ");
            string userPassword = Console.ReadLine();

            //Check of beide ingevuld zijn, als wel dan data naar database versturen om te kijken of bestaat in de database
            if (userEmail == "" || userPassword == "")
            {
                Console.WriteLine("Vul alle velden in.");
            }
            else
            {
                string q = $"SELECT DISTINCT * FROM [user] WHERE email='{userEmail}'";
                string que = $"SELECT id from [user] where email='{userEmail}'";
                string password = "";
                string typedPassword = EncryptPassword(userPassword);
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(q, con);
                        SqlCommand cmnd = new SqlCommand(que, con);
                        cmd.ExecuteNonQuery();
                        
                        // Kijk of user in de database staat en als wel zijn ID opslaan
                        using (SqlDataReader reader = cmnd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                userId = reader.GetInt32(0);
                            }
                        }

                        // Connectie met database beindigen
                        con.Close();
                        //Alle account met zelde email zoals gegeven in login in een dataset zetten
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //Loopen door de dataset om te kijken of de wachtwoord over een komt met de geven wachtwoord
                        foreach (DataRow dr in dt.Rows)
                        {
                            password = dr["password"].ToString();
                        }
                        //Als alles klopt gebruiker inloggen of anders error message geven
                        if (typedPassword == password)
                        {
                            Console.WriteLine("Je bent nu ingelogd.");
                        }
                        else
                        {
                            Console.WriteLine("deze gebruiker bestaat niet, of het wachtwoord is verkeerd ingevuld.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            bool stopLoop = false;
            while(!stopLoop)
            {
                Console.WriteLine("\n\nWhat do you want to do?");
                Console.WriteLine("1-Make Reservation 2-Check Reservation 3-Change Reservation 4-Exit");
                val = Console.ReadLine();

                try
                {
                    a = Convert.ToInt32(val);
                }
                catch
                {
                    Console.WriteLine("Please Enter a Number");
                }
                if (a == 1)
                {
                    Program program = new Program();
                    program.makeReservation(userId);
                }
                else if (a == 2)
                {
                    checkReservation(userId);
                }
                else if (a == 3)
                {
                    changeReservation(userId);
                }
                else if (a == 4)
                {
                    stopLoop = true;
                    Console.WriteLine("Exiting the program...");
                }
                else
                {
                    Console.WriteLine("U can only choose between 1, 2 and 3");
              }
            }
            Console.WriteLine("Escaped the while loop!");
        }

        //Gebruik de Cryptography en Text library om de gegeven string te hashen
        static string EncryptPassword(string text)
        {
            //MD5 maakt een hashed wachtwoord in vorm van bytes dus het moet nog geconverteerd worden naar een string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(text));
                return Convert.ToBase64String(data);
            }
        }

        void makeReservation(int userId)
        {
            Console.WriteLine("You can now go and make reservation!\n");
            int restaurantId = 0;
            string restaurantIdString;

            List<string> RestaurantNames = new List<string>();

            //Maak een request naar de database om alle restaurant namen in een List op te slaan
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

            Console.WriteLine("Which restaurant do you want to make a reservation for?");
            string restaurantChoice = "";
            int incr = 1;

            // Restaurant kiezen met wat bug defense
            foreach (string x in RestaurantNames)
            {
                restaurantChoice += incr + "-" + x + " ";
                incr++;
            }
            Console.WriteLine(restaurantChoice);
            restaurantIdString = Console.ReadLine();
            try
            {
                restaurantId = Convert.ToInt32(restaurantIdString);
            }
            catch
            {
                Console.WriteLine("Enter a number!");
            }

            Console.WriteLine("When do you want to make the reservation?");
            Console.WriteLine("Write it in this format YYYY-MM-DD");
            string date;
            date = Console.ReadLine();

            // Convert de data string naar een DateTime variabele
            DateTime parsedDate = DateTime.Parse(date);
      
            Console.WriteLine("\nThis is your date: " + parsedDate);

            // Initializeer aantal Lists
            List<DateTime> availableTimes = new List<DateTime>() {
                new DateTime(parsedDate.Year, parsedDate.Month, parsedDate.Day, 16, 00, 00),
                new DateTime(parsedDate.Year, parsedDate.Month, parsedDate.Day, 17, 00, 00),
                new DateTime(parsedDate.Year, parsedDate.Month, parsedDate.Day, 18, 00, 00),
                new DateTime(parsedDate.Year, parsedDate.Month, parsedDate.Day, 19, 00, 00),
                new DateTime(parsedDate.Year, parsedDate.Month, parsedDate.Day, 20, 00, 00),
                new DateTime(parsedDate.Year, parsedDate.Month, parsedDate.Day, 21, 00, 00),
                new DateTime(parsedDate.Year, parsedDate.Month, parsedDate.Day, 22, 00, 00)
            };
            List<TakenSeats> takenTimesWithTables = new List<TakenSeats>();
            List<TakenSeats> availableTimesWithTables = new List<TakenSeats>();

            // Algorithm om een List vol te maken met alle mogelijke tijden om te reserveren y = aantal restauranten (1-2), i = lengte van de availableTimes List (max 7) en x = de max mogelijke tafels (max 55)
            for (int y = 1; y < RestaurantNames.Count+1; y++)
            {
                for (int i = 0; i < availableTimes.Count; i++)
                {
                    for (int x = 1; x <= 55; x++)
                    {
                        availableTimesWithTables.Add(new TakenSeats(availableTimes[i], x, y));
                    }
                }
            }
            
            // Request naar Databse sturen om alle gereserveerde tijden op de eerder gegeven datum te krijgen en in takenTimesWithTables List te zetten
            SqlCommand readCommand = new SqlCommand("select datum, tafelNummer, restaurantId from reservering where datum between '" + parsedDate.Month + "/" + parsedDate.Day + "/" + parsedDate.Year + "' and '" + parsedDate.Month + "/" + parsedDate.Day + "/" + parsedDate.Year + " 23:59:59'", connection);
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

            Console.WriteLine("Succesfully finished getting all the available times");

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

            //Alleen de overgebleven werkelijke availableTimesWithTables laten zien
            Console.WriteLine("Those are all the available times for " + parsedDate.Year + "-" + parsedDate.Month + "-" + parsedDate.Day + ": ");
            foreach (TakenSeats x in availableTimesWithTables)
            {
                Console.WriteLine(x.takenTime + " and seat nr. " + x.takenSeat);
            }

            Console.WriteLine("Please choose at what hour you want to make reservation: ");

            // Security check of de uren tussen de openings tijden zitten
            int hour = 0;   
            while (hour < 16 || hour > 23)
            {
                string time = Console.ReadLine();

                hour = Convert.ToInt32(time);
            }
            
            // De uur van int naar een TimeSpan converteren en aan de date string toevoegen (date blijft nog steeds een string)
            TimeSpan ts = new TimeSpan(hour, 0, 0);
            date += " " + ts;

            // Date opnieuw naar DateTime variabele omzetten voor makkelijkere code writing
            parsedDate = DateTime.Parse(date);

            int tableNumber = 0;

            //Tafel keuze
            Console.WriteLine("\nWhich table do you want to reserve? Enter a number: ");
            string tableNumberString = Console.ReadLine();
            try
            {
                tableNumber = Convert.ToInt32(tableNumberString);
            }
            catch
            {
                Console.WriteLine("Please enter a number");
            }

            // Checken of alles klopt
            Console.WriteLine("Your reservation is Finished!");
            Console.WriteLine("This is how you reservation looks like!");
            Console.WriteLine("UserId: " + userId + ", RestaurantId: " + restaurantId + ", Date: " + parsedDate + ", Table Number: " + tableNumber);
            bool submitChecked = false;
            while(!submitChecked)
            {
                Console.WriteLine("\nDo you want to submit the reservation? (1-yes/2-no)");
                string answer = Console.ReadLine();

                // Als 1 dan data versturen
                int answer32 = Convert.ToInt32(answer);
                if (answer32 == 1)
                {
                    bool trueData = true;

                    // Security check om te kijken of de uiteindelijke data zeker beschikbaar is
                    foreach (TakenSeats x in takenTimesWithTables)
                    {

                        // Als gereserveerde tijd zelfde is als gekozen tijd en tafel nummer zelfde is als gekozen tafel nummer en restaurant ids zijn ook zelfde dan is die plek als gereserveerd door iemand anders
                        if (x.takenTime == parsedDate && x.takenSeat == tableNumber && x.restaurantId == restaurantId)
                        {
                            Console.WriteLine("There is already an reservation made for this time and table! Please choose another time or table.");
                            trueData = false;
                            break;
                        }
                    }

                    // Als dit niet klopt dan sturen wij de data naar de database
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open && trueData)
                    {

                        // SQL Command om de RestaurantId, UserId, date en tableNumber in de database in de juiste plekken te zetten
                        string q = $"INSERT INTO [reservering] (restaurantId, klantId, datum, tafelNummer) VALUES  ('{restaurantId}', '{userId}', '{date}', '{tableNumber}')";

                        try
                        {

                            // de SQL command in een command zetten met de erbij toegevoegde connection string
                            SqlCommand cmd = new SqlCommand(q, connection);

                            // Execute een non query command in de database
                            cmd.ExecuteNonQuery();

                            
                            Console.WriteLine("Reservation Has been Succesfully Sumbited");
                            submitChecked = !submitChecked;
                        }
                        catch (Exception ex)
                        {
                            //Error handler, print gelijk de error uit
                            Console.WriteLine(ex.Message);
                        }
                    }

                    // Connectie met database beindigen
                    connection.Close();

                //Als 2 dan reservering annuleren
                } else if (answer32 == 2)
                {
                    Console.WriteLine("Canceling Reservation....");
                    submitChecked = !submitChecked;
                } 
                else
                {
                    Console.WriteLine("Please Enter either y or n!");
                }
            }
        }

        // Class die alle data van de reservatie van de database opslaat
        class reservation
        {
            public int Id { get; set; }
            public int restaurantId { get; set; }
            public int klantId { get; set; }
            public DateTime Date { get; set; }
            public int tableNr { get; set; }
            
            public reservation(int id, int restaurantid, int klantid, DateTime date, int tablenr)
            {
                Id = id;
                restaurantId = restaurantid;
                klantId = klantid;
                Date = date;
                tableNr = tablenr;
            }
        }

        // Class die alle data van de restauranten van de database opslaat
        class restaurants
        {
            public int Id { get; set; }
            public string Naam { get; set; }
            public int menuId { get; set; }
            public int amountTables { get; set; }

            public restaurants(int id, string naam, int amounttables, int menuid = 0)
            {
                Id = id;
                Naam = naam;
                menuId = menuid;
                amountTables = amounttables;
            }
        }


        static void checkReservation(int userId)
        {
            Console.WriteLine("These are your current reservation:\n");

            // List die uit reservatie class objecten bestaat
            List<reservation> userReservations = new List<reservation>();

            //Connectie string
            SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
           
            // SQL command om alle reserveringen met de gegeven KlantId te geven
            SqlCommand readCommand = new SqlCommand("select * from reservering where klantId='" + userId + "'", connection);
            connection.Open();
            using (SqlDataReader reader = readCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Al de gegeven reserveringen in een object zetten en dan in de List opslaan
                    reservation _ = new reservation(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetInt32(4));
                    userReservations.Add(_);
                }

                // Connectie met database beindigen
                connection.Close();
            }

            List<restaurants> allRestaurants = new List<restaurants>();
            
            // SQL Command om alle restaurant data te krijgen
            SqlCommand restReadCommand = new SqlCommand("select * from restaurant", connection);
            connection.Open();
            using (SqlDataReader reader = restReadCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Alle restaurant info in een object zetten en in de list opslaan
                    restaurants _ = new restaurants(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(3));
                    allRestaurants.Add(_);
                }

                // Connectie met database beindigen
                connection.Close();
            }

            // Alle reservering van deze user uitprinten format(id:tt tttt yyyy-mm-dd hh-mm-ss tt)
            foreach (reservation x in userReservations)
            {
                Console.WriteLine("id: " + x.Id + " " + allRestaurants[x.restaurantId-1].Naam + " " + x.Date + " Gereserveerde Tafels: " + x.tableNr);
            }
        }

        static void changeReservation(int userId)
        {
            Console.WriteLine("Enter your reservation id");

            //Convert de string gelijk naar een int
            int searchId = Convert.ToInt32(Console.ReadLine());
            
            // Gevonden reservatie als een reservatie class initializeren met fake data
            reservation foundReservation = new reservation(0,0,0,new DateTime(),0);

            // SQL Request maken om de gegeven reservering ID in database te vinden
            SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand readCommand = new SqlCommand("select * from reservering where Id='" + searchId + "'", connection);
            connection.Open();
            using (SqlDataReader reader = readCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Als gevonden dan wordt de data in de eerder gemaakte class opgeslagen
                    foundReservation = new reservation(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetInt32(4));
                }

                // Connectie met database beindigen
                connection.Close();
            }

            // List met alle restauranten te maken die alleen onze eigen classen (restaurants) zijn
            List<restaurants> allRestaurants = new List<restaurants>();

            // SQL Request maken om alle data van alle restauranten te krijgen
            SqlCommand restReadCommand = new SqlCommand("select * from restaurant", connection);
            connection.Open();
            using (SqlDataReader reader = restReadCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    // De ontvangen data in een restaurants object zetten en dan in de List
                    restaurants _ = new restaurants(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(3));
                    allRestaurants.Add(_);
                }

                // Connectie met database beindigen
                connection.Close();
            }

            

            bool check = false;
            while (!check)
            {
                // Checken of de reservatie klopt als niet dan opnieuw kijken
                Console.WriteLine("Is this your reservation? (y/n) " + foundReservation.Id + " " + allRestaurants[foundReservation.restaurantId - 1].Naam + " " + foundReservation.Date + " tafel nr. " + foundReservation.tableNr);
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    check = !check;
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Leaving...");
                    check = !check;
                }
                else
                {
                    Console.WriteLine("Please Enter y or n");
                }
            }

            check = false;
            while (!check)
            {
                Console.WriteLine("What do you want to change?");
                Console.WriteLine("1-Datum");
                Console.WriteLine("2-Tijd");
                Console.WriteLine("3-Tafel Nummer");
                Console.WriteLine("4-Restaurant Id");
                int changeOption = Convert.ToInt32(Console.ReadLine());

                // Als 1 dan datum veranderen
                if (changeOption == 1)
                {
                    bool correctData = true;
                    check = !check;
                    string newDate = "";
                    Console.WriteLine("Changing Datum");
                    Console.WriteLine("Your Current Date is: " + foundReservation.Date);

                    check = false;
                    while(!check)
                    {
                        Console.WriteLine("Which date do you want it to switch to?");

                        // nieuwe datum als string houden
                        newDate = Console.ReadLine();

                        // nieuwe datum in een DateTime variabele opslaan om makkelijker de object te kunnen deconstructen
                        DateTime newDateTime = DateTime.Parse(newDate);

                        //Checken of de nieuwe datum niet zelfde is als de bestaande datum
                        if (newDateTime != foundReservation.Date.Date)
                        {
                            // de zelfe tijd van de oude reservatie op de nieuwe datum string toevoegen
                            newDate += " " + foundReservation.Date.TimeOfDay;

                            //SQL request maken voor alle reserveringen met de gegeven datum te krijgen
                            string q = $"SELECT * FROM [reservering] WHERE datum='{newDate}'";

                            List<int> restaurantIds = new List<int>();
                            List<int> tafelNummers = new List<int>();
                            List<DateTime> datums = new List<DateTime>();

                            try
                            {
                                // SQL Connection string
                                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                                con.Open();
                                if (con.State == System.Data.ConnectionState.Open)
                                {
                                    // SQL Request in een SqlCommand class zetten met de SQL connection string erbij
                                    SqlCommand cmd = new SqlCommand(q, con);

                                    // SQL Request uitvoeren
                                    cmd.ExecuteNonQuery();

                                    //De ontvangen data in een dataset zetten
                                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);

                                    //Loopen door de dataset en alle ontvangen string naar de nodige type veranderen in de passende List zetten
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        datums.Add(Convert.ToDateTime(dr["datum"].ToString()));
                                        restaurantIds.Add(Convert.ToInt32(dr["restaurantId"].ToString()));
                                        tafelNummers.Add(Convert.ToInt32(dr["tafelNummer"].ToString()));
                                    }
                                }

                                // Connectie met database beindigen
                                con.Close();
                            }
                            // Error handler die de message gelijk print
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            int count = 0;

                            // Kijken voor elke ontvangen reservering met zelfde datum of die ook op zelfde restaurant, tafel nummer en tijd gereserveerd zijn, als wel dan niks doen
                            foreach (int x in restaurantIds)
                            {
                                if (x == foundReservation.restaurantId && tafelNummers[count] == foundReservation.tableNr && foundReservation.Date.TimeOfDay == datums[count].TimeOfDay)
                                {
                                    Console.WriteLine("This place has already been taken");
                                    correctData = false;
                                }
                                count++;
                            }
                            check = !check;
                        }
                        else
                        {
                            Console.WriteLine("You entered the same date!");
                        }
                    }
                    // Als correctData door vorige check niet false is dan wordt de data gestuurd
                    if (correctData)
                    {
                        try
                        {
                            // SQL UPDATE Request om de nieuwe datum voor de gegeven reservering id te veranderen
                            SqlCommand Command = new SqlCommand("UPDATE reservering SET datum='" + newDate + "' WHERE Id='" + foundReservation.Id + "'", connection);
                            connection.Open();

                            // Execute de SQL UPDATE Request
                            Command.ExecuteNonQuery();

                            // Connectie met database beindigen
                            connection.Close();
                            Console.WriteLine("Succesfully Changed the date to " + newDate);
                        }
                        // Error handler die de message gelijk print
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                        }   
                    }
                }
                // Als 2 dan tijd veranderen
                else if (changeOption == 2)
                {
                    bool correctData = true;
                    check = !check;
                    string newTime = "";
                    string dateString = "";
                    Console.WriteLine("Changing Tijd");
                    Console.WriteLine("Your Current DateTime is: " + foundReservation.Date);

                    check = false;
                    while (!check)
                    {
                        Console.WriteLine("Which time do you want it to switch to? just put in the Hour");
                        // Check of de gegeven uur tussen de opening tijden van het restaurant past
                        int hour = 0;
                        while (hour < 16 || hour > 23)
                        {
                            newTime = Console.ReadLine();

                            hour = Convert.ToInt32(newTime);
                        }

                        // de nieuwe tijd in een TimeSpan variabele zetten
                        TimeSpan newTimeSpan = new TimeSpan(hour, 0, 0);

                        // Checken of de nieuwe tijd niet zelfde is als de oude tijd
                        if (newTimeSpan != foundReservation.Date.TimeOfDay)
                        {
                            // De nieuwe tijd aan de datum string toevoegen
                            dateString = foundReservation.Date.Year + "-" + foundReservation.Date.Month + "-" + foundReservation.Date.Day;
                            dateString += " " + newTimeSpan;

                            // Datum opnieuw converten naar een DateTime variabele om de object makkelijker te deconstructen
                            DateTime dateDateTime = DateTime.Parse(dateString);
                            
                            // SQL Request om alle data van reserveringen met de gegeven datum te naar ons te sturen
                            string q = $"SELECT * FROM [reservering] WHERE datum='{dateString}'";

                            List<int> restaurantIds = new List<int>();
                            List<int> tafelNummers = new List<int>();
                            List<DateTime> datums = new List<DateTime>();

                            try
                            {
                                // SQL Connection string
                                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                                con.Open();
                                if (con.State == System.Data.ConnectionState.Open)
                                {
                                    // SQL Request + Connection String samen 
                                    SqlCommand cmd = new SqlCommand(q, con);

                                    // SQL Command uitvoeren
                                    cmd.ExecuteNonQuery();

                                    // SQL Command ontvangen data in een DataTable zetten
                                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);

                                    //Loopen door de dataset en alle ontvangen string naar de nodige type veranderen in de passende List zetten
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        datums.Add(Convert.ToDateTime(dr["datum"].ToString()));
                                        restaurantIds.Add(Convert.ToInt32(dr["restaurantId"].ToString()));
                                        tafelNummers.Add(Convert.ToInt32(dr["tafelNummer"].ToString()));
                                    }
                                }
                                // Connectie met database beindigen
                                con.Close();
                            }
                            // Error handler die de message gelijk print
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            int count = 0;

                            // Kijken voor elke ontvangen reservering met zelfde datum of die ook op zelfde restaurant, tafel nummer en tijd gereserveerd zijn, als wel dan niks doen
                            foreach (int x in restaurantIds)
                            {
                                if (x == foundReservation.restaurantId && tafelNummers[count] == foundReservation.tableNr && dateDateTime.Date.TimeOfDay == datums[count].TimeOfDay)
                                {
                                    Console.WriteLine("This place has already been taken");
                                    correctData = false;
                                }
                                count++;
                            }
                            check = !check;
                        }
                        else
                        {
                            Console.WriteLine("You entered the same date!");
                        }
                    }
                    // Als correctData door vorige check niet false is dan wordt de data gestuurd
                    if (correctData)
                    {
                        try
                        {
                            // SQL UPDATE Request om de nieuwe datum met tijd voor de gegeven reservering id te veranderen
                            SqlCommand Command = new SqlCommand("UPDATE reservering SET datum='" + dateString + "' WHERE Id='" + foundReservation.Id + "'", connection);
                            connection.Open();

                            // SQL Command uitvoeren
                            Command.ExecuteNonQuery();

                            // Connectie met database beindigen
                            connection.Close();
                            Console.WriteLine("Succesfully Changed the date to " + dateString);
                        }
                        // Error handler die de message gelijk print
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
                // Als 3 dan Tafel nummer veranderen
                else if (changeOption == 3)
                {
                    bool correctData = true;
                    check = !check;
                    int newTableNr = 0;
                    string dateString = "";
                    Console.WriteLine("Changing Tafel Nummer");

                    Console.WriteLine("Your Current TableNumber is: " + foundReservation.tableNr);

                    check = false;
                    while (!check)
                    {
                        Console.WriteLine("Which table Number do you want to switch to? Enter a valid number between 1-" + allRestaurants[foundReservation.restaurantId-1].amountTables);

                        // Check of de gegeven tafel nummer in de gegeven restaurant bestaat
                        while (newTableNr < 1 || newTableNr > allRestaurants[foundReservation.restaurantId-1].amountTables)
                        {
                            newTableNr = Convert.ToInt32(Console.ReadLine());
                        }

                        // Checken of de nieuwe tafel nummer niet zelfde is als de oude
                        if (newTableNr != foundReservation.tableNr)
                        {
                            // De foundReservation.Date deconstructen om een valid sql string ervan te maken
                            dateString = foundReservation.Date.Year + "-" + foundReservation.Date.Month + "-" + foundReservation.Date.Day + " " + foundReservation.Date.TimeOfDay;

                            // SQL Request om alle data van reserveringen met de gegeven datum te naar ons te sturen
                            string q = $"SELECT * FROM [reservering] WHERE datum='{dateString}'";

                            List<int> restaurantIds = new List<int>();
                            List<int> tafelNummers = new List<int>();
                            List<DateTime> datums = new List<DateTime>();

                            try
                            {
                                // SQL Connection String
                                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                                con.Open();
                                if (con.State == System.Data.ConnectionState.Open)
                                {

                                    // SQL Request + Connection string in een SqlCommand variabele
                                    SqlCommand cmd = new SqlCommand(q, con);

                                    // SQL Command uitvoeren
                                    cmd.ExecuteNonQuery();

                                    // SQL Command ontvangen data in een DataTable zetten
                                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);

                                    //Loopen door de dataset en alle ontvangen string naar de nodige type veranderen in de passende List zetten
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        datums.Add(Convert.ToDateTime(dr["datum"].ToString()));
                                        restaurantIds.Add(Convert.ToInt32(dr["restaurantId"].ToString()));
                                        tafelNummers.Add(Convert.ToInt32(dr["tafelNummer"].ToString()));
                                    }
                                }
                                // Connectie met database beindigen
                                con.Close();
                            }
                            // Error handler die de message gelijk print
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            int count = 0;

                            // Kijken voor elke ontvangen reservering met zelfde datum of die ook op zelfde restaurant, tafel nummer en tijd gereserveerd zijn, als wel dan niks doen
                            foreach (int x in restaurantIds)
                            {
                                if (x == foundReservation.restaurantId && tafelNummers[count] == newTableNr && foundReservation.Date == datums[count])
                                {
                                    Console.WriteLine("This place has already been taken");
                                    correctData = false;
                                }
                                count++;
                            }
                            check = !check;
                        }
                        else
                        {
                            Console.WriteLine("You entered the same date!");
                        }
                    }
                    // Als correctData door vorige check niet false is dan wordt de data gestuurd
                    if (correctData)
                    {
                        try
                        {
                            // SQL UPDATE Request om de nieuwe tafel nummer voor de gegeven reservering id te veranderen
                            SqlCommand Command = new SqlCommand("UPDATE reservering SET tafelNummer='" + newTableNr + "' WHERE Id='" + foundReservation.Id + "'", connection);
                            connection.Open();

                            // SQL Command uitvoeren
                            Command.ExecuteNonQuery();

                            // Connectie met database beindigen
                            connection.Close();
                            Console.WriteLine("Succesfully Changed the table Number to " + newTableNr);
                        }
                        // Error handler die de message gelijk print
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
                // Als 4 dan Restaurant veranderen
                else if (changeOption == 4)
                {
                    bool correctData = true;
                    check = !check;
                    int newRestaurantId = 0;
                    string dateString = "";
                    SqlCommand Cmd = new SqlCommand();
                    Console.WriteLine("Changing Restaurant");

                    Console.WriteLine("Your Current Restaurant ID is: " + foundReservation.restaurantId + " name: " + allRestaurants[foundReservation.restaurantId-1].Naam);

                    check = false;
                    while (!check)
                    {
                        Console.WriteLine("Which restaurant ID do you want to switch to? Enter a valid number between 1-" + allRestaurants.Count);

                        // Check of de gegeven restaurant id bestaat
                        while (newRestaurantId < 1 || newRestaurantId > allRestaurants[foundReservation.restaurantId - 1].amountTables)
                        {
                            newRestaurantId = Convert.ToInt32(Console.ReadLine());
                        }

                        // Check of de gegeven tafel nummer in de gegeven restaurant
                        while (foundReservation.tableNr > allRestaurants[newRestaurantId-1].amountTables)
                        {
                            Console.WriteLine("The table number doesnt exist in this restaurant, please choose a different table number between 1-" + allRestaurants[newRestaurantId - 1].amountTables);
                            foundReservation.tableNr = Convert.ToInt32(Console.ReadLine());
                        }

                        // SQL UPDATE Request om de nieuwe tafel nummer voor de gegeven reservering id te veranderen
                        Cmd = new SqlCommand("UPDATE reservering SET tafelNummer='" + foundReservation.tableNr + "' WHERE Id='" + foundReservation.Id + "'", connection);

                        // Checken of de nieuwe restaurant id niet zelfde is als de oude
                        if (newRestaurantId != foundReservation.restaurantId)
                        {
                            // De foundReservation.Date deconstructen om een valid sql string ervan te maken
                            dateString = foundReservation.Date.Year + "-" + foundReservation.Date.Month + "-" + foundReservation.Date.Day + " " + foundReservation.Date.TimeOfDay;

                            // SQL Request om alle data van reserveringen met de gegeven datum te naar ons te sturen
                            string q = $"SELECT * FROM [reservering] WHERE datum='{dateString}'";

                            List<int> restaurantIds = new List<int>();
                            List<int> tafelNummers = new List<int>();
                            List<DateTime> datums = new List<DateTime>();

                            try
                            {
                                // SQL Connection String
                                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                                con.Open();
                                if (con.State == System.Data.ConnectionState.Open)
                                {
                                    // SQL Request + SQL Connection String
                                    SqlCommand cmd = new SqlCommand(q, con);

                                    // SQL Command uitvoeren
                                    cmd.ExecuteNonQuery();

                                    // SQL Command ontvangen data in een DataTable zetten
                                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);

                                    //Loopen door de dataset en alle ontvangen string naar de nodige type veranderen in de passende List zetten
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        datums.Add(Convert.ToDateTime(dr["datum"].ToString()));
                                        restaurantIds.Add(Convert.ToInt32(dr["restaurantId"].ToString()));
                                        tafelNummers.Add(Convert.ToInt32(dr["tafelNummer"].ToString()));
                                    }
                                }
                                // Connectie met database beindigen
                                con.Close();
                            }
                            // Error handler die de message gelijk print
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            int count = 0;

                            // Kijken voor elke ontvangen reservering met zelfde datum of die ook op zelfde restaurant, tafel nummer en tijd gereserveerd zijn, als wel dan niks doen
                            foreach (int x in restaurantIds)
                            {
                                if (x == newRestaurantId && tafelNummers[count] == foundReservation.tableNr && foundReservation.Date == datums[count])
                                {
                                    Console.WriteLine("This place has already been taken");
                                    correctData = false;
                                }
                                count++;
                            }
                            check = !check;
                        }
                        else
                        {
                            Console.WriteLine("You entered the same date!");
                        }
                    }
                    // Als correctData door vorige check niet false is dan wordt de data gestuurd
                    if (correctData)
                    {
                        try
                        {
                            // SQL UPDATE Request om de nieuwe restaurant id voor de gegeven reservering id te veranderen
                            SqlCommand Command = new SqlCommand("UPDATE reservering SET restaurantId='" + newRestaurantId + "' WHERE Id='" + foundReservation.Id + "'", connection);
                            connection.Open();

                            // SQL Command restaurantID Update uitvoeren
                            Command.ExecuteNonQuery();

                            // SQL Command tafel nummer UPDATE uitvoeren
                            Cmd.ExecuteNonQuery();

                            // Connectie met database beindigen
                            connection.Close();
                            Console.WriteLine("Succesfully Changed the restaurant id to " + newRestaurantId + " on the name of " + allRestaurants[newRestaurantId-1].Naam + " with table number " + foundReservation.tableNr);
                        }
                        // Error handler die de message gelijk print
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid option");
                }
            }
        }
    }
}