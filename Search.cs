using System;
using System.Collections.Generic;


namespace Adressbook
{
    class Search
    {
        public void SearchContacts(IList<Contact> contacts)
        {
            string searchString = "";
            while (true)
            {

                Console.Clear();
                Console.Write($"Search: {searchString}\n");

                if (searchString.Length > 1)
                {
                    Console.WriteLine("\nRESULTS: \n");
                    bool match = false;
                    foreach (Contact c in contacts)
                    {
                        string fullName = c.FirstName + " " + c.LastName;

                        if (fullName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        {
                            match = true;
                            Console.WriteLine(c.FirstName + " - " + c.LastName + " - " + c.PhoneNumber);
                        }
                    }
                    if (match == false)
                    {
                        Console.WriteLine("No contacts found");
                    }
                }

                else Console.WriteLine("\nType to Search or press ESC to go back");

                Console.SetCursorPosition(8 + searchString.Length, 0);
                ConsoleKeyInfo input = Console.ReadKey();

                if (input.Key == ConsoleKey.Backspace)
                {
                    if (searchString.Length > 0)
                        searchString = searchString.Remove(searchString.Length - 1);
                }
                else if (input.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    List<Contact> searchResult = new List<Contact>();
                    foreach (Contact c in contacts)
                    {
                        if (c.FirstName.Contains(searchString, StringComparison.OrdinalIgnoreCase) || c.LastName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        {
                            searchResult.Add(c);
                        }
                    }
                    foreach (Contact c in searchResult)
                    {
                        Console.WriteLine(c.FirstName + " - " + c.LastName + " - " + c.PhoneNumber);

                    }
                    Console.ReadLine();
                }
                else
                {
                    searchString += input.KeyChar;
                }
            }
        }
    }
}




