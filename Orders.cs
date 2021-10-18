using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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

        
        //check for open orders on selected table
        public DataSet checkOrders()
        {
            DataSet dsOrders = new DataSet();
            string myCS = ConfigurationManager.ConnectionStrings["RisingSunConnectionString"].ConnectionString;

            SqlConnection myCon = new SqlConnection(myCS);
            myCon.Open();

            SqlCommand cmOrders = new SqlCommand();
            cmOrders.Connection = myCon;
            cmOrders.CommandType = CommandType.Text;
            cmOrders.CommandText = "SELECT * FROM Orders WHERE Date = todaysDate AND table_no = '" + TableNumber + "' AND Paid = 'null'";
            SqlDataAdapter daDrinks = new SqlDataAdapter(cmOrders);

            daDrinks.Fill(dsOrders);
            myCon.Close();
            return dsOrders;
        }
    }
}
