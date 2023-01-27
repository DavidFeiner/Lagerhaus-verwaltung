using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            string databaseName = "MayrhoferFeiner";

            //check if Database exists and if not create database and table 
            bool databaseExists = CheckDatabaseExists(connectionString, databaseName);

            if (databaseExists == false)
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "Create database MayrhoferFeiner";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.ConnectionString += "database = MayrhoferFeiner;";
                    con.Open();
                    cmd.CommandText = "create Table loginValues([username] nvarchar(50), [password] nvarchar(50))";
                    cmd.ExecuteNonQuery();
                    con.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
    }
}
