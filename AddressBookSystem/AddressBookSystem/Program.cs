using System;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Hello AddressBook System day23");

            AddressBook addressBook = new AddressBook();
            addressBook.Contact();
        }
    }
}
