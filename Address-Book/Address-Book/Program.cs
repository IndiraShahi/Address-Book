using System;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book");
            // creating object
            AddressBook book = new AddressBook();

            // calls set accessor of the properties
            book.FirstName = "Indira";
            book.LastName = "Shahi";
            book.Address = "Rachenhalli";
            book.City = "Bengaluru";
            book.State = "Karnataka";
            book.Zip = 560077;
            book.PhoneNumber = 1234567890;
            book.Email = "indirashahi@gmail.com";

            // displaying values
            Console.WriteLine("First Name : " + book.FirstName);
            Console.WriteLine("Last Name : " + book.LastName);
            Console.WriteLine("Address : " + book.Address);
            Console.WriteLine("City : " + book.City);
            Console.WriteLine("State : " + book.State);
            Console.WriteLine("Zip : " + book.Zip);
            Console.WriteLine("Phone Number : " + book.PhoneNumber);
            Console.WriteLine("Email : " + book.Email);
        }
    }
}