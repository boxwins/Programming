namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Корзина товаров.
    /// </summary>
    public class Cart
    {
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// [GET] Товары в корзине.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
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
    }
}
