using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Deployment.Internal;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace IT_Assets
{
    internal class item_model:data

    {
        public item_model():base()//calling the base constructor to have access to connection string
        {
            //any further intialization goes here. This class will be used for CRUD function for the ITEM class
        }




        public long insert(item newItem)
        {
            long insertedId = -1; // Initialize with a default value indicating failure

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    
                    string insertNewRecord = @"INSERT INTO items(company_tracking_number, name, type, serial, model, description, photo) 
                                       VALUES (@trackingNumber, @name,@type, @serial, @model, @description, @photo);
                                       SELECT last_insert_rowid();";
                
                    

                    using (SQLiteCommand command = new SQLiteCommand(insertNewRecord, conn))
                    {
                        command.Parameters.AddWithValue("@trackingNumber", newItem.str_company_tracking_number);
                        command.Parameters.AddWithValue("@name", newItem.str_name);
                        command.Parameters.AddWithValue("@type", newItem.str_type);
                        command.Parameters.AddWithValue("@serial", newItem.str_serial);
                        command.Parameters.AddWithValue("@model", newItem.str_model);
                        command.Parameters.AddWithValue("@description", newItem.str_description);
                        command.Parameters.AddWithValue("@photo", newItem.str_photo_path);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            insertedId = Convert.ToInt64(result);
                            Console.WriteLine(insertedId);  
                        }
                        else
                        {
                            throw new Exception("No ID returned after insert.");
                        }

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Table");
            }


            return insertedId;
        }
        public int update() { return 0; }

        public int delete() { return 0; }
       public int delete_item(int id) {

            int rows;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string deleteRecord = @"DELETE FROM items WHERE id = @id;";



                    using (SQLiteCommand command = new SQLiteCommand(deleteRecord, conn))
                    {
                        command.Parameters.AddWithValue("@id", id); // Use parameterized query

                        object result = command.ExecuteNonQuery();
                        if (result != null && result != DBNull.Value)
                        {
                            rows = (int)Convert.ToInt64(result);
                            Console.WriteLine(rows);
                            conn.Close();
                            return rows;
                            
                        }
                        else
                        {
                            throw new Exception("No ID returned after insert.");
                        }

                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Table");
            }


            return 0; 
        
        }
        public int update_item() { return 0; }


        public item selectAnItem(int id)
        {
            item newItem = null;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string selectRecord = "SELECT id, company_tracking_number, name, type, serial, model, description, photo FROM items WHERE id = @id";

                    using (SQLiteCommand command = new SQLiteCommand(selectRecord, conn))
                    {
                        command.Parameters.AddWithValue("@id", id); // Use parameterized query

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Handle DBNull values if any field can be NULL
                                string type = reader.IsDBNull(3) ? null : reader.GetString(3);
                                string name = reader.IsDBNull(2) ? null : reader.GetString(2);
                                string serial = reader.IsDBNull(4) ? null : reader.GetString(4);
                                string model = reader.IsDBNull(5) ? null : reader.GetString(5);
                                string description = reader.IsDBNull(6) ? null : reader.GetString(6);
                                string photoPath = reader.IsDBNull(7) ? null : reader.GetString(7);
                                string companyTrackingNumber = reader.IsDBNull(1) ? null : reader.GetString(1);
                                int itemId = reader.GetInt32(0);

                                // Create the new item object
                                newItem = new item(type, name, serial, model, description, photoPath, companyTrackingNumber, itemId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving item: {ex.Message}");
                // Consider logging the exception details for further analysis
            }

            return newItem;
        }


        public List<item> Select()
{
            List<item> itemList = new List<item>();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string getAllRecords = @"SELECT id,company_tracking_number, name, type, serial, model, description, photo FROM items ORDER BY id DESC";

                    using (SQLiteCommand command = new SQLiteCommand(getAllRecords, conn))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())

                        {

                          
                            // Assuming your 'item' class has appropriate constructor to initialize properties.
                            item newItem = new item(

                                reader.GetString(3),    //type
                                reader.GetString(2),    //name
                                reader.GetString(4),    //serial
                                reader.GetString(5),    //model
                                reader.GetString(6),    //description
                                reader.GetString(7),    //photo_path
                                reader.GetString(1),    //company tracking number
                                reader.GetInt32(0)      //id
                                  );

                            itemList.Add(newItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error retrieving records");
            }

            return itemList;
        }

    }
}
