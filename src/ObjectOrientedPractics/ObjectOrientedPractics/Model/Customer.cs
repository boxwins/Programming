using System.Collections.ObjectModel;

using Newtonsoft.Json;

using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель.
    /// </summary>
    public class Customer : ICloneable, IEquatable<Customer>
    {
        private readonly int _id = IdGenerator.GetNextId<Customer>();

        private string _fullName = string.Empty;
        private Address _address = null;
        private DateTime _birthday = DateTime.Today;

        private Cart _cart = new Cart();
        private ObservableCollection<Order> _orders = new ObservableCollection<Order>();

        private ObservableCollection<IDiscount> _discounts = new ObservableCollection<IDiscount>();

        private bool _isPriority = false;

        /// <summary>
        /// Пустой покупатель.
        /// </summary>
        public static Customer Empty
        {
            get { return new Customer("Customer", null, DateTime.Today); }
        }

        /// <summary>
        /// ID покупателя.
        /// </summary>
        public double ID
        {
            get { return _id; }
        }

        /// <summary>
        /// Имя покупателя.
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
        /// Адрес покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// День рождения покупателя.
        /// </summary>
        public DateTime Birthday
        {
            get { return _birthday; }
            private set { _birthday = value; }
        }

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        [JsonProperty]
        public Cart Cart
        {
            get { return _cart; }
            private set { _cart = value; }
        }

        /// <summary>
        /// Список заказов.
        /// </summary>
        public ObservableCollection<Order> Orders
        {
            get { return _orders; }
            private set { _orders = value; }
        }

        /// <summary>
        /// Список скидок.
        /// </summary>
        [JsonProperty]
        public ObservableCollection<IDiscount> Discounts
        {
            get { return _discounts; }
            private set { _discounts = value; }
        }

        /// <summary>
        /// Является ли покупатель приоритетным.
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

        public object Clone()
        {
            return new Customer(FullName, (Address)Address.Clone(), Birthday)
            {
                IsPriority = IsPriority,
                Discounts = new ObservableCollection<IDiscount>(Discounts),
                Orders = new ObservableCollection<Order>(Orders),
                Cart = (Cart)Cart.Clone()
            };
        }

        public bool Equals(Customer other)
        {
            if (ReferenceEquals(this, other)) return true;

            if (FullName != other.FullName) return false;
            if (Birthday != other.Birthday) return false;
            if (IsPriority != other.IsPriority) return false;

            if (!Cart.Equals(other.Cart)) return false;
            if (!Address.Equals(other.Address)) return false;

            if (Orders.Count != other.Orders.Count) return false;
            if (Discounts.Count != other.Discounts.Count) return false;

            for (int i = 0; i < Orders.Count; i++)
                if (!Orders[i].Equals(other.Orders[i])) return false;

            for (int i = 0; i < Discounts.Count; i++)
                if (!Discounts[i].Equals(other.Discounts[i])) return false;

            return true;
        }
    }
}
