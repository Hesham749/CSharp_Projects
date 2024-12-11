using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Contacts.DataAcessLayer;
namespace Contacts.BusinessLayer
{
    public class clsContact
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }



        public clsContact()
        {
        }

        public clsContact(int iD, string firstName, string lastName, string email, string phone, string address, DateTime dateOfBirth, int countryID, string imagePath)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            DateOfBirth = dateOfBirth;
            CountryID = countryID;
            ImagePath = imagePath;
        }

        public static clsContact Find(int ID)
        {
            clsContactsDataAcess.stContactData contactData = new clsContactsDataAcess.stContactData();
            contactData.ID = ID;
            if (clsContactsDataAcess.FindContactData(ref contactData))
            {
                return new clsContact(contactData.ID, contactData.FirstName, contactData.LastName, contactData.Email, contactData.Phone, contactData.Address, contactData.DateOfBirth, contactData.CountryID, contactData.ImagePath);
            }
            else
                return null;
        }
    }
}
