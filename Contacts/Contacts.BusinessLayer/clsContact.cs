using Contacts.DataAccessLayer;
using System;
using System.Data;
namespace Contacts.BusinessLayer
{
    public class ClsContact
    {
        public enum enMode
        {
            Update = 1,
            AddNew
        }

        public int ID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }
        public enMode Mode { get; private set; }



        public ClsContact()
        {
            ID = -1;
            Mode = enMode.AddNew;
        }

        private ClsContact(int iD, string firstName, string lastName, string email, string phone, string address, DateTime dateOfBirth, int countryID, string imagePath)
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
            Mode = enMode.Update;
        }

        public static ClsContact Find(int ID)
        {
            ClsContactsDataAccess.stContactData contactData = new ClsContactsDataAccess.stContactData
            {
                ID = ID
            };
            if (ClsContactsDataAccess.GetContactInfoByID(ref contactData))
            {
                return new ClsContact(contactData.ID, contactData.FirstName, contactData.LastName, contactData.Email, contactData.Phone, contactData.Address, contactData.DateOfBirth, contactData.CountryID, contactData.ImagePath);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    Mode = enMode.Update;
                    return (_AddNewContact()) ? true : false;
                case enMode.Update:
                    return (_UpdateContact()) ? true : false;
            }
            return false;
        }

        private bool _UpdateContact()
        {
            return ClsContactsDataAccess.UpdateContact(ID, FirstName, LastName, Email, CountryID, Address, DateOfBirth, ImagePath, Phone);
        }

        private bool _AddNewContact()
        {
            ID = ClsContactsDataAccess.AddNewContact(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath);
            return ID != -1;
        }

        public static bool DeleteContact(int ID)
        {
            return ClsContactsDataAccess.DeleteContact(ID);

        }

        public static DataTable GetAllContacts()
        {
            return ClsContactsDataAccess.GetALLContacts();
        }

        public static bool IsContactExist(int ID)
        {
            return ClsContactsDataAccess.IsContactExist(ID);
        }
    }
}
