using StudioManager;
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
           
        }

       

        private void bttn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void login_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            int screen_height = screen.Bounds.Height;
            int screen_width = screen.Bounds.Width;

            this.Left = (screen_width - this.Width) / 2;
            this.Top = (screen_height - this.Height) / 2;
        }

        private void bttn_accept_Click(object sender, EventArgs e)
        {
            //username = Convert.ToString(txtB_username.Text);
            //password = Convert.ToString(txtB_password.Text);
            //bool correct =  sql.CheckLogin(username, password);

            //if(correct)
            //{
            //    mainmenu mainmenu = new mainmenu();
            //    this.Hide();
            //    mainmenu.ShowDialog();
            //}
            //else
            //{
            //    //MessageBox.Show("Username or Password are false!");
            //    txtB_username.Clear();
            //    txtB_password.Clear();
            //    txtB_username.Focus();
            //    mainmenu mainmenu = new mainmenu();
            //    this.Hide();
            //    mainmenu.ShowDialog();

            //}

           
            username = Convert.ToString(txtB_username.Text);
            password = Convert.ToString(txtB_password.Text);


            string salt = sql.GetSaltForUser(username);

            if (salt == null)
            {
                salt = BCrypt.GenerateSalt();
                sql.SaveSaltForUser(username, salt);
            }


            string hashedPassword = BCrypt.HashPassword(password, salt);


            bool correct = sql.CheckLogin(username, hashedPassword);

            if (correct)
            {

                mainmenu mainmenu = new mainmenu();
                this.Hide();
                mainmenu.ShowDialog();
            }
            else
            {

                MessageBox.Show("Username or Password are false!");
                txtB_username.Clear();
                txtB_password.Clear();
                txtB_username.Focus();
            }


        }
    }
}
