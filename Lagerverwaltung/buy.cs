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
    public partial class buy : Form
    {
        public buy()
        {
            InitializeComponent();
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            mainmenu  mainmenu= new mainmenu();
            mainmenu.Show();
            this.Hide();
        }
    }
}
