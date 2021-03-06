﻿using System;
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
    public partial class RestaurantenDashboard : Form
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

        string globalPrevious;
        int globalAdminID;
        public RestaurantenDashboard(int adminID, string previous = "")
        {
            globalPrevious = previous;
            globalAdminID = adminID;
            InitializeComponent();
            CenterToScreen();
            fillListBox();
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

        private void goBackButton_Click(object sender, EventArgs e)
        {
            if (globalPrevious == "dashboard")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard(globalAdminID);
                dashboard.Show();
            }
        }

        private void editMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestaurantenDashboardReview restaurantenDashboardReview = new RestaurantenDashboardReview((int)restaurantListBox.SelectedValue, globalAdminID, "restaurantDashboard");
            restaurantenDashboardReview.Show(); 
        }

        private void createNewItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestaurantDashboardCreate restaurantDashboardCreate = new RestaurantDashboardCreate(globalAdminID, "restaurantDashboard");
            restaurantDashboardCreate.Show();
        }

        private void restaurantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (restaurantListBox.SelectedItem != null)
            {
                editMenuButton.Show();
            }
            else
            {
                editMenuButton.Hide();
            }
        }
    }
}
