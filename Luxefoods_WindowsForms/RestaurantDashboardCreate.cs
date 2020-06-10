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
    public partial class RestaurantDashboardCreate : Form
    {
        int globalAdminID;
        string globalPrevious;
        public RestaurantDashboardCreate(int adminID, string previous = "")
        {
            globalAdminID = adminID;
            globalPrevious = previous;
            InitializeComponent();
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
