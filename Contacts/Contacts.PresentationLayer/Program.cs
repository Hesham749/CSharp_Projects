using Contacts.BusinessLayer;
using System;
using System.Data;
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
            TestExist(1);
            TestExist(10);
            Console.ReadKey();
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
            if (ClsContact.DeleteContact(ID))
                Console.WriteLine("contact Deleted successfully");
            else
                Console.WriteLine("Failed to delete  contact.");
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
