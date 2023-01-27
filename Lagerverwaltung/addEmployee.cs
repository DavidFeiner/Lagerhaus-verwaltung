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
    public partial class addEmployee : Form
    {
        public addEmployee()
        {
            InitializeComponent();
        }

        

        private void bttn_back_Click_1(object sender, EventArgs e)
        {
            mainmenu mainmenu = new mainmenu();
            this.Hide();
            mainmenu.ShowDialog();
            //this.Hide();
        }
    }
}
