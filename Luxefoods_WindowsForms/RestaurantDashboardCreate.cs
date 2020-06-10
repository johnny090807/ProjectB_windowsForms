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
    public partial class RestaurantDashboardCreate : Form
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

        int globalAdminID;
        string globalPrevious;
        public RestaurantDashboardCreate(int adminID, string previous = "")
        {
            globalAdminID = adminID;
            globalPrevious = previous;
            InitializeComponent();
            CenterToScreen();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            if (globalPrevious == "restaurantDashboard")
            {
                this.Hide();
                RestaurantenDashboard restaurantenDashboard = new RestaurantenDashboard(globalAdminID, "dashboard");
                restaurantenDashboard.Show();
            }
        }

        private void CreateItem_Click(object sender, EventArgs e)
        {
            if (restaurantNaamInput.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO [restaurant] (naam, aantalTafels) VALUES  ('{restaurantNaamInput.Text}', '{55}')", con);
                try
                {
                    // Execute een non query command in de database
                    command.ExecuteNonQuery();

                    DataSet ds = new DataSet();
                    command = new SqlCommand($"SELECT * from [restaurant] WHERE naam='{restaurantNaamInput.Text}'", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(command);
                    adapt.FillSchema(ds, SchemaType.Source, "Restauranten");
                    adapt.Fill(ds, "Restauranten");

                    DataTable tblRestauranten = ds.Tables["Restauranten"];

                    foreach (DataRow x in tblRestauranten.Rows)
                    {
                        if (x["naam"].ToString() == restaurantNaamInput.Text)
                        {
                            command = new SqlCommand($"UPDATE [restaurant] SET menuId='{(int) x["id"]}' WHERE naam='{x["naam"].ToString()}'", con);

                            // Execute de SQL UPDATE Request
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Reservation has succesfully been submitted");
                    GoBack();
                }
                catch (Exception ex)
                {
                    //Error handler, print gelijk de error uit
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }
            else if (restaurantNaamInput.Text == "")
            {
                MessageBox.Show("Missing a name");
            }
            else
            {
                MessageBox.Show("If u see this message contact the support.");
            }
        }
    }
}
