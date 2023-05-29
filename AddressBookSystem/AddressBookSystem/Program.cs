using System;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Hello AddressBook System day23");

            while (true)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Edit members Contacts list\n4.Delete members Contacts list\n5.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        AddressDetails.AddMember();
                        break;
                    case 2:
                        AddressDetails.ViewContacts();
                        break;
                    case 3:
                        AddressDetails.EditDetails();
                        break;
                    case 4:
                        AddressDetails.DeleteDetails();
                        break;
                    case 5:
                                                   // to exit from main method
                        Console.WriteLine("Exit");
                        return;

                }
            }



        }
    }
}
