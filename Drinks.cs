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
        public string SubType {  get { return d_SubType; } set { d_SubType = value; } }
        public string Brand { get { return d_Brand; } set { d_Brand = value; } }
        public string Flavour { get { return d_Flavour; } set { d_Flavour = value; } }

        public DataSet GetDrinks()
        {
            DataSet dsDrinks = new DataSet();

            string myCS = ConfigurationManager.ConnectionStrings["RisingSunConnectionString"].ConnectionString;

            SqlConnection myCon = new SqlConnection(myCS);
            myCon.Open();

            SqlCommand cmDrinks = new SqlCommand();
            cmDrinks.Connection = myCon;
            cmDrinks.CommandType = CommandType.Text;
            cmDrinks.CommandText = "SELECT * FROM Beverages";
            SqlDataAdapter daDrinks = new SqlDataAdapter(cmDrinks);

            daDrinks.Fill(dsDrinks);
            myCon.Close();
            return dsDrinks;

            //SqlCommand cmEmployer = new SqlCommand();
            //cmEmployer.Connection = myCon;
            //cmEmployer.CommandType = CommandType.Text;
            //cmEmployer.CommandText = "EXEC usp_AddEmployerSelect";
            //SqlDataAdapter daEmployer = new SqlDataAdapter(cmEmployer);

            //daEmployer.Fill(dsEmployer);
            //myCon.Close();
            //return dsEmployer;
        }
    }
}
