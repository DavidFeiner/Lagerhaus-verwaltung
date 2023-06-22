using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Lagerverwaltung
{
    public partial class RegisterAdmin : Form
    {
        SQLCommunication sql = new SQLCommunication();
        public RegisterAdmin()
        {
            InitializeComponent();
        }

        private void RegisterAdmin_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            int screen_height = screen.Bounds.Height;
            int screen_width = screen.Bounds.Width;

            this.Left = (screen_width - this.Width) / 2;
            this.Top = (screen_height - this.Height) / 2;
        }
       

        private void bttn_accept_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(txtB_name.Text);
            string surname = Convert.ToString(txtB_surname.Text);
            string username = Convert.ToString(txtB_username.Text);
            string password = Convert.ToString(txtB_password.Text)
;           string password2 = Convert.ToString(txtB_password2.Text);

            //create Admin who can then create other employee accounts
            if(password.Equals(password2))
            {
                sql.AddEmployee(name, surname, username, password);
                MessageBox.Show("Der Admin-Benutzer wurde erstellt.");
                login goLogin = new login();
                this.Hide();
                goLogin.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Die zwei Passwörter stimmen nicht überein.");
            }
            
        }

        private void bttn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
