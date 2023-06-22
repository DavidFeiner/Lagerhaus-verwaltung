using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    public partial class sell : Form
    {
        SQLCommunication sql = new SQLCommunication();
        string name, info;
        decimal discountS, discountR, onePrice, cost;
        int amount;

        private void cB_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtB_ust.Text = 20 + "%";
            string product = cB_product.SelectedItem.ToString();
            decimal onePrice = sql.productSell(product);
           
            txtB_onePrice.Text = onePrice.ToString();
            this.onePrice= onePrice;

            int quantity = sql.ExistingQuantity(product);
            lbl_stock.Text = "vorh. Menge: " + quantity;
        }

        private void bttn_sum_Click(object sender, EventArgs e)
        {
            try 
            { 

                name = Convert.ToString(txtB_buyer.Text);
                discountS = Convert.ToDecimal(txtB_discountS.Text);
                discountR = Convert.ToDecimal(txtB_discountR.Text);
                
                info = Convert.ToString(txtB_infos.Text);
                amount = Convert.ToInt32(txtB_amount.Text);
            
                decimal sellQuantity = Convert.ToDecimal(txtB_amount.Text);
                cost = onePrice * sellQuantity;
                decimal costR = 0;
                decimal costS = 0;

                if (!discountR.Equals(0))
                {
                    costR = (cost * discountR) / 100;
                    cost = cost - costR;
                }
                else if (!discountS.Equals(0))
                {
                    costS = (cost * discountS) / 100;
                    cost = cost - costS;
                }
                decimal totalCost = ((cost) * 120) / 100;
                txtB_allCost.Text = Convert.ToString(totalCost + " €");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Bitte geben Sie einen Wert für Skonto und Rabatt ein.");
            }
            
        }

        private void sell_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            int screen_height = screen.Bounds.Height;
            int screen_width = screen.Bounds.Width;

            this.Left = (screen_width - this.Width) / 2;
            this.Top = (screen_height - this.Height) / 2;
        }

        public sell()
        {
            InitializeComponent();
            Product();
        }

        public void Product()
        {
            sql.ComboBox(cB_product);
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            mainmenu menu = new mainmenu();
            menu.ShowDialog();
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            int stock = sql.LookForQuantity();
            if(stock < amount)
            {
               MessageBox.Show("Zur Zeit ist nicht so eine hohe Menge im Lager. Lagerbestand beträgt: " + stock + " Stück.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtB_buyer.Text) || string.IsNullOrEmpty(txtB_amount.Text))
                {
                    MessageBox.Show("Käufer oder Anzahl müssen noch angegeben werden!");
                }
                else
                {
                    int option = 1;
                    sql.InsertBuyers(name, onePrice, discountS, discountR, info, cost, amount);
                    sql.UpdateProductQuantity(amount, name, option);
                    MessageBox.Show("Produkt wurde verkauft.");
                }
            }
           
            
            
        }
    }
}
