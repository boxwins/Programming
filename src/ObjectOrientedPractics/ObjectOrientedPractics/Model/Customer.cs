using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель.
    /// </summary>
    public class Customer
    {
        private readonly int _id = IdGenerator.GetNextId<Customer>();

        private string _fullName = string.Empty;
        private Address _address = null;

        /// <summary>
        /// [GET] Пустой покупатель.
        /// </summary>
        public static Customer Empty
        {
            get { return new Customer("Customer", null); }
        }

        /// <summary>
        /// [GET] ID покупателя.
        /// </summary>
        public double ID
        {
            get { return _id; }
        }

        /// <summary>
        /// [GET / SET] Имя покупателя.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                Validator.StringLimit(200, value);
                _fullName = value;
            }
        }

        /// <summary>
        /// [GET / SET] Адрес покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="fullName">Имя покупателя.</param>
        /// <param name="adress">Адрес покупателя.</param>
        public Customer(string fullName, Address adress)
        {
            FullName = fullName;
            Address = adress;
        }
    }
}
