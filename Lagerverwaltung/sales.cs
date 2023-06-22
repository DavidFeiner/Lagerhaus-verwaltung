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

        internal void showSales()
        {
            
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.ShowDialog();
        }



        private void sales_Load(object sender, EventArgs e)
        {
            SQLCommunication sqlCommunication = new SQLCommunication();

            decimal revenue = sqlCommunication.GetTotalRevenue();
            decimal expenses = sqlCommunication.GetTotalExpenses();

            textBoxSales.Text = revenue.ToString();
            textBoxExpencis.Text = expenses.ToString();

            decimal profit = revenue - expenses;
            txtBoxProfit.Text = profit.ToString();
            this.Refresh();
        }

    }
}
