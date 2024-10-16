using Newtonsoft.Json;

using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
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
        private DateTime _birthday = DateTime.Today;

        private Cart _cart = new Cart();
        private List<Order> _orders = new List<Order>();

        private List<IDiscount> _discounts = new List<IDiscount>();

        private bool _isPriority = false;

        /// <summary>
        /// [GET] Пустой покупатель.
        /// </summary>
        public static Customer Empty
        {
            get { return new Customer("Customer", null, DateTime.Today); }
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
        /// [GET] День рождения покупателя.
        /// </summary>
        public DateTime Birthday
        {
            get { return _birthday; }
            private set { _birthday = value; }
        }

        /// <summary>
        /// [GET] Корзина покупателя.
        /// </summary>
        [JsonProperty]
        public Cart Cart
        {
            get { return _cart; }
            private set { _cart = value; }
        }

        /// <summary>
        /// [GET] Список заказов.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
        }

        /// <summary>
        /// [GET] Список скидок.
        /// </summary>
        [JsonProperty]
        public List<IDiscount> Discounts
        {
            get { return _discounts; }
            private set { _discounts = value; }
        }

        /// <summary>
        /// [GET / SET] Является ли покупатель приоритетным.
        /// </summary>
        public bool IsPriority
        {
            get { return _isPriority; }
            set { _isPriority = value; }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="fullName">Имя покупателя.</param>
        /// <param name="adress">Адрес покупателя.</param>
        public Customer(string fullName, Address adress, DateTime birthday)
        {
            FullName = fullName;
            Address = adress;
            Birthday = birthday;

            Discounts.Add(new PointsDiscount());
            Discounts.Add(new BirthdayDiscount(Birthday));
        }
    }
}
