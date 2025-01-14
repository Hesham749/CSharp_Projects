using Contacts.BusinessLayer;
using System;
namespace Contacts.PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TestFindContact(2);
            TestAddNewContact();
            Console.ReadKey();
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
    }
}
