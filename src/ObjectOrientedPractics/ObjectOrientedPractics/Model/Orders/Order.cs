using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order : IEquatable<Order>
    {
        private readonly int _id = IdGenerator.GetNextId<Order>();

        private Address _address = null;
        private List<Item> _items = new List<Item>();
        private Dictionary<DateTime, OrderStatus> _statusLog = new Dictionary<DateTime, OrderStatus>();

        /// <summary>
        /// [GET] ID заказа.
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// [GET / SET] Адрес заказа.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// [GET / SET] Товары в заказе.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// [GET / SET] История изменения статуса заказа.
        /// </summary>
        public Dictionary<DateTime, OrderStatus> StatusLog
        {
            get { return _statusLog; }
            set { _statusLog = value; }
        }

        /// <summary>
        /// [GET / SET] Текущий статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get
            {
                return StatusLog.Values.ElementAt(StatusLog.Count - 1);
            }
            set
            {
                StatusLog.Add(DateTime.Now, value);
            }
        }

        /// <summary>
        /// [GET] Время последнего изменения статуса.
        /// </summary>
        public DateTime DateTime
        {
            get
            {
                return StatusLog.Keys.ElementAt(StatusLog.Count - 1);
            }
        }

        /// <summary>
        /// [GET] Стоимость товаров в заказе.
        /// </summary>
        public double Amount
        {
            get
            {
                double result = 0;

                for (int i = 0; i < Items?.Count; i++)
                {
                    result += Items[i].Cost;
                }

                return result;
            }
        }

        /// <summary>
        /// [GET / SET] Размер скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// [GET] Стоимость товаров с учетом скидки.
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public Order()
        {
            _statusLog.Add(DateTime.Now, OrderStatus.New);
        }

        public bool Equals(Order other)
        {
            if (ReferenceEquals(this, other)) return true;

            if (!Address.Equals(other.Address)) return false;
            if (DiscountAmount != other.DiscountAmount) return false;

            if (Items.Count != other.Items.Count) return false;
            if (StatusLog.Count != other.StatusLog.Count) return false;

            for (int i = 0; i < Items.Count; i++)
                if (!Items[i].Equals(other.Items[i])) return false;

            for (int i = 0; i < StatusLog.Count; i++)
            {
                if (StatusLog.ElementAt(i).Key != other.StatusLog.ElementAt(i).Key) return false;
                if (StatusLog.ElementAt(i).Value != other.StatusLog.ElementAt(i).Value) return false;
            }

            return true;
        }
    }
}
