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
        private string _address = string.Empty;

        /// <summary>
        /// [GET] Пустой покупатель.
        /// </summary>
        public static Customer Empty
        {
            get { return new Customer("Customer", "No adress"); }
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
        public string Address
        {
            get { return _address; }
            set
            {
                Validator.StringLimit(500, value);
                _address = value;
            }
        }

        public Customer(string fullName, string adress)
        {
            FullName = fullName;
            Address = adress;
        }
    }
}
