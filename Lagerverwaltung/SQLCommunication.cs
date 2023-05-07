using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lagerverwaltung
{
    internal class SQLCommunication
    {
        //create SqlConnection and Sql Command
        static string connectionString = "server = (localdb)\\MSSQLLocalDB; integrated security = true; ";
        static SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(" ", con);
        

        #region CreateDatabase
        public void CreateDatabase()
        {
            string nameDB = "MayrhoferFeiner";

            //check if Database exists and if not create database and table 
            bool databaseExists = CheckDatabaseExists(connectionString, nameDB);

            if (databaseExists == false)
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "Create database " + nameDB;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.ConnectionString += "database = " + nameDB + "; ";
                    con.Open();
                    cmd.CommandText = "create Table login([name] nvarchar(50), [surname] nvarchar(50), [username] nvarchar(50), [password] nvarchar(50))";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "create Table products([product] nvarchar(50),[productID] integer, [quantity] integer, [info] nvarchar(50))";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "create Table suppliers([name] nvarchar(50),[id] integer primary key,[discountS] decimal, [discountR] decimal, [info] nvarchar(50), [price] decimal, [ust] integer, [productID] integer) ";
                    cmd.ExecuteNonQuery();


                    //insert
                    cmd.CommandText = "insert into suppliers(name, id, discountS, discountR, info, price, ust, productID) " +
                        "values ('D', 1, 2, 3, 'dfjdkj', 3, 3, 1);";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into login(name, surname, username, password) values ('admin', 'admin', 'admin', 'admin')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into products(product, productID, quantity, info) values " +
                        "('Pflanze',1, 20, 'Hallo Hallo')";
                    cmd.ExecuteNonQuery();
                    //cmd.CommandText = "update products set totalPrice=quantity*unitPrice;";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into products(product, buyer, quantity, supplier, discountS, discountR, unitPrice, totalPrice, UST) values ('Rasenmäher', 'Customer', 0 , 'lawnMowerGesbr' , '', '', 149.99 ," + unitPrice * quantity + ", 20)";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into products(product, buyer, quantity, supplier, discountS, discountR, unitPrice, totalPrice, UST) values ('Wandfarben', 'Customer', 0 , 'WondPainterAG' , '', '', 39.99 ," + unitPrice * quantity + ", 20)";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into products(product, buyer, quantity, supplier, discountS, discountR, unitPrice, totalPrice, UST) values ('SuperDuper Griller', 'Customer', 0 , 'explodingGmbH' , '', '', 329.99 ," + unitPrice * quantity + ", 20)";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into products(product, buyer, quantity, supplier, discountS, discountR, unitPrice, totalPrice, UST) values ('Spring Brunnen', 'Customer', 0 , 'wetOG' , '', '', 409.99 ," + unitPrice * quantity + ", 20)";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into products(product, buyer, quantity, supplier, discountS, discountR, unitPrice, totalPrice, UST) values ('Schaufel', 'Customer', 0 , 'Dirty Dore EG' , '', '', 49.99 ," + unitPrice * quantity + ", 20)";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into products(product, buyer, quantity, supplier, discountS, discountR, unitPrice, totalPrice, UST) values ('Nemo Fisch', 'Customer', 0 , 'sloppy GmbH' , '', '', 10.98 ," + unitPrice * quantity + ", 20)";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into products(product, buyer, quantity, supplier, discountS, discountR, unitPrice, totalPrice, UST) values ('Hamster', 'Customer', 0 , 'Cute-Slay-Smash OG' , '', '', 23.99 ," + unitPrice * quantity + ", 20)";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into products(product, buyer, quantity, supplier, discountS, discountR, unitPrice, totalPrice, UST) values ('Plüschtier Dino', 'Customer', 0 , 'IKEA' , '', '', 39.99 ," + unitPrice * quantity + ", 20)";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into products(product, buyer, quantity, supplier, discountS, discountR, unitPrice, totalPrice, UST) values ('Eis', 'Customer', 0 , 'IceIceBaby EG' , '', '', 3.99," + unitPrice * quantity + ", 20)";
                    //cmd.ExecuteNonQuery();



                    con.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (con.State != ConnectionState.Closed)
                        con.Close();
                }
            }
            else
            {

                con.ConnectionString += "database = " + nameDB + "; ";

            }

        }


        //checks if database exists
        public static bool CheckDatabaseExists(string connectionString, string databaseName)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand($"SELECT db_id('{databaseName}')", connection))
                {
                    connection.Open();
                    return (command.ExecuteScalar() != DBNull.Value);
                    //ExecuteScalar schaut ob erste Spalte - erste Zeile null ist

                }
            }
        }

        #endregion

        #region CheckLogin
        public bool CheckLogin(string username, string password)
        {
            bool correctLogin = false;

            try
            {
                con.Open();
                cmd.CommandText = "select * from login where username = '" + username + "' and password = '" + password + "';";
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    correctLogin = true;
                    reader.Close();
                }
                else
                {
                    correctLogin = false;
                    reader.Close();
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            
            con.Close();

            return correctLogin;
        }
        #endregion

        #region AddEmployee
        public void AddEmployee(string name, string surname, string username, string password)
        {
           //doesnt work :(
            //try
            //{
            //    con.Open();
            //    cmd.CommandText = "select * from login where username = '" + username + "' and password = '" + password + "';";
            //    cmd.ExecuteNonQuery();
                
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        MessageBox.Show("Benutzername existiert schon. Suchen Sie einen anderen aus: ");
            //    }
            //    else
            //    {
            //        cmd.CommandText = "insert into login (name, surname, username, password) values ('" + name +
            //          "', '" + surname + "','" + username + "' , '" + password + "');";
            //        cmd.ExecuteNonQuery(); 
            //    }
            //    reader.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.ToString());
            //    if (con.State != ConnectionState.Closed)
            //        con.Close();
            //}
            //con.Close();

            try
            {
                con.Open();
                cmd.CommandText = "select * from login where username = '" + username + "';";
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Benutzername existiert schon. Suchen Sie einen anderen aus: ");
                }
                else
                {
                    
                    cmd.CommandText = "insert into login (name, surname, username, password) values ('" + name +
                      "', '" + surname + "','" + username + "' , '" + password + "');";
                    cmd.ExecuteNonQuery();
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            con.Close();
        }

        #endregion

        #region DataOverview
        public DataTable DataOverview(DataGridView dataOverview)
        {
            DataTable dataTable = new DataTable();
            try
            {
                //put data from tables into DataGridView
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from products", con);

                adapter.Fill(dataTable);

                dataOverview.DataSource = dataTable;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dataTable;
        }
        #endregion

        #region LoadDGV
        public void Load(DataTable table)
        {
            SqlBulkCopy sql = new SqlBulkCopy(con);

            try
            {
                //delete from table so that we can insert all data at ones
                con.Open();
                cmd.CommandText = "delete from products";
                cmd.ExecuteNonQuery();

                //chooses in which table the data will be saved
                sql.DestinationTableName = "products";
                //it writes the data into dataTable 
                sql.WriteToServer(table);
                MessageBox.Show("Daten wurden gespeichert!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }

            }
        }
        #endregion

        #region ComboBoxProducts
        public void ComboBox(ComboBox cbB_product)
        {
            cbB_product.Items.Clear();
            try
                {
                
                    con.Open();
                    cmd.CommandText = "select * from products;";
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                
                int count = 1;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbB_product.Items.Add(reader.GetString(0));
                        //cbB_product = productsCB;
                        count++;
                    }
                    reader.Close();
                }

                    reader.Close();
                    con.Close();

                

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                    if (con.State != ConnectionState.Closed)
                        con.Close();
                }

        }
        #endregion

        #region existingData
        public int ExistingQuantity(string product)
        {
            int num = 0;
            try
            {
                con.Open();
                cmd.CommandText = "select quantity from products where product = '" + product +"';";
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        num = reader.GetInt32(0);
                    }
                }
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return num;
        }
        public string InfoProduct(string product)
        {
            string info = "";
            try
            {
                con.Open();
                cmd.CommandText = "select info from products where product = '" + product + "';";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        info = reader.GetString(0);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return info;
        }
        public string InfoSupplier(string supplier)
        {
            string info = "";
            try
            {
                con.Open();
                cmd.CommandText = "select info from suppliers where name = '" + supplier + "';";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        info = reader.GetString(0);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return info;
        }

        public int UST(string supplier)
        {
            int ust = 0;
            try
            {
                con.Open();
                cmd.CommandText = "select ust from suppliers where name = '" + supplier + "';";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ust = reader.GetInt32(0);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return ust;
        }

        public decimal DiscountSkonto(string supplier)
        {
            decimal discountS = 0;
            try
            {
                con.Open();
                cmd.CommandText = "select discountS from suppliers where name = '" + supplier + "';";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        discountS = reader.GetDecimal(0);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return discountS;
        }
        public decimal DiscountRabatt(string supplier)
        {
            decimal discountR = 0;
            try
            {
                con.Open();
                cmd.CommandText = "select discountR from suppliers where name = '" + supplier + "';";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        discountR = reader.GetDecimal(0);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return discountR;
        }
        public decimal OnePrice(string supplier)
        {
            decimal price = 0;
            try
            {
                con.Open();
                cmd.CommandText = "select price from suppliers where name = '" + supplier + "';";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        price = reader.GetDecimal(0);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return price;
        }



        #endregion

        #region AddNewProducts
        public void NewProducts(string productName, string productInfo, int productID)
        {
            try
            {
                con.Open();
                cmd.CommandText = "insert into products(product, productID, quantity, info) values ('" + productName
                    + "', " + productID + ", 5, '" + productInfo + "')";
                cmd.ExecuteNonQuery();
                con.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }
        #endregion

        #region LookIfProductsExist
        public List<int> LookForProducts()
        {
            List<int> productID = new List<int>();  
            try
            {
                con.Open();
                cmd.CommandText = "select productID from products;";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        productID.Add(reader.GetInt32(0));
                        
                    }
                    reader.Close();
                }

                reader.Close();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return productID;
        }
        #endregion

        #region ChoosenProduct
        public int ChoosenProduct(string selected)
        {
            int productID = 0;
            try
            {
                con.Open();
                cmd.CommandText = "select productID from products where product = '" + selected + "';";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        productID = reader.GetInt32(0);
                    }
                }
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return productID;
        }
        #endregion

        #region ComboBoxSupplier
        public void ComboBoxSupplier(string product, ComboBox existingSupplier)
        {
            existingSupplier.Items.Clear();
            int productID = 1;


            try {
                con.Open();
                cmd.CommandText = "select productID from products where product = '" + product +"';";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        productID = reader.GetInt32(0);
                    }
                    reader.Close();
                }

                reader.Close();


                cmd.CommandText = "select name, productID from suppliers;";
                SqlDataReader read = cmd.ExecuteReader();

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        if (productID.Equals(read.GetInt32(1)))
                        {
                            existingSupplier.Items.Add(read.GetString(0));
                        }
                    }
                }
                read.Close();
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }

        }
        #endregion

        #region AddSuppliers
        public void AddSuppliers(string supplierName, decimal discountS, decimal discountR, string info, decimal price, int ust, int productID)
        {
            try
            {
                con.Open();
                cmd.CommandText = "select max(id) from suppliers;";
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                int count2 = 1;
                int supplierCount = 0;
                if(!reader.HasRows)
                {
                    supplierCount = 1;
                }
                else if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       supplierCount = reader.GetInt32(0) + 1;
 
                    }
                    reader.Close();
                }

                
                
               
                cmd.CommandText = "insert into suppliers (name, id, discountS, discountR, info, price, ust, productID) " +
                    "values('" + supplierName + "'," + supplierCount + "," + discountS + "," + discountR + ",'" + info + "', " + price + ", " + ust + ", " + productID + ");";
                cmd.ExecuteNonQuery();

                reader.Close();
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }
        #endregion 
    }
}