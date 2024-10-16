namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Магазин.
    /// </summary>
    public class Store : ICloneable, IEquatable<Store>
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

        public object Clone()
        {
            Store store = new Store();

            List<Item> items = Items.Select(i => (Item)i.Clone()).ToList();
            List<Customer> customers = Сustomers.Select(c => (Customer)c.Clone()).ToList();

            return store;
        }

        public bool Equals(Store other)
        {
            if (ReferenceEquals(this, other)) return true;

            if (Items.Count != other.Items.Count) return false;
            for (int i = 0; i < Items.Count; i++)
            {
                if (!Items[i].Equals(other.Items[i])) return false;
            }

            if (Сustomers.Count != other.Сustomers.Count) return false;
            for (int i = 0; i < Сustomers.Count; i++)
            {
                if (!Сustomers[i].Equals(other.Сustomers[i])) return false;
            }

            return true;
        }
    }
}
