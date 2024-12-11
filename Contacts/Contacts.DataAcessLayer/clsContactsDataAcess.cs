using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Collections;
using System.Runtime.Remoting.Messaging;
namespace Contacts.DataAcessLayer
{
    public class clsContactsDataAcess
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
    }
}
