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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            SQLCommunication sql = new SQLCommunication();
            sql.CreateDatabase();
        }

       

        private void bttn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bttn_accept_Click(object sender, EventArgs e)
        {
            mainmenu mainmenu = new mainmenu();
            this.Hide();
            mainmenu.ShowDialog();
           
            
        }
    }
}
