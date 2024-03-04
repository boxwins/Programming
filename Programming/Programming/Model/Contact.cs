namespace Programming.Model
{
    /// <summary>
    /// Контакт.
    /// </summary>
    public class Contact
    {
        private int _phoneNumber = 0;
        private string _mail = string.Empty;
        private string _name = string.Empty;
        private string _surname = string.Empty;

        /// <summary>
        /// [GET / SET] Номер телефона.
        /// </summary>
        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                Validator.OnlyPositive(value, nameof(PhoneNumber));
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// [GET / SET] Электронная почта.
        /// </summary>
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        /// <summary>
        /// [GET / SET] Имя.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                Validator.OnlyLatin(value, nameof(Name));
                _name = value; 
            }
        }

        /// <summary>
        /// [GET / SET] Фамилия.
        /// </summary>
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

        /// <param name="name"><see cref="Name">.</param>
        /// <param name="surname"><see cref="Surname">.</param>
        /// <param name="phoneNumber"><see cref="PhoneNumber">.</param>
        /// <param name="mail"><see cref="Mail">.</param>
        public Contact(string name, string surname, int phoneNumber, string mail)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Mail = mail;
        }
    }
}
