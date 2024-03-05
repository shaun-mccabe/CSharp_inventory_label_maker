using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
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
        public int delete_item() { return 0; }
        public int update_item() { return 0; }

        public List<item> select()
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
