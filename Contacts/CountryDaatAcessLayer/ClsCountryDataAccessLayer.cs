using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
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

        public static bool UpdateCountry(stCountryData cData)
        {
            var conn = new SqlConnection(ClsConnectionSettings.ConnString);
            var query = @"update Countries set countryName = @Name where countryID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", cData.CountryName);
            cmd.Parameters.AddWithValue("@ID", cData.CountryID);
            int RowAffected = 0;
            try
            {
                conn.Open();
                RowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception x) { }
            finally { conn.Close(); }
            return RowAffected > 0;
        }

        public static bool DeleteCountry(int ID)
        {
            var conn = new SqlConnection(ClsConnectionSettings.ConnString);
            var query = @"delete Countries where countryID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            int RowAffected = 0;
            try
            {
                conn.Open();
                RowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception x) { }
            finally { conn.Close(); }
            return RowAffected > 0;
        }

        public static DataTable GetAllCountry()
        {
            DataTable dt = new DataTable();
            var conn = new SqlConnection(ClsConnectionSettings.ConnString);
            var query = @"select * from countries";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
            }
            catch (Exception x) { }
            finally { conn.Close(); }
            return dt;
        }

        public static bool IsCountryExist(int ID)
        {
            var conn = new SqlConnection(ClsConnectionSettings.ConnString);
            var query = @"select found = 1 from countries where countryID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conn.Open();
                if (cmd.ExecuteReader().HasRows)
                    return true;
            }
            catch (Exception x) { return false; }
            finally { conn.Close(); }
            return false;
        }
    }
}
