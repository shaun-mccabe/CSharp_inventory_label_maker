using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IT_Assets
{
    internal class item
    {
        public string str_type, str_name, str_serial, str_model, str_description, str_photo_path, str_company_tracking_number;

        public item(string type, string name, string serial, string model, string description, string company_tracking_number)
        {
            str_type = type;
            str_name = name;
            str_serial = serial;
            str_model = model;
            str_description = description;
         // _str_photo_path = photo_path;
            str_company_tracking_number = company_tracking_number;

        }

        public bool save_item()
        {
            

          
            return true;
        }


        public void print_item_label()
        {
            Console.WriteLine("test");
        }

        
        
        
    }
}
