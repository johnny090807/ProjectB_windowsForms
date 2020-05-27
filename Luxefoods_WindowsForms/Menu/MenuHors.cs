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
    public partial class MenuHors : Form
    {
        public MenuHors()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ArrowLeft_Click(object sender, EventArgs e)
        {
            int change = SlideShowPanel.HorizontalScroll.Value - SlideShowPanel.HorizontalScroll.SmallChange * 80;
            SlideShowPanel.AutoScrollPosition = new Point(change, 0);
        }

        private void ArrowRight_Click(object sender, EventArgs e)
        {
            int change = SlideShowPanel.HorizontalScroll.Value + SlideShowPanel.HorizontalScroll.SmallChange * 80;
            SlideShowPanel.AutoScrollPosition = new Point(change, 0);
        }
    }
}
