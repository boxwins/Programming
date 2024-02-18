namespace Programming.Model
{
    public class Contact
    {
        private int _phoneNumber = 0;
        private string _name = string.Empty;
        private string _mail = string.Empty;

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value < 0) throw new ArgumentException("Value cannot be negative");
                _phoneNumber = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public Contact() { }

        public Contact(string name, int phoneNumber, string mail)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Mail = mail;
        }
    }
}
