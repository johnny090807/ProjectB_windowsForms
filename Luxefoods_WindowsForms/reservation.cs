using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxefoods_WindowsForms
{
    public partial class reservation : Form
    {
        public reservation()
        {
            InitializeComponent();
            CenterToScreen();
        }

<<<<<<< HEAD
        private void AvailabilityTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register form1 = new Register();
            form1.Show();
            this.Hide();
        }
    }
=======
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
            }

>>>>>>> 49ebca64aa05286d51b4bfd46225fd20d1003680

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
}
