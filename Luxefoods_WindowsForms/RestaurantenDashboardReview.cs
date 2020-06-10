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
    public partial class RestaurantenDashboardReview : Form
    {
        int globalRestaurantId;
        int globalAdminID;
        string globalPrevious;
        public RestaurantenDashboardReview(int restaurantID, int adminID, string previous = "")
        {
            globalRestaurantId = restaurantID;
            globalAdminID = adminID;
            globalPrevious = previous;
            InitializeComponent();
            FillDashboard();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void FillDashboard()
        {
            label1.Text = $"Restaurant ID: {globalRestaurantId.ToString()}";

            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [restaurant] WHERE id='{globalRestaurantId}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Restauranten");
            adapt.Fill(ds, "Restauranten");
            con.Close();

            DataTable tblRestauranten = ds.Tables["Restauranten"];

            if (tblRestauranten != null)
            {
                foreach (DataRow x in tblRestauranten.Rows)
                {
                    label3.Text = $"Huidige naam: {x["naam"].ToString()}";
                    
                }
            }
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

        private void checkDataChanged(int ID)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [restaurant] WHERE id='{ID}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Restauranten");
            adapt.Fill(ds, "Restauranten");
            con.Close();

            DataTable tblRestauranten = ds.Tables["Restauranten"];

            foreach (DataRow x in tblRestauranten.Rows)
            {
                if (textBox1.Text != "" && textBox1.Text != x["naam"].ToString())
                {
                    EditButton.Show();
                }
                else
                {
                    EditButton.Hide();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkDataChanged(globalRestaurantId);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OptionsHider();
        }

        private void OptionsHider()
        {
            panel2.Visible = !panel2.Visible;
            
            textBox1.Enabled = !textBox1.Enabled;
            goBackButton.Enabled = !goBackButton.Enabled;
            EditButton.Enabled = !EditButton.Enabled;
            DeleteButton.Enabled = !DeleteButton.Enabled;
        }

        private void panelNoButton_Click(object sender, EventArgs e)
        {
            OptionsHider();
        }

        private void panelYesButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand Command = new SqlCommand($"DELETE FROM [restaurant] WHERE Id='{globalRestaurantId}'", connection);
                connection.Open();

                // Execute de SQL UPDATE Request
                Command.ExecuteNonQuery();

                // Connectie met database beindigen
                connection.Close();
                MessageBox.Show("The Order Has Been Successfully Deleted");

                OptionsHider();

                GoBack();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                OptionsHider();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    SqlCommand Command = new SqlCommand($"UPDATE [restaurant] SET naam='{textBox1.Text}' WHERE id='{globalRestaurantId}'", connection);
                    connection.Open();

                    // Execute de SQL UPDATE Request
                    Command.ExecuteNonQuery();

                    // Connectie met database beindigen
                    connection.Close();

                    MessageBox.Show("Succesfully Edited The Restaurant Information!");
                    FillDashboard();
                    checkDataChanged(globalRestaurantId);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
