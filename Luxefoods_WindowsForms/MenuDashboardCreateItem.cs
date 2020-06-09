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
    public partial class MenuDashboardCreateItem : Form
    {
        public MenuDashboardCreateItem()
        {
            InitializeComponent();
            /// <summary>
            /// TODO
            /// Check if all values are selected
            /// if yes then create order and send back to the MenuDashboard
            /// add back button to send back to MenuDashboard aswell
            /// </summary>
        }

        private void checkDataChanged(int ID)
        {
            
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
            if (gerechtNaamInput.Text != "" && gerechtPrijsInput.Text != "" && gerechtMelkSelector.SelectedValue != null && gerechtNotenSelector.SelectedValue != null && gerechtCategorieSelector.SelectedValue != null)
            {

            }
        }
    }
}
