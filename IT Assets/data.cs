using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using IT_Assets.AssetsDataSetTableAdapters;
using System.Data;


namespace IT_Assets
{
    internal class data
    {
        private item obj_item;

        public void Set(item items)
        {
            this.obj_item = items;
            push_to_db(items);

        }


        private string get_connection_string()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["IT_Assets.Properties.Settings.AssetsConnectionString"].ConnectionString;

        }


        private bool push_to_db(item item_object)
        {
            Console.WriteLine("Made it to push");
            Console.Write(item_object.str_company_tracking_number);


            using (SqlConnection conn = new SqlConnection(get_connection_string()))
            {
                AssetsDataSet ds = new AssetsDataSet();
                asset_items_TableAdapter adapter = new asset_items_TableAdapter();
                adapter.Fill(ds.asset_items);

                try
                {
                    conn.Open();
                    Console.Write("connection open");
                    adapter.InsertItem(item_object.str_type, item_object.str_name, obj_item.str_serial, obj_item.str_model, obj_item.str_description, obj_item.str_company_tracking_number);
                    adapter.Update(ds.asset_items);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());

                }
                finally
                {
                    conn.Close();
                    Console.Write("connection closed");
                }

            }
            return false;
        }
    }
}
