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
    public partial class MenuDashboardGerechtOverview : Form
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

        int globalMenuId;
        int globalAdminID;
        string globalPrevious;
        public MenuDashboardGerechtOverview(int menuId, int adminID, string previous = "")
        {
            globalMenuId = menuId;
            globalAdminID = adminID;
            globalPrevious = previous;
            InitializeComponent();
            CenterToScreen();
            FillDashboard();
            EditButton.Hide();
        }

        private void FillDashboard()
        {
            gerechtId.Text = $"Gerecht ID: {globalMenuId.ToString()}";

            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [gerecht] WHERE id='{globalMenuId}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Gerechten");
            adapt.Fill(ds, "Gerechten");
            con.Close();

            DataTable tblGerechten;
            tblGerechten = ds.Tables["Gerechten"];

            if (tblGerechten != null)
            {
                foreach (DataRow x in tblGerechten.Rows)
                {
                    gerechtNaam.Text = $"Huidige naam: {x["naam"].ToString()}";
                    gerechtPrijs.Text = $"Huidige Prijs: € {x["prijs"].ToString()}";
                    
                    gerechtMelk.Text = $"Heeft melk alergieen: {x["melkalergieen"].ToString()}";
                    gerechtMelkSelector.SelectedItem = x["melkalergieen"].ToString();
                    
                    gerechtNoten.Text = $"Heeft noten alergieen: {x["notenalergieen"].ToString()}";
                    gerechtNotenSelector.SelectedItem = x["notenalergieen"].ToString();

                    gerechtCategorie.Text = $"Huidige categorie: {x["categorie"].ToString()}";
                    gerechtCategorieSelector.SelectedItem = x["categorie"];
                }
            }
        }

        private void checkDataChanged(int ID)
        {
            SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand read = new SqlCommand($"SELECT * from [gerecht] WHERE id='{globalMenuId}'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(read);
            adapt.FillSchema(ds, SchemaType.Source, "Gerechten");
            adapt.Fill(ds, "Gerechten");
            con.Close();

            DataTable tblGerechten = ds.Tables["Gerechten"];

            int prijsInt = 0;
            if (gerechtPrijsInput.Text != "")
            {
                string prijsStr = string.Empty;

                for (int i = 0; i < gerechtPrijsInput.Text.Length; i++)
                {
                    if (Char.IsDigit(gerechtPrijsInput.Text[i]))
                    {
                        prijsStr += gerechtPrijsInput.Text[i];
                    }
                }

                prijsInt = Int32.Parse(prijsStr);
            }
            foreach (DataRow x in tblGerechten.Rows)
            {
                if ((gerechtNaamInput.Text != "" && x["naam"].ToString() != gerechtNaamInput.Text) || (gerechtPrijsInput.Text != "" && (int)x["prijs"] != prijsInt) || x["melkalergieen"].ToString() != (string)gerechtMelkSelector.SelectedItem || x["notenalergieen"].ToString() != (string)gerechtNotenSelector.SelectedItem || x["categorie"].ToString() != (string)gerechtCategorieSelector.SelectedItem)
                {
                    EditButton.Show();
                }
                else
                {
                    EditButton.Hide();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OptionsHider();
        }

        private void panelNoButton_Click(object sender, EventArgs e)
        {
            OptionsHider();
        }

        private void OptionsHider()
        {
            panel2.Visible = !panel2.Visible;

            gerechtNaamInput.Enabled = !gerechtNaamInput.Enabled;
            gerechtPrijsInput.Enabled = !gerechtPrijsInput.Enabled;
            gerechtMelkSelector.Enabled = !gerechtMelkSelector.Enabled;
            gerechtNotenSelector.Enabled = !gerechtNotenSelector.Enabled;
            gerechtCategorieSelector.Enabled = !gerechtCategorieSelector.Enabled;
            goBackButton.Enabled = !goBackButton.Enabled;
            EditButton.Enabled = !EditButton.Enabled;
            DeleteButton.Enabled = !DeleteButton.Enabled;
        }

        private void panelYesButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand Command = new SqlCommand($"DELETE FROM [gerecht] WHERE Id='{globalMenuId}'", connection);
                connection.Open();

                // Execute de SQL UPDATE Request
                Command.ExecuteNonQuery();

                // Connectie met database beindigen
                connection.Close();
                panel2.Visible = false;

                gerechtNaamInput.Enabled = !gerechtNaamInput.Enabled;
                gerechtPrijsInput.Enabled = !gerechtPrijsInput.Enabled;
                gerechtMelkSelector.Enabled = !gerechtMelkSelector.Enabled;
                gerechtNotenSelector.Enabled = !gerechtNotenSelector.Enabled;
                gerechtCategorieSelector.Enabled = !gerechtCategorieSelector.Enabled;
                EditButton.Enabled = !EditButton.Enabled;
                DeleteButton.Enabled = !DeleteButton.Enabled;
                goBackButton.Enabled = !goBackButton.Enabled;

                if (globalPrevious == "menuDashboard")
                {
                    this.Hide();
                    MenuDashboard menuDashboard = new MenuDashboard(globalAdminID, "dashboard");
                    menuDashboard.Show();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                OptionsHider();
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            if (globalPrevious == "menuDashboard")
            {
                this.Hide();
                MenuDashboard menuDashboard = new MenuDashboard(globalAdminID, "dashboard");
                menuDashboard.Show();
            }
        }

        // https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers?page=1&tab=votes#tab-top
        private void gerechtPrijsInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gerechtNaamInput_TextChanged(object sender, EventArgs e)
        {
            checkDataChanged(globalMenuId);
        }

        private void gerechtMelkSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataChanged(globalMenuId);
        }

        private void gerechtPrijsInput_TextChanged(object sender, EventArgs e)
        {
            checkDataChanged(globalMenuId);
        }

        private void gerechtNotenSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataChanged(globalMenuId);
        }

        private void gerechtCategorieSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataChanged(globalMenuId);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (gerechtMelkSelector.SelectedItem != null && gerechtNotenSelector.SelectedItem != null && gerechtMelkSelector != null)
            {
                try
                {
                    int prijsInt = 0;

                    if (gerechtNaamInput.Text != "" && gerechtPrijsInput.Text != "")
                    {

                        string prijsStr = string.Empty;

                        for (int i = 0; i < gerechtPrijsInput.Text.Length; i++)
                        {
                            if (Char.IsDigit(gerechtPrijsInput.Text[i]))
                            {
                                prijsStr += gerechtPrijsInput.Text[i];
                            }
                        }

                        prijsInt = Int32.Parse(prijsStr);

                        SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                        SqlCommand Command = new SqlCommand($"UPDATE [gerecht] SET naam='{gerechtNaamInput.Text}', prijs='{prijsInt}', melkalergieen='{gerechtMelkSelector.SelectedItem}', notenalergieen='{gerechtNotenSelector.SelectedItem}', categorie='{gerechtCategorieSelector.SelectedItem}' WHERE id='{globalMenuId}'", connection);
                        connection.Open();

                        // Execute de SQL UPDATE Request
                        Command.ExecuteNonQuery();

                        // Connectie met database beindigen
                        connection.Close();

                        FillDashboard();
                        checkDataChanged(globalMenuId);
                    }
                    else if (gerechtPrijsInput.Text == "" && gerechtNaamInput.Text != "")
                    {
                        SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                        SqlCommand Command = new SqlCommand($"UPDATE [gerecht] SET naam='{gerechtNaamInput.Text}', melkalergieen='{gerechtMelkSelector.SelectedItem}', notenalergieen='{gerechtNotenSelector.SelectedItem}', categorie='{gerechtCategorieSelector.SelectedItem}' WHERE id='{globalMenuId}'", connection);
                        connection.Open();

                        // Execute de SQL UPDATE Request
                        Command.ExecuteNonQuery();

                        // Connectie met database beindigen
                        connection.Close();

                        FillDashboard();
                        checkDataChanged(globalMenuId);
                    }
                    else if (gerechtNaamInput.Text == "" && gerechtPrijsInput.Text != "")
                    {
                        string prijsStr = string.Empty;

                        for (int i = 0; i < gerechtPrijsInput.Text.Length; i++)
                        {
                            if (Char.IsDigit(gerechtPrijsInput.Text[i]))
                            {
                                prijsStr += gerechtPrijsInput.Text[i];
                            }
                        }

                        prijsInt = Int32.Parse(prijsStr);

                        SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                        SqlCommand Command = new SqlCommand($"UPDATE [gerecht] SET prijs='{prijsInt}', melkalergieen='{gerechtMelkSelector.SelectedItem}', notenalergieen='{gerechtNotenSelector.SelectedItem}', categorie='{gerechtCategorieSelector.SelectedItem}' WHERE id='{globalMenuId}'", connection);
                        connection.Open();

                        // Execute de SQL UPDATE Request
                        Command.ExecuteNonQuery();

                        // Connectie met database beindigen
                        connection.Close();

                        FillDashboard();
                        checkDataChanged(globalMenuId);
                    } else
                    {
                        SqlConnection connection = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                        SqlCommand Command = new SqlCommand($"UPDATE [gerecht] SET melkalergieen='{gerechtMelkSelector.SelectedItem}', notenalergieen='{gerechtNotenSelector.SelectedItem}', categorie='{gerechtCategorieSelector.SelectedItem}' WHERE id='{globalMenuId}'", connection);
                        connection.Open();

                        // Execute de SQL UPDATE Request
                        Command.ExecuteNonQuery();

                        // Connectie met database beindigen
                        connection.Close();

                        FillDashboard();
                        checkDataChanged(globalMenuId);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("Contact support incase u see this error");
            }
        }
    }
}
