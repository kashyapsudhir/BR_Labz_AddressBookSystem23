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
        }
        public void NewContactAdd()
        {
            Contact NewContact = new Contact();

            Console.WriteLine("Enter Your Name");
            NewContact.Name = Console.ReadLine();
            Console.WriteLine("Enter Your Address");
            NewContact.Address = Console.ReadLine();
            Console.WriteLine("Enter Your City");
            NewContact.city = Console.ReadLine();
            Console.WriteLine("Enter Your State");
            NewContact.State = Console.ReadLine();
            Console.WriteLine("Enter Your Email");
            NewContact.email = Console.ReadLine();
            Console.WriteLine("Enter Your Zip");
            NewContact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Phone Number");
            NewContact.phone = Convert.ToInt32(Console.ReadLine());



        }


    }

}
