namespace Adressbook
{
    class Contact
    {
        string firstName;
        string lastName;
        string phoneNumber;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Contact(string FirstName, string LastName, string PhoneNumber)
        {
            firstName = FirstName;
            lastName = LastName;
            phoneNumber = PhoneNumber;
        }
    }
}