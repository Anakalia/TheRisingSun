using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRisingSun
{
    class Orders
    {
        private int o_OrderNumber;
        private int o_TableNumber;
        private string o_Drinks;
        private string o_Food;

        public int OrderNumber { get { return o_OrderNumber; } set { o_OrderNumber = value; } }
        public int TableNumber { get { return o_TableNumber; } set { o_TableNumber = value; } }
        public string Drinks { get { return o_Drinks; } set { o_Drinks = value; } }
        public string Food { get { return o_Food; } set { o_Food = value; } }
    }
}
