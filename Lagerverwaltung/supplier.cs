using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lagerverwaltung
{
    public partial class supplier : Form
    {
        string supplierName;
        decimal discountS;
        decimal discountR;
        string info;
        decimal price;
        int ust;
     
        SQLCommunication sql = new SQLCommunication();
        string selected;
        public supplier(string selected)
        {
            InitializeComponent();
            this.selected= selected;
        }

        private void bttn_save_Click(object sender, EventArgs e) //get all inputs from suppliers
        {
            int productID = sql.ChoosenProduct(selected);
            supplierName = Convert.ToString(txtB_supplier.Text);
            discountS = Convert.ToDecimal(txtB_discountS.Text);
            discountR = Convert.ToDecimal(txtB_discountR.Text);
            info = Convert.ToString(txtB_info.Text);
            price = Convert.ToDecimal(txtB_priceOne.Text);
            ust = Convert.ToInt32(txtB_ust.Text);

            sql.AddSuppliers(supplierName, discountS, discountR, info, price, ust, productID);
            this.Close();

        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            int screen_height = screen.Bounds.Height;
            int screen_width = screen.Bounds.Width;

            this.Left = (screen_width - this.Width) / 2;
            this.Top = (screen_height - this.Height) / 2;
        }
    }
}
