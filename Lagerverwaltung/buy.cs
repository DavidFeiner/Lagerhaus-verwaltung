﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    public partial class buy : Form
    {
        SQLCommunication cmc = new SQLCommunication();
        DataTable table;
        public buy()
        {
            InitializeComponent();
            DataTable dataTable = cmc.DataOverview(dgV_buy);
            this.table = dataTable;

            cmc.ComboBox(cbB_product);
        }

        
        private void bttn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.ShowDialog();
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            cmc.Load(table);
        }
    }
}
