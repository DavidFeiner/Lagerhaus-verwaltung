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
    public partial class buy : Form
    {
        SQLCommunication cmc = new SQLCommunication();
        public buy()
        {
            InitializeComponent();
            DataTable dataTable = cmc.DataOverview(dgV_buy);
        }

        
        private void bttn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.ShowDialog();
        }
    }
}
