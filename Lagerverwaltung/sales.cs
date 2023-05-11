using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.ShowDialog();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            int screen_height = screen.Bounds.Height;
            int screen_width = screen.Bounds.Width;

            this.Left = (screen_width - this.Width) / 2;
            this.Top = (screen_height - this.Height) / 2;
        }
    }
}
