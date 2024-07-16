using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Linq.Expressions;
using System.Threading;

namespace IT_Assets
{
    internal class data

    {
        protected string connectionString;
        
        public data() {
            connectionString = ConfigurationManager.ConnectionStrings["ItemConnection"].ConnectionString;
            
            status = getStatus();
            buildTables();
        }

        public bool status { get; private set; }





        private bool getStatus()
        {
            if (connectionString != null)

            {
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                using (conn)
                {
                    try
                    {
                        // Open the connection
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Connection Eror");
                        return false;
                    }
                    finally
                    {
                        conn.Close();

                    }

                    return true;
                }
            
            }else {
                MessageBox.Show(connectionString);
                return false; }

           
        }

        private void buildTables()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                string createTableSql = @"CREATE TABLE IF NOT EXISTS items(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                company_tracking_number TEXT NULL,
                name TEXT NULL,
                type TEXT NULL,
                serial TEXT NULL,
                model TEXT NULL,
                description TEXT NULL,
                photo TEXT NULL
                )";
                using (SQLiteCommand command = new SQLiteCommand(createTableSql, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Creating Table");
            }
           
        }

        public bool TrackingExists(string tracking)
        {
           try
            {
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                string q = $"SELECT COUNT(*) FROM items WHERE company_tracking_number={tracking}";
               
                using (SQLiteCommand command = new SQLiteCommand(q, conn))
                {
                    object count = command.ExecuteScalar();
                    if(count !=null && count != DBNull.Value)
                    {
                       
                        if ( Convert.ToInt64(count) >= 1)
                        {
                          
                            return true;
                        }
                    }
                }
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error Locating Tracking");
            }


            return false;
        }

    }

    
}
