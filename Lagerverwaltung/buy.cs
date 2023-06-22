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
    public partial class buy : Form
    {

        SQLCommunication sql = new SQLCommunication();
        mainmenu menu = new mainmenu();
        decimal discountS, discountR, price;
        int buyQuantity;
        public buy()
        {
            InitializeComponent();

            AddComboBox();
            
        }
        public void AddComboBox()
        {
            sql.ComboBox(cB_existingProduct);
            
            
;        }

        private void bttn_newSupplier_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cB_existingProduct.Text))
            {
                MessageBox.Show("Produkt muss erst ausgewählt werden!");
            }
            else
            {
                //look which product user picked and give it to supplier Forms
                string selected = cB_existingProduct.GetItemText(cB_existingProduct.SelectedItem);
                this.Hide();
                supplier goToSupplier = new supplier(selected);
                goToSupplier.ShowDialog();
                sql.ComboBoxSupplier(selected, cB_existingSupplier);
                this.Show();
               
            }
        }

     

        private void bttn_newProduct_Click(object sender, EventArgs e)
        {
            NewProducts newP = new NewProducts();
            this.Hide();
            newP.ShowDialog();
            this.Show();

        }

        private void cB_existingProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string product = cB_existingProduct.SelectedItem.ToString();
            int quantity = sql.ExistingQuantity(product);
            lbl_existingQuantity.Text = "vorhandene Menge: " + quantity;

            sql.ComboBoxSupplier(product, cB_existingSupplier);

        }

        private void bttn_allCosts_Click(object sender, EventArgs e) //Total
        {
            buyQuantity = Convert.ToInt32(txtB_buyQuantity.Text);
            decimal cost = price * buyQuantity;
            decimal costR = 0;
            decimal costS = 0;

            if(!discountR.Equals(0))
            {
                costR = (cost *discountR) / 100;
            }
            else if(!discountS.Equals(0))
            {
                costS = (costR *discountS) / 100;
            }

            decimal allCosts = cost - costR - costS;
            txtB_totalCost.Text = Convert.ToString( allCosts + " €");

        }

        private void bttn_buy_Click(object sender, EventArgs e) //Buying from suplier
        {
            string product = cB_existingProduct.SelectedItem.ToString();
            int option = 2;
            sql.UpdateProductQuantity(buyQuantity, product, option);
            
            MessageBox.Show("Der Kauf wurde getätigt.");
            sales ShowSale = new sales();
            ShowSale.showSales();
            this.Hide();
            menu.ShowDialog();
            this.Close();
            
        }

        private void bttn_moreInfoP_Click(object sender, EventArgs e)
        {
                string product = cB_existingProduct.SelectedItem.ToString();
            string infoProduct = sql.InfoProduct(product);
            MessageBox.Show(infoProduct);
        }

        private void bttn_moreInfoS_Click(object sender, EventArgs e)
        {
            string supplier = cB_existingSupplier.SelectedItem.ToString();
            string infoSupplier = sql.InfoSupplier(supplier);
            MessageBox.Show(infoSupplier);
        }

        private void buy_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            int screen_height = screen.Bounds.Height;
            int screen_width = screen.Bounds.Width;

            this.Left = (screen_width - this.Width) / 2;
            this.Top = (screen_height - this.Height) / 2;
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            menu.ShowDialog();
        }

        private void cB_existingSupplier_SelectedIndexChanged(object sender, EventArgs e) //Already existing data of suppliers
        {
            string supplier = cB_existingSupplier.SelectedItem.ToString();
            buyQuantity = sql.UST(supplier);
            lbl_ust.Text = "UST: " + buyQuantity + "%";

            discountS = sql.DiscountSkonto(supplier);
            txtB_discountS.Text ="" +  discountS + " % Skonto";

            discountR = sql.DiscountRabatt(supplier);
            txtB_discountR.Text = "" + discountR + "% Rabatt";

            price = sql.OnePrice(supplier);
            txtB_priceOne.Text = "" + price + " €";
        }
    }
}
