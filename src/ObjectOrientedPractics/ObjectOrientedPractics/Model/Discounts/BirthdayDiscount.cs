namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Скидка ко дню рождения.
    /// </summary>
    public class BirthdayDiscount : IDiscount
    {
        private const double DISCOUNT = 0.1d;
        private const int DAYS_BEFORE = 7;
        private const int DAYS_AFTER = 7;

        /// <summary>
        /// Дата дня рождения.
        /// </summary>
        public DateTime Birthday{ get; set; }

        public BirthdayDiscount(DateTime birthday)
        {
            Birthday = birthday;
        }

        public string Info
        {
            get { return $"Ко дню рождения {GetCurrentBirthday()}"; }
        }

        public double Calculate(List<Item> items)
        {
            if (!Available()) return 0.0d;
            return GetCost(items) * DISCOUNT;
        }

        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        public void Update(List<Item> items)
        {

        }

        private bool Available()
        {
            DateTime birthday = GetCurrentBirthday();
            DateTime birthdayNear = new DateTime(DateTime.Now.Year, birthday.Month, birthday.Day);

            int days = (DateTime.Now - birthdayNear).Days;
            return days >= -DAYS_BEFORE && days <= DAYS_AFTER;
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
        /// Находит дату дня рождения в текущем году.
        /// </summary>
        /// <returns></returns>
        private DateTime GetCurrentBirthday()
        {
            return new DateTime(DateTime.Now.Year, Birthday.Month, Birthday.Day);
        }
    }
}
