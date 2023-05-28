using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string State { get; set; }
        public string email { get; set; }
        public int Zip { get; set; }
        public int phone { get; set; }
    }

    public class AddressBook
    {
        public void Contact()
        {
            List<Contact> contactList = new List<Contact>();
            contactList.Add(new Contact
            {
                Name = "Sudhir",
                Address = "India",
                city = "Muzaffarpur",
                State = "Bihar",
                email = "sudhir@gmail.com",
                Zip = 12345,
                phone = 987654321
            });

            contactList.Add(new Contact
            {
                Name = "Kashayp",
                Address = "india",
                city = "Patna",
                State = "Bihar",
                email = "kashyap@gmail.com",
                Zip = 876543,
                phone = 1225461458
            });
            contactList.Add(new Contact
            {
                Name = "Raja",
                Address = "india",
                city = "bengaluru",
                State = "krnatka",
                email = "Raja@gmail.com",
                Zip = 765432,
                phone = 1226187458
            });

            contactList.Add(new Contact
            {
                Name = "Abhishek",
                Address = "india",
                city = "mumbai",
                State = "Maharashtra",
                email = "abhishek@gmail.com",
                Zip = 654321,
                phone = 12261568
            });
            foreach (var contacts in contactList)
            {
                Console.WriteLine(contacts.Name);
                Console.WriteLine(contacts.Address);
                Console.WriteLine(contacts.city);
                Console.WriteLine(contacts.State);
                Console.WriteLine(contacts.email);
                Console.WriteLine(contacts.Zip);
                Console.WriteLine(contacts.phone);
                Console.WriteLine("-------------------------------");
            }

            Console.WriteLine("********---------------********");

            //public void NewContactAdd()
            //{
            //    Contact NewContact = new Contact();

            //    Console.WriteLine("Enter Your Name");
            //    NewContact.Name = Console.ReadLine();
            //    Console.WriteLine("Enter Your Address");
            //    NewContact.Address = Console.ReadLine();
            //    Console.WriteLine("Enter Your City");
            //    NewContact.city = Console.ReadLine();
            //    Console.WriteLine("Enter Your State");
            //    NewContact.State = Console.ReadLine();
            //    Console.WriteLine("Enter Your Email");
            //    NewContact.email = Console.ReadLine();
            //    Console.WriteLine("Enter Your Zip");
            //    NewContact.Zip = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter Your Phone Number");
            //    NewContact.phone = Convert.ToInt32(Console.ReadLine());



            //}

            //public void Edit()
            {
                Console.WriteLine("Enter The Name to Edit The Contact");
                string Name = Console.ReadLine();


                foreach (var contactItems in contactList)
                {
                    if (contactItems.Name == Name)
                    {


                        // Taking Input by User Which Field want to Edit 
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Address");
                        Console.WriteLine("3. City");
                        Console.WriteLine("4. state");
                        Console.WriteLine("5. Email Address");
                        Console.WriteLine("6. Zip Code ");
                        Console.WriteLine("7. Phone Number ");

                        Console.WriteLine("Enter the Field number you Want to Edit ");
                        int Choice = Convert.ToInt32(Console.ReadLine());

                        // using Switch to Edit The Field Choose By User
                        switch (Choice)
                        {
                            case 1:
                                Console.Write("Enter the New First Name : ");
                                string New_Name = Console.ReadLine();
                                contactItems.Name = New_Name;
                                break;

                            case 2:
                                Console.Write("New Address : ");
                                string New_Address = Console.ReadLine();
                                contactItems.Address = New_Address;
                                break;
                            case 3:
                                Console.Write("New City : ");
                                string New_City = Console.ReadLine();
                                contactItems.city = New_City;
                                break;
                            case 4:
                                Console.Write("New State : ");
                                string New_State = Console.ReadLine();
                                contactItems.State = New_State;
                                break;
                            case 5:
                                Console.Write("New Email Address : ");
                                string New_Email_Address = Console.ReadLine();
                                contactItems.email = New_Email_Address;
                                break;
                            case 6:
                                Console.Write("New Zip Code : ");
                                int New_Zip_Code = Convert.ToInt32(Console.ReadLine());
                                contactItems.Zip = New_Zip_Code;
                                break;
                            case 7:
                                Console.Write("New Phone Number : ");
                                int New_Phone_Number = Convert.ToInt32(Console.ReadLine());
                                contactItems.phone = New_Phone_Number;
                                break;

                            default:
                                Console.WriteLine(" Please Enter Correct Choice Number");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine(" Your Input Didn't Match the List of Contacts");
                    }
                }

                foreach (var NewContactItems in contactList)
                {
                    Console.WriteLine(NewContactItems.Name);
                    Console.WriteLine(NewContactItems.Address);
                    Console.WriteLine(NewContactItems.city);
                    Console.WriteLine(NewContactItems.State);
                    Console.WriteLine(NewContactItems.email);
                    Console.WriteLine(NewContactItems.Zip);
                    Console.WriteLine(NewContactItems.phone);
                    Console.WriteLine("*******************************************************************");

                }
            }

        }


    }
}
