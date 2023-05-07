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
    public partial class NewProducts : Form
    {
        SQLCommunication sql = new SQLCommunication();
        string productName, productInfo;
        int productID = 0;
        List<int> existingP = new List<int>();
        buy menu = new buy();

        public NewProducts()
        {
            InitializeComponent();
        }

        private void bttn_exit_Click(object sender, EventArgs e)
        {
            
            this.Close();


        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            existingP = sql.LookForProducts();
            productID = existingP.Count + 1;
            productName = txtB_newProduct.Text;
            productInfo = txtB_infos.Text;
            sql.NewProducts(productName, productInfo, productID);
            menu.AddComboBox();
            MessageBox.Show("Neues Produkt wurde gespeichert!");

            this.Close();
            menu.ShowDialog();

        }
    }
}
