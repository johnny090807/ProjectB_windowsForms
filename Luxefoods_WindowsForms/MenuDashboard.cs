using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxefoods_WindowsForms
{
    public partial class MenuDashboard : Form
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
        public MenuDashboard(int adminID, string previous = "")
        {
            globalPrevious = previous;
            globalAdminID = adminID;
            InitializeComponent();
            CenterToScreen();
            fillListBox();
            fillMenuItemsListBox(1);
            editMenuButton.Hide();
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

        private void fillMenuItemsListBox(int restaurantId)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT menuId from [restaurant] WHERE id='{restaurantId}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Restaurant");
            adapt.Fill(ds, "Restaurant");
            con.Close();

            DataTable tblRestaurant = ds.Tables["Restaurant"];
            DataRow[] rowRestaurant = tblRestaurant.Select();
            string menuID = rowRestaurant[0].ItemArray[0].ToString();

            con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            read = new SqlCommand($"SELECT * from [gerecht] WHERE menuId='{menuID}'", con);
            adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Gerechten");
            adapt.Fill(ds, "Gerechten");
            con.Close();

            DataTable tblGerechten;
            tblGerechten = ds.Tables["Gerechten"];

            menuItemsList.Items.Clear();

            if (tblGerechten != null)
            {
                DataSet ds2 = new DataSet();
                foreach (DataRow x in tblGerechten.Rows)
                {
                    string gerechtId = x["id"].ToString();
                    string gerechtNaam = x["naam"].ToString();
                    string gerechtPrijs = x["prijs"].ToString();
                    string gerechtMelkalergieen = x["melkalergieen"].ToString();
                    string gerechtNotenalergieen = x["notenalergieen"].ToString();
                    string gerechtCategorie = x["categorie"].ToString();
                    menuItemsList.Items.Add("Gerecht ID: " + gerechtId + "   Naam: " + gerechtNaam + "   Prijs: " + gerechtPrijs + "    Heeft Melk Alergieen? " + gerechtMelkalergieen + "   Heeft Noten Alergieen? " + gerechtNotenalergieen + "   Categorie" + gerechtCategorie);
                }
            }
        }

        private void EditMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                string strSource = menuItemsList.SelectedItem.ToString();
                string strStart = "Gerecht ID:";
                string strEnd = "Naam:";
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
                    MenuDashboardGerechtOverview menuDashboardGerechtOverview = new MenuDashboardGerechtOverview(intId, globalAdminID, "menuDashboard");
                    menuDashboardGerechtOverview.Show();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void restaurantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dashboardRefresher();
        }

        private void dashboardRefresher()
        {
            fillMenuItemsListBox((int)restaurantListBox.SelectedValue);
        }

        private void menuItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuItemsList.SelectedItem != null)
            {
                editMenuButton.Show();
            }
            else
            {
                editMenuButton.Hide();
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

        private void createNewItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDashboardCreateItem menuDashboardCreateItem = new MenuDashboardCreateItem((int) restaurantListBox.SelectedValue, globalAdminID, "menuDashboard");
            menuDashboardCreateItem.Show();
        }
    }
}
