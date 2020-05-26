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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

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
}
