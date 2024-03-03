using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IT_Assets
{
    internal class item_model:data

    {
        public item_model():base()//calling the base constructor to have access to connection string
        {
            //any further intialization goes here. This class will be used for CRUD function for the ITEM class
        }




        public int insert()
        {

            return 0;
        }
        public int update() { return 0; }

        public int delete() { return 0; }
        public int delete_item() { return 0; }
        public int update_item() { return 0; }

        public List<item> select(int id)
        {
            return new List<item>();
        }


    }
}
