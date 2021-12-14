using System.Collections.Generic;


namespace Adressbook
{
    class Contactbook
    {
        private List<Contact> contacts = new List<Contact>();



        public IList<Contact> GetList()
        {
            IList<Contact> _contacts = contacts.AsReadOnly();
            return _contacts;
        }

        public void AddContact()
        {
            string firstName = ConsoleUtils.ReadString("First Name:");
            string lastName = ConsoleUtils.ReadString("Laste Name: ");
            string phoneNr = ConsoleUtils.ReadString("Phone Number:");
            Contact newContact = new Contact(firstName, lastName, phoneNr);
            contacts.Add(newContact);
        }

        public void AddContact(string firstName, string lastName, string phoneNr)
        {
            Contact newContact = new Contact(firstName, lastName, phoneNr);
            contacts.Add(newContact);
        }

        public void ShowContacts()
        {
            foreach (Contact contact in contacts)
            {
                ConsoleUtils.WriteString(contact.FirstName + '-');
                ConsoleUtils.WriteString(contact.LastName + '-');
                ConsoleUtils.WriteString(contact.PhoneNumber + '\n');
            }
        }
        public void DeleteContacts()
        {
            ShowContacts();


            string ContactToDelete = ConsoleUtils.ReadString("Type the name of the Contact you want to delete ");
            List<Contact> temporaryList = new List<Contact>();

            foreach (Contact item in contacts)
            {
                if (item.FirstName.Contains(ContactToDelete))
                {
                    temporaryList.Add(item);
                }
            }

            foreach (Contact item in temporaryList)
            {
                contacts.Remove(item);
            }
        }



    }

}