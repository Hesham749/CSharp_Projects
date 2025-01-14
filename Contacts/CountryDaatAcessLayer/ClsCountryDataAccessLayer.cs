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

        public static bool FindByID(int ID, ref stCountryData countryData)
        {
            bool found = false;
            countryData = new stCountryData();
            SqlConnection conn = new SqlConnection(ClsConnectionSettings.ConnString);
            var query = @"select * from countries where CountryID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    found = true;
                    reader.Read();
                    countryData.CountryID = ID;
                    countryData.CountryName = reader.GetString(1);
                    reader.Close();
                }
            }
            catch
            {
            }
            finally { conn.Close(); }
            return found;
        }

        public static bool AddCountry(stCountryData CData)
        {
            var conn = new SqlConnection(ClsConnectionSettings.ConnString);
            var query = @"insert into countries(CountryName)
                          values(@countryName);
                        select  scope_identity();";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@countryName", CData.CountryName);
            try
            {
                conn.Open();
                CData.CountryID = (int.TryParse(cmd.ExecuteScalar().ToString(), out int insertedID)) ? insertedID : -1;
            }
            catch (Exception x) { Console.WriteLine(x.Message); }
            finally { conn.Close(); }
            return CData.CountryID != -1;
        }
    }
}
