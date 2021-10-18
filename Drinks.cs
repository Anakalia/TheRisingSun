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
    class Drinks
    {
        private int d_ID;
        private string d_Type;
        private string d_SubType;
        private string d_Brand;
        private string d_Flavour;

        public int id { get { return d_ID; } set { d_ID = value; } }
        public string Type { get { return d_Type; } set { d_Type = value; } }
        public string SubType { get { return d_SubType; } set { d_SubType = value; } }
        public string Brand { get { return d_Brand; } set { d_Brand = value; } }
        public string Flavour { get { return d_Flavour; } set { d_Flavour = value; } }


        public DataSet GetAllDrinks()
        {
            DataSet dsDrinks = new DataSet();

            string myCS = ConfigurationManager.ConnectionStrings["RisingSunConnectionString"].ConnectionString;

            SqlConnection myCon = new SqlConnection(myCS);
            myCon.Open();

            SqlCommand cmDrinks = new SqlCommand();
            cmDrinks.Connection = myCon;
            cmDrinks.CommandType = CommandType.Text;
            cmDrinks.CommandText = "SELECT * FROM beverages";
            SqlDataAdapter daDrinks = new SqlDataAdapter(cmDrinks);

            daDrinks.Fill(dsDrinks);
            myCon.Close();
            return dsDrinks;

        }

        public DataSet FilteredDrinks(DataSet dsDrinks, string type)
        {
            dsDrinks.Tables[0].DefaultView.RowFilter = "Type = '" + type + "'";
            return dsDrinks;
        }

        public DataSet GetDrinks(string type)
        {
            DataSet dsDrinks = new DataSet();

            string myCS = ConfigurationManager.ConnectionStrings["RisingSunConnectionString"].ConnectionString;

            SqlConnection myCon = new SqlConnection(myCS);
            myCon.Open();

            SqlCommand cmDrinks = new SqlCommand();
            cmDrinks.Connection = myCon;
            cmDrinks.CommandType = CommandType.Text;
            cmDrinks.CommandText = "SELECT * FROM beverages WHERE Type = '" + type + "'";
            SqlDataAdapter daDrinks = new SqlDataAdapter(cmDrinks);

            daDrinks.Fill(dsDrinks);
            myCon.Close();
            return dsDrinks;
        }
    }
}
