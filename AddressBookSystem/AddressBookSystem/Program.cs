using System;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Hello AddressBook System day23");

            AddressDetails Book = new AddressDetails();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Create Contact \n2.Add Contact \n3.Display Contact \n4.Edit Contact \n5.Delete Contact \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Book.CreateContact();
                        break;
                    case 2:
                        Book.AddContact();
                        break;
                    case 3:
                        Book.DisplayContact();
                        break;
                    case 4:
                        Book.EditContact();
                        break;
                    case 5:
                        Book.DeleteContact();
                        break;
                    case 22:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ! ");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
