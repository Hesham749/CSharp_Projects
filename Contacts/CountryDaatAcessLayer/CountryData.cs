using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace Country.DataAccessLayer
{
    public class CountryData
    {
        public struct stCountryData
        {
            public int CountryID { get; set; }
            public string CountryName { get; set; }
            public string Code { get; set; }
        }

        public static bool Find(int ID, ref stCountryData countryData)
        {
            bool found = false;
            countryData = new stCountryData();
            SqlConnection conn = new SqlConnection(ClsConnectionSettings.connString);
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
                    countryData.Code = reader.IsDBNull(2) ? null : reader.GetString(2);
                    reader.Close();
                }
            }
            catch
            {
                found = false;
            }
            finally { conn.Close(); }
            return found;
        }

        public static bool Find(string Name, ref stCountryData countryData)
        {
            bool found = false;
            countryData = new stCountryData();
            SqlConnection conn = new SqlConnection(ClsConnectionSettings.connString);
            var query = @"select * from countries where CountryName = @Name";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    found = true;
                    reader.Read();
                    countryData.CountryID = reader.GetInt32(0);
                    countryData.CountryName = Name;
                    countryData.Code = reader.IsDBNull(2) ? null : reader.GetString(2);
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
            var conn = new SqlConnection(ClsConnectionSettings.connString);
            var query = @"insert into countries(CountryName)
                          values(@countryName,@Code);
                        select  scope_identity();";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@countryName", CData.CountryName);
            cmd.Parameters.AddWithValue("@Code", CData.Code);
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
            var conn = new SqlConnection(ClsConnectionSettings.connString);
            var query = @"update Countries set countryName = @Name , Code = @Code   where countryID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", cData.CountryName);
            cmd.Parameters.AddWithValue("@ID", cData.CountryID);
            cmd.Parameters.AddWithValue("@Code", cData.Code);
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
            var conn = new SqlConnection(ClsConnectionSettings.connString);
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
            var conn = new SqlConnection(ClsConnectionSettings.connString);
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
            var conn = new SqlConnection(ClsConnectionSettings.connString);
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

        public static bool IsCountryExist(string Name)
        {
            var conn = new SqlConnection(ClsConnectionSettings.connString);
            var query = @"select found = 1 from countries where countryName = @Name";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);
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
