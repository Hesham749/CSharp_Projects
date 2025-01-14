using System;
using System.Data.SqlClient;
namespace Contacts.DataAccessLayer
{
    public class ClsContactsDataAccess
    {
        public struct stContactData
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string ImagePath { get; set; }
            public int CountryID { get; set; }
        }
        public static bool GetContactInfoByID(ref stContactData contactData)
        {
            bool found = false;
            SqlConnection conn = new SqlConnection(clsConnectionSettings.connString);
            string query = @"select * from Contacts 
        where ContactID = @contacts ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@contacts", contactData.ID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    found = true;
                    contactData.FirstName = reader.GetString(1).ToString();
                    contactData.LastName = reader.GetString(2).ToString();
                    contactData.Email = reader.GetString(3).ToString();
                    contactData.Phone = reader.GetString(4).ToString();
                    contactData.Address = reader.GetString(5).ToString();
                    contactData.DateOfBirth = reader.GetDateTime(6);
                    contactData.CountryID = reader.GetInt32(7);
                    contactData.ImagePath = reader.GetValue(8).ToString();

                }
                reader.Close();
            }
            catch
            {

                found = false;
            }
            finally
            {
                conn.Close();
            }
            return found;
        }

        public static int AddNewContact(string firstName, string lastName, string email, string phone, string address, DateTime dateOfBirth, int countryID, string imagePath)
        {
            int contactId = -1;
            SqlConnection conn = new SqlConnection(clsConnectionSettings.connString);
            var query = @"insert into contacts (firstName, lastName, email,Phone,Address,DateOfBirth,CountryId,imagePath)
                        values(@firstName,@lastName,@email,@phone,@address,@dateOfBirth,@countryId,@imagePath);
                         select scope_identity();";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@countryId", countryID);
            if (string.IsNullOrEmpty(imagePath))
                cmd.Parameters.AddWithValue("@imagePath", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@imagePath", imagePath);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedId))
                    contactId = (insertedId > 0) ? insertedId : -1;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return contactId;
        }

        public static bool UpdateContact(int iD, string firstName, string lastName, string email, int countryID, string address, DateTime dateOfBirth, string imagePath, string phone)
        {
            SqlConnection conn = new SqlConnection(clsConnectionSettings.connString);
            string query = @"update contacts 
                            set firstName = @firstName ,
                            lastName = @lastName,
                            Email = @email,
                            Phone = @phone,
                            Address= @address,
                            CountryId = @countryID,
                            imagePath = @imagePath
                            where contactId = @iD";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@countryID", countryID);
            cmd.Parameters.AddWithValue("@iD", iD);
            if (imagePath != null)
                cmd.Parameters.AddWithValue("@imagePath", imagePath);
            else
                cmd.Parameters.AddWithValue("imagePath", DBNull.Value);
            int rowAffected = 0;
            try
            {
                conn.Open();
                rowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { conn.Close(); }
            return rowAffected > 0;
        }

        public static bool DeleteContact(int ID)
        {
            SqlConnection conn = new SqlConnection(clsConnectionSettings.connString);
            var query = @" delete contacts 
                            where contactID = @ID";
            int rowAffected = 0;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
                rowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { conn.Close(); }
            return rowAffected > 0;
        }
    }
}
