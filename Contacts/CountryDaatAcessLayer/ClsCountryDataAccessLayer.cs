using System;
using System.Data;
using System.Data.SqlClient;
namespace Country.DataAccessLayer
{
    public class ClsCountryDataAccessLayer
    {
        public struct stCountryData
        {
            public int CountryID { get; set; }
            public string CountryName { get; set; }
        }

        public static stCountryData FindByID(int ID)
        {
            SqlConnection conn = new SqlConnection(ClsConnectionSettings.ConnString);
            var query = @"select * from countries where CountryID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);

        }






    }
}
