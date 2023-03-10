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

        SQLCommunication sql = new SQLCommunication();
        string username, password;
        public login()
        {
            InitializeComponent();
            sql.CreateDatabase();
            username = Convert.ToString(txtB_username.Text);
            password = Convert.ToString(txtB_password.Text);
        }

       

        private void bttn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bttn_accept_Click(object sender, EventArgs e)
        {
            bool correct =  sql.CheckLogin(username, password);

            if(correct)
            {
                mainmenu mainmenu = new mainmenu();
                this.Hide();
                mainmenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or Password are false!");

                mainmenu mainmenu = new mainmenu();
                this.Hide();
                mainmenu.ShowDialog();
            }
            
           
            
        }
    }
}
