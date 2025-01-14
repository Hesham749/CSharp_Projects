using Contacts.BusinessLayer;
using System;
namespace Contacts.PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TestFindContact(2);
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
