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
        public static bool FindContactData(ref stContactData contactData)
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
            cmd.Parameters.AddWithValue("@imagePath", ((imagePath != "") ? imagePath : null));

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedId))
                    contactId = (insertedId > 0) ? insertedId : -1;
            }
            finally
            {
                conn.Close();
            }
            return contactId;
        }
    }
}
