using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace IT_Assets
{
    internal class item
    {
        public string  str_type, str_name, str_serial, str_model, str_description, str_photo_path, str_company_tracking_number;
        public int int_Id;
        public item(
            string type,
            string name,
            string serial, 
            string model,
            string description,
            string photo_path, 
            string company_tracking_number,
            int id = 0)
        {
            int_Id = id;
            str_type = type;
            str_name = name;
            str_serial = serial;
            str_model = model;
            str_description = description;
            str_photo_path = photo_path;
            str_company_tracking_number = company_tracking_number;

        }


        public void PrintProperties()
        {
            Type type = typeof(item);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(this);
                Console.WriteLine($"{property.Name}: {value}");
            }
        }


    }
    
}
