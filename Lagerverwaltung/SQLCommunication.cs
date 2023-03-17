﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    internal class SQLCommunication
    {
        //create SqlConnection and Sql Command
        static string connectionString = "server = (localdb)\\MSSQLLocalDB; integrated security = true; ";
        static SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(" ", con);

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
                    cmd.CommandText = "insert into login(name, surname, username, password) values ('admin', 'admin', 'admin', 'admin')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "create Table products([product] nvarchar(50),[buyer] nvarchar(50), [quantity] integer, [supplier] nvarchar(50),  [discountS] decimal, [discountR] decimal, [unitPrice] decimal, [price] decimal, [totalPrice] decimal, [UST] decimal )";
                    cmd.ExecuteNonQuery();
                    

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

        public bool CheckLogin(string username, string password)
        {
            bool correctLogin = false;

            try
            {
                con.Open();
                cmd.CommandText = "select * from login where username = '" + username + "' and password = '" + password + "'";
               // cmd.CommandText = "select * from login where username = '" + username + "' and password = '" + password + "';";
                //cmd.CommandText = "select * from login where username = 'admin' and password = 'admin';";
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    correctLogin = true;
                    reader.Close();
                    con.Close();

                }
                else
                {
                    correctLogin = false;
                }
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }

            return correctLogin;
        }

        public void AddEmployee(string name, string surname, string username, string password)
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from login where username = 'admin' and password = 'admin'; ";
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Benutzername existiert schon. Suchen Sie einen anderen aus: ");
                    reader.Close();
                    con.Close();

                }
                else
                {
                    cmd.CommandText = "instert into login (name, surname, username, password) values ('" + name +
                      "', '" + surname + "','" + username + "' , '" + password + "');";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                con.Close();
                reader.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }

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
    }
}
