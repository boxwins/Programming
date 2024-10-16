using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Скидка накопительных баллов.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
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

        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        public double Calculate(List<Item> items)
        {
            double maxDiscount = (int)Math.Round(GetCost(items) * DISCOUNT_MAX, MidpointRounding.AwayFromZero);

            return Points > maxDiscount ? maxDiscount : Points;
        }

        public double Apply(List<Item> items)
        {
            int discount = (int)Math.Round(Calculate(items) - 0.5d, MidpointRounding.AwayFromZero);

            Points -= discount;

            return discount;
        }

        public void Update(List<Item> items)
        {
            Points += (int)Math.Round(GetCost(items) * DISCOUNT_INCREASE, MidpointRounding.AwayFromZero);
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

        public int CompareTo(PointsDiscount other)
        {
            return Points.CompareTo(other.Points);
        }
    }
}
