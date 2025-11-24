using System;
using System.Collections.Generic;

namespace ConsoleAppContactsManager
{
    internal class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }

    internal static class ContactMenu
    {
        private static readonly List<Contact> contacts = new();

        public static void Show()
        {
            for (; ; )
            {
                Console.WriteLine();
                Console.WriteLine("Contacts Manager App");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    AddContact();
                }
                else if (input == "2")
                {
                    ViewContacts();
                }
                else if (input == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }
            }
        }

        private static void AddContact()
        {
            Console.Write("Enter name: ");
            var name = Console.ReadLine();
            Console.Write("Enter phone number: ");
            var phone = Console.ReadLine();
            Console.Write("Enter address: ");
            var address = Console.ReadLine();

            contacts.Add(new Contact
            {
                Name = name,
                PhoneNumber = phone,
                Address = address
            });

            Console.WriteLine("Contact added successfully.");
        }

        private static void ViewContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            Console.WriteLine("Contacts List:");
            for (int i = 0; i < contacts.Count; i++)
            {
                var c = contacts[i];
                Console.WriteLine($"{i + 1}. Name: {c.Name}, Phone: {c.PhoneNumber}, Address: {c.Address}");
            }
        }
    }
}