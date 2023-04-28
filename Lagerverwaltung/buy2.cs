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
    public partial class buy2 : Form
    {

        SQLCommunication sql = new SQLCommunication();
        public buy2()
        {
            InitializeComponent();

            AddComboBox();
            
        }
        public void AddComboBox()
        {
            sql.ComboBox(cB_existingProduct);
            sql.ComboBoxSupplier(cB_existingSupplier);
;        }

        private void bttn_newSupplier_Click(object sender, EventArgs e)
        {
            supplier goToSupplier = new supplier();
            this.Close();
            goToSupplier.ShowDialog();
            this.Show();

        }
    }
}
