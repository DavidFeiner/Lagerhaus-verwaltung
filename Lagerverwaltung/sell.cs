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
    public partial class sell : Form
    {
        public sell()
        {
            InitializeComponent();
            int Value = 5;
            LabelValue.Text = "Value: " + Value;
            decimal Money = 50000;
            LabelMoney.Text = "Money: " + Money + " Euro";
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
            this.Hide();
        }

        private void bttn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void ProduktCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelValue_Click(object sender, EventArgs e)
        {
            
            

        }

        private void LabelMoney_Click(object sender, EventArgs e)
        {
           
        }
    }
}
