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

        /// <summary>
        /// [GET] Дата и время заказа.
        /// </summary>
        public DateTime DateTime
        {
            get { return _dateTime; }
        }

        /// <summary>
        /// [GET] Адрес заказа.
        /// </summary>
        public Address Address
        {
            get { return _address; }
        }

        /// <summary>
        /// [GET] Товары в заказе.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
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
