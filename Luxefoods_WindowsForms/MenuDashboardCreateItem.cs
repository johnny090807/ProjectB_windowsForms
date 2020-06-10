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
    public partial class MenuDashboardCreateItem : Form
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
        public MenuDashboardCreateItem(int menuId, int adminID, string previous = "")
        {
            globalMenuId = menuId;
            globalAdminID = adminID;
            globalPrevious = previous;
            InitializeComponent();
            CenterToScreen();
        }

        // https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers?page=1&tab=votes#tab-top
        private void gerechtPrijsInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CreateItem_Click(object sender, EventArgs e)
        {
            if (gerechtNaamInput.Text != "" && gerechtPrijsInput.Text != "" && gerechtMelkSelector.SelectedItem != null && gerechtNotenSelector.SelectedItem != null && gerechtCategorieSelector.SelectedItem != null)
            {
                int prijsInt = 0;

                string prijsStr = string.Empty;

                for (int i = 0; i < gerechtPrijsInput.Text.Length; i++)
                {
                    if (Char.IsDigit(gerechtPrijsInput.Text[i]))
                    {
                        prijsStr += gerechtPrijsInput.Text[i];
                    }
                }

                prijsInt = Int32.Parse(prijsStr);

                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO [gerecht] (naam, prijs, melkalergieen, notenalergieen, categorie, menuId) VALUES  ('{gerechtNaamInput.Text}', '{prijsInt}', '{(string) gerechtMelkSelector.SelectedItem}', '{(string) gerechtNotenSelector.SelectedItem}', '{(string) gerechtCategorieSelector.SelectedItem}', '{globalMenuId}')", con);
                try
                {
                    // Execute een non query command in de database
                    command.ExecuteNonQuery();


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
            else if (gerechtNaamInput.Text == "")
            {
                MessageBox.Show("Missing a name");
            }
            else if (gerechtPrijsInput.Text == "")
            {
                MessageBox.Show("Missing a price");
            }
            else if (gerechtMelkSelector.SelectedItem == null)
            {
                MessageBox.Show("Select true or false melk");
            }
            else if (gerechtNotenSelector.SelectedItem == null)
            {
                MessageBox.Show("Select true or false nuts");
            }
            else if (gerechtCategorieSelector.SelectedItem == null)
            {
                MessageBox.Show("Select the category");
            }
            else
            {
                MessageBox.Show("If u see this message contact the support.");
            }
        } 

        private void goBackButton_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            if (globalPrevious == "menuDashboard")
            {
                this.Hide();
                MenuDashboard menuDashboard = new MenuDashboard(globalAdminID, "dashboard");
                menuDashboard.Show();
            }
        }

        private void SearchComboBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
