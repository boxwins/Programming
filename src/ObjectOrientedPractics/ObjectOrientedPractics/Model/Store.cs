using System.Text.Json.Serialization;

using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Магазин.
    /// </summary>
    [JsonConverter(typeof(StoreConverter))]
    public class Store
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// [GET / SET] Товары.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// [GET / SET] Товары.
        /// </summary>
        public List<Customer> Сustomers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public Store() { }
    }
}
