﻿using System;
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
    public partial class mainmenu : Form
    {
        SQLCommunication sql = new SQLCommunication();
        string username;
        bool admin;
        public mainmenu()
        {
            InitializeComponent();
            CheckIfAdmin();
        }
        public void GiveName(string username)
        {
            //take the name of the user who logged in 
            this.username = username;
        }
        public void CheckIfAdmin()
        {
            //check if logged person is admin
            admin =  sql.CheckAdmin(this.username);
            if(!admin)
            {
                bttn_employee.Hide();
            }
            
            
        }

        private void bttn_signOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login signOut = new login();
            signOut.Show();
            
            
        }

        private void bttn_storage_Click(object sender, EventArgs e)
        {

            storage storage = new storage();
            this.Hide();
            storage.ShowDialog();
        }

        private void bttn_sales_Click(object sender, EventArgs e)
        {
            sales sales = new sales();
            this.Hide();
            sales.ShowDialog();
        }

        private void bttn_buy_Click(object sender, EventArgs e)
        {
            buy buy = new buy();
            this.Hide();
            buy.ShowDialog();
        }

        private void bttn_sell_Click(object sender, EventArgs e)
        {
            sell sell= new sell();
            this.Hide();
            sell.ShowDialog();
        }

        private void bttn_employee_Click(object sender, EventArgs e)
        {
            addEmployee employee = new addEmployee();
            this.Hide();
          
            employee.ShowDialog();
            
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            int screen_height = screen.Bounds.Height;
            int screen_width = screen.Bounds.Width;

            this.Left = (screen_width - this.Width) / 2;
            this.Top = (screen_height - this.Height) / 2;
        }
    }
}
