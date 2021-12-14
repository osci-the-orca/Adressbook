using System;
using System.Collections.Generic;

namespace Adressbook
{
    class Menu
    {
        public int index;
        Contactbook contactbook = new Contactbook();
        public void Run()
        {
            ShowMenu();
        }
        public void ShowMenu()
        {
            Search search = new Search();

            Console.Clear();
            List<string> menuOption = new List<string>();
            menuOption.Add("Generate Contacts for test data");
            menuOption.Add("Show Contacts");
            menuOption.Add("Add Contacts");
            menuOption.Add("Delete Contacts");
            menuOption.Add("Search Contacts");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ADRESSBOOK\n");

                Console.ResetColor();
                string selectedOption = navigateMenu(menuOption);
                if (selectedOption == menuOption[0])                //Generate Contacts
                {
                    Console.Clear();
                    GenerateNames(contactbook.GetList());
                }
                else if (selectedOption == menuOption[1])           // Show Contacts
                {
                    Console.Clear();
                    contactbook.ShowContacts();
                }
                else if (selectedOption == menuOption[2])           //Add Contacts
                {
                    Console.Clear();
                    contactbook.AddContact();
                }
                else if (selectedOption == menuOption[3])           // Delete Contacts
                {
                    Console.Clear();
                    contactbook.DeleteContacts();
                }
                else if (selectedOption == menuOption[4])           //Search Contacts
                {
                    Console.Clear();
                    search.SearchContacts(contactbook.GetList());
                }
            }
        }
        public string navigateMenu(List<string> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(options[i]);
                }
                else
                {
                    Console.WriteLine(options[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.DownArrow)
            {
                if (index == options.Count - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            else if (keyPressed.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = options.Count - 1;
                }
                else
                {
                    index--;
                }
            }
            else if (keyPressed.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
            }
            else if (keyPressed.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
            }
            else if (keyPressed.Key == ConsoleKey.Enter)
            {
                return options[index];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }
        public void GenerateNames(IList<Contact> contacts)
        {
            List<string> firstNames = new List<string> { "Oscar", "Anders", "Mikael", "Olle", "Jonna", "Alexandra", "Sara" };
            List<string> lastNames = new List<string> { "Andersson", "Johansson", "Berg", "Dahl", "Stensson", "Fasth", "Dahlgren" };
            List<string> phoneNumbers = new List<string> { "0702553333", "0704331233", "0734842910", "0733102302", "0705375689", "0742387644", "0737576418" };
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int index = random.Next(0, firstNames.Count);
                int index2 = random.Next(0, lastNames.Count);
                int index3 = random.Next(0, phoneNumbers.Count);

                string firstName = firstNames[index];
                string lastName = lastNames[index2];
                string phoneNumber = phoneNumbers[index3];

                contactbook.AddContact(firstName, lastName, phoneNumber);

            }
        }
    }
}