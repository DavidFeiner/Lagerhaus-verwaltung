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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void bttn_signOut_Click(object sender, EventArgs e)
        {
            login signOut = new login();
            signOut.Show();
            this.Hide();
            
        }

        private void bttn_storage_Click(object sender, EventArgs e)
        {

            storage storage = new storage();
            this.Hide();
            storage.ShowDialog();
            this.Show();
        }

        private void bttn_sales_Click(object sender, EventArgs e)
        {
            sales sales = new sales();
            this.Hide();
            sales.ShowDialog();
            this.Show();
        }

        private void bttn_buy_Click(object sender, EventArgs e)
        {
            buy buy = new buy();
            this.Hide();
            buy.ShowDialog();
            this.Show();
        }

        private void bttn_sell_Click(object sender, EventArgs e)
        {
            sell sell= new sell();
            this.Hide();
            sell.ShowDialog();
            this.Show();
        }

        private void bttn_employee_Click(object sender, EventArgs e)
        {
            addEmployee employee = new addEmployee();
            this.Hide();
            employee.ShowDialog();
            this.Show();
            
        }
    }
}
