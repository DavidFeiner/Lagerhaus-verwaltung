using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lagerverwaltung
{
    public partial class buy : Form
    {
        SQLCommunication cmc = new SQLCommunication();
        DataTable table;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public buy()
        {
            InitializeComponent();
            DataTable dataTable = cmc.DataOverview(dgV_buy);
            this.table = dataTable;

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
        //public void cbB_product_Load(object sender, EventArgs e )
        //{

        //    cn = new SqlConnection("server = (localdb)\\MSSQLLocalDB; integrated security = true; server = MayrhoferFeiner;");
        //    cn.Open();

        //    BindData();
        //}
        //public void BindData()
        //{
        //    cmd = new SqlCommand("select product from products", cn);
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        cbB_product.Items.Add(dr[0].ToString());
        //    }
        //    dr.Close();
        //}

        //private void cbB_product_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cn = new SqlConnection("server = (localdb)\\MSSQLLocalDB; integrated security = true; server = MayrhoferFeiner;");
        //    cn.Open();

        //    BindData();
        //}
    }
       
           
    
}
