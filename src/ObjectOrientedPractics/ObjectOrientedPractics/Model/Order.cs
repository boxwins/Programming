using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order
    {
        private readonly int _id = IdGenerator.GetNextId<Order>();
        private readonly DateTime _dateTime = DateTime.Now;

        private Address _address    = null;
        private List<Item> _items   = new List<Item>();
        private OrderStatus _status = OrderStatus.New;

        /// <summary>
        /// [GET] ID заказа.
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// [GET] Дата и время заказа.
        /// </summary>
        public DateTime DateTime
        {
            get { return _dateTime; }
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
        /// [GET / SET] Статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
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
    }
}
