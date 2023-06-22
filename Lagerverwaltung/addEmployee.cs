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

        string name, surname, username, password, password2;

        private void addEmployee_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            int screen_height = screen.Bounds.Height;
            int screen_width = screen.Bounds.Width;

            this.Left = (screen_width - this.Width) / 2;
            this.Top = (screen_height - this.Height) / 2;
        }

     

        SQLCommunication sql = new SQLCommunication();
        public addEmployee()
        {
            InitializeComponent();
            
        }

        

        private void bttn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.ShowDialog();
        }

        private void bttn_save_Click(object sender, EventArgs e) //Get inputs
        {
            //create new Employess
            name = Convert.ToString(txtB_name.Text);
            surname = Convert.ToString(txtB_password.Text);
            username = Convert.ToString(txtB_username.Text);
            password = Convert.ToString(txtB_password.Text);
            password2 = Convert.ToString(txtB_password2.Text);
            


            if(password.Equals(password2)) //Make password for employees
            {
                sql.AddEmployee(name, surname, username, password);
                MessageBox.Show("Mitarbeiter wurde gespeichert!");
                MessageBox.Show("Daten lauten: \nName: " + name + "\nNachname: " + surname + "\nBenutzername: " + username + "\nPassword: " + password);
            }

            


        }
    }
}
