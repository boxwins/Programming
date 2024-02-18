namespace Programming.Model
{
    public class Contact
    {
        private int _phoneNumber = 0;
        private string _mail = string.Empty;
        private string _name = string.Empty;
        private string _surname = string.Empty;

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                Validator.OnlyPositive(value, nameof(PhoneNumber));
                _phoneNumber = value;
            }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string Name
        {
            get { return _name; }
            set 
            {
                Validator.OnlyLatin(value, nameof(Name));
                _name = value; 
            }
        }

        public string Surname
        {
            get { return _surname; }
            set 
            {
                Validator.OnlyLatin(value, nameof(Surname));
                _surname = value; 
            }
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
