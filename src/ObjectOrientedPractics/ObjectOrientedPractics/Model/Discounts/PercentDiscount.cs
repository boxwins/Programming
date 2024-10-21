using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        private const int DISCOUNT_MAX = 10;
        private const int DISCOUNT_START = 1;
        private const int DISCOUNT_INCREASE = 1;
        private const int DISCOUNT_TRESHOLD = 1000;

        private int _discount = DISCOUNT_START;
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
        public double DiscountRelative
        {
            get { return Discount / 100.0d; }
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

        public double Calculate(IEnumerable<Item> items)
        {
            return GetCost(SelectDiscounted(items)) * DiscountRelative;
        }

        public double Apply(IEnumerable<Item> items)
        {
            int discount = (int)Calculate(items);

            Discount = DISCOUNT_START;

            return discount;
        }

        public void Update(IEnumerable<Item> items)
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
        private double GetCost(IEnumerable<Item> items)
        {
            double cost = 0;
            for (int i = 0; i < items.Count(); i++) cost += items.ElementAt(i).Cost;
            return cost;
        }

        /// <summary>
        /// Выбирает товары подхожящие для скидки.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Подходящие товары.</returns>
        private IEnumerable<Item> SelectDiscounted(IEnumerable<Item> items)
        {
            return items.Where(i => i.Category == Category).ToList();
        }

        public int CompareTo(PercentDiscount other)
        {
            return Discount.CompareTo(other.Discount);
        }

        public bool Equals(IDiscount other)
        {
            if (other is not PercentDiscount percentDiscount) return false;

            if (ReferenceEquals(this, other)) return true;

            if (Discount != percentDiscount.Discount) return false;
            if (Category != percentDiscount.Category) return false;

            return true;
        }
    }
}
