using Contacts.BusinessLayer;
using Country.BusinessLayer;
using System;
using System.Data;
using System.Diagnostics.Contracts;
namespace Contacts.PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TestFindContact(2);
            //TestAddNewContact();
            //TestUpdateContact(14);
            //TestDeleteContact(14);
            //TestListContacts();
            //TestExist(1);
            //TestExist(10);

            //TestFindCountry(1);
            //Test2FindCountry("Germany");
            //TestAddNewCountry();
            //TestUpdateCountry(6);
            //TestDeleteCountry(6);
            //TestListCountry();1
            //TestCountryExist(10);
            //TestCountryExist(1);
            Test2CountryExist("egypt");
            Test2CountryExist("Germany");

            Console.ReadKey();
        }

        private static void Test2CountryExist(string Name)
        {
            if (Country.BusinessLayer.ClsCountry.IsCountryExist(Name))
                Console.WriteLine("Country exist");
            else Console.WriteLine("Country not exist");
        }

        private static void Test2FindCountry(string Name)
        {
            Country.BusinessLayer.ClsCountry c1 = Country.BusinessLayer.ClsCountry.Find(Name);
            if (c1 != null)
            {
                Console.WriteLine($"{c1.CountryID}, {c1.CountryName}");
            }
            else Console.WriteLine("Country not found");
        }

        private static void TestCountryExist(int ID)
        {
            if (Country.BusinessLayer.ClsCountry.IsCountryExist(ID))
                Console.WriteLine("Country exist");
            else Console.WriteLine("Country not exist");
        }

        private static void TestListCountry()
        {
            DataTable dt = Country.BusinessLayer.ClsCountry.GetAllCountry();
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row[0]}, {row[1]}");
            }
        }

        private static void TestDeleteCountry(int ID)
        {
            //if (ClsContact.IsContactExist(ID))
            //{
            if (Country.BusinessLayer.ClsCountry.DeleteCountry(ID))
                Console.WriteLine("Country Deleted successfully");
            else
                Console.WriteLine("Failed to delete  Country.");
            //}
            //else
            //    Console.WriteLine("Country not found");
        }

        private static void TestUpdateCountry(int ID)
        {
            var c1 = Country.BusinessLayer.ClsCountry.Find(ID);

            if (c1 != null)
            {
                c1.CountryName = "Swede";
                if (c1.Save())
                    Console.WriteLine("Country updated successfully");
                else
                    Console.WriteLine("Country didn't update");
            }
            else
            {
                Console.WriteLine($"Country with {ID} not found");
            };
        }

        private static void TestAddNewCountry()
        {
            var c1 = new Country.BusinessLayer.ClsCountry() { CountryName = "Egypt" };
            if (c1.Save())
                Console.WriteLine("saved successfully");
            else
                Console.WriteLine("doesn't save");
        }

        private static void TestFindCountry(int ID)
        {
            Country.BusinessLayer.ClsCountry c1 = Country.BusinessLayer.ClsCountry.Find(ID);
            if (c1 != null)
            {
                Console.WriteLine($"{c1.CountryID}, {c1.CountryName}");
            }
            else Console.WriteLine("Country not found");
        }

        private static void TestExist(int ID)
        {
            if (ClsContact.IsContactExist(ID))
                Console.WriteLine("user exist");
            else Console.WriteLine("user not exist");
        }

        private static void TestListContacts()
        {
            DataTable dt = ClsContact.GetAllContacts();
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row[0]}, {row["firstName"]}, {row["lastName"]}");
            }
        }

        private static void TestDeleteContact(int ID)
        {
            if (ClsContact.IsContactExist(ID))
            {
                if (ClsContact.DeleteContact(ID))
                    Console.WriteLine("contact Deleted successfully");
                else
                    Console.WriteLine("Failed to delete  contact.");
            }
            else
                Console.WriteLine("Contact not found");
        }

        private static void TestAddNewContact()
        {
            ClsContact contact1 = new ClsContact()
            {
                FirstName = "Foo",
                LastName = "Bar",
                Address = "any address",
                ImagePath = "",
                Phone = "010123244",
                CountryID = 3,
                Email = "@mail.com",
                DateOfBirth = new DateTime(1994, 07, 20)
            };
            if (contact1.Save())
                Console.WriteLine("saved successfully");
            else
                Console.WriteLine("doesn't save");

        }

        public static void TestFindContact(int ID)
        {
            ClsContact contact = ClsContact.Find(ID);

            if (contact != null)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName}");
                Console.WriteLine(contact.Email);
                Console.WriteLine(contact.Phone);
                Console.WriteLine(contact.Address);
                Console.WriteLine(contact.DateOfBirth);
                Console.WriteLine(contact.CountryID);
                Console.WriteLine(contact.ImagePath);
            }
            else
            {
                Console.WriteLine($"contact with {ID} not found");
            }

        }

        public static void TestUpdateContact(int ID)
        {
            ClsContact contact = ClsContact.Find(ID);

            if (contact != null)
            {
                contact.FirstName = "sayed";
                contact.LastName = "Ali";
                contact.Email = "@23mail.com";
                contact.Phone = "242354235";
                contact.Address = "new address";
                contact.DateOfBirth = new DateTime(2000, 10, 12);
                contact.CountryID = 1;
                contact.ImagePath = "";
                if (contact.Save())
                    Console.WriteLine("contact updated successfully");
                else
                    Console.WriteLine("contact didn't update");
            }
            else
            {
                Console.WriteLine($"contact with {ID} not found");
            }


        }
    }
}
