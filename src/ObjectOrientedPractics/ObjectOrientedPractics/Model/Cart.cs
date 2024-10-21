using System.Collections.ObjectModel;

using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Корзина товаров.
    /// </summary>
    public class Cart : ICloneable, IEquatable<Cart>
    {
        private ObservableCollection<Item> _items = new ObservableCollection<Item>();

        /// <summary>
        /// [GET] Товары в корзине.
        /// </summary>
        [JsonProperty]
        public ObservableCollection<Item> Items
        {
            get { return _items; }
            private set { _items = value; }
        }

        /// <summary>
        /// [GET] Общая стоимость товаров в корзине.
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

        public object Clone()
        {
            Cart cart = new Cart();
            cart.Items = new ObservableCollection<Item>(Items);

            return cart;
        }

        public bool Equals(Cart other)
        {
            if (ReferenceEquals(this, other)) return true;

            if (Items.Count != other.Items.Count) return false;

            for (int i = 0; i < Items.Count; i++)
            {
                if (!Items[i].Equals(other.Items[i])) return false;
            }

            return true;
        }
    }
}
