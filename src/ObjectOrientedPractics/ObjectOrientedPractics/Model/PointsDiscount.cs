using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Скидка накопительных баллов.
    /// </summary>
    public class PointsDiscount
    {
        private const double DISCOUNT_MAX = 0.3d;
        private const double DISCOUNT_INCREASE = 0.1d;

        private int _points = 0;

        /// <summary>
        /// [GET] Накопительные баллы.
        /// </summary>
        public int Points
        {
            get { return _points; }
            private set
            {
                Validator.BottomLimit(0, value);

                _points = value;
            }
        }

        /// <summary>
        /// [GET] Информация о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        /// <summary>
        /// Считает размер скидки доступной для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Расмер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double maxDiscount = (int)(GetCost(items) * DISCOUNT_MAX);

            return Points > maxDiscount ? maxDiscount : Points;
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            int discount = (int)Calculate(items);

            items[0].Cost -= discount % items.Count;

            int itemDiscount = discount / items.Count;
            for (int i = 0; i < items.Count; i++)
                items[i].Cost -= itemDiscount;

            Points -= discount;

            return discount;
        }

        /// <summary>
        /// Добавляет скидочные баллы за товары.
        /// </summary>
        /// <param name="items">Товары.</param>
        public void Update(List<Item> items)
        {
            Points += (int)Math.Round(GetCost(items) * DISCOUNT_INCREASE, MidpointRounding.ToPositiveInfinity);
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
    }
}
