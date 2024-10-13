using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount
    {
        private const int DISCOUNT_MAX = 10;
        private const int DISCOUNT_INCREASE = 1;
        private const int DISCOUNT_TRESHOLD = 1000;

        private int _discount = 1;
        private double _purchaseValue = 0;

        private Category _category = Category.None;

        /// <summary>
        /// [GET] Текущая скидка в процентах.
        /// </summary>
        public int Discount
        {
            get { return _discount; }
            private set { _discount = value; }
        }

        /// <summary>
        /// [GET] Текущая скидка в отношении.
        /// </summary>
        public int DiscountRelative
        {
            get { return Discount / 100; }
        }

        /// <summary>
        /// [GET / SET] Стоимость купленных товаров после изменения скидки.
        /// </summary>
        public double PurchaseValue
        {
            get { return _purchaseValue; }
            private set { _purchaseValue = value; }
        }

        /// <summary>
        /// [GET / SET] Категория товаров для скидки.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string Info
        {
            get
            {
                return $"Процентная \"{Category}\" - {Discount}%";
            }
        }

        public double Calculate(List<Item> items)
        {
            return GetCost(SelectDiscounted(items)) * DiscountRelative;
        }

        public double Apply(List<Item> items)
        {
            int discount = (int)Calculate(items);

            List<Item> discountItems = SelectDiscounted(items);

            discountItems[0].Cost -= discount % items.Count;

            int itemDiscount = discount / items.Count;
            for (int i = 0; i < discountItems.Count; i++)
                items[i].Cost -= itemDiscount;

            return discount;
        }

        public void Update(List<Item> items)
        {
            double cost = GetCost(SelectDiscounted(items));

            Discount += (int)(cost / DISCOUNT_TRESHOLD);
            if (Discount > DISCOUNT_MAX) Discount = DISCOUNT_MAX;

            PurchaseValue += cost % DISCOUNT_TRESHOLD;
        }

        /// <summary>
        /// Считает стоимость товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Стоимость товаров.</returns>
        private double GetCost(List<Item> items)
        {
            double cost = 0;
            for (int i = 0; i < items.Count; i++) cost += items[i].Cost;
            return cost;
        }

        /// <summary>
        /// Выбирает товары подхожящие для скидки.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Подходящие товары.</returns>
        private List<Item> SelectDiscounted(List<Item> items)
        {
            return items.Where(i => i.Category == Category).ToList();
        }
    }
}
