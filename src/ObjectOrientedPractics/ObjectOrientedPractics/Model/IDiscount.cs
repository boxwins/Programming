namespace ObjectOrientedPractics.Model
{
    public interface IDiscount : IEquatable<IDiscount>
    {
        /// <summary>
        /// Информация о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Считает размер скидки доступной для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Расмер скидки.</returns>
        double Calculate(IEnumerable<Item> items);

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Размер скидки.</returns>
        double Apply(IEnumerable<Item> items);

        /// <summary>
        /// Обновляет скидку.
        /// </summary>
        /// <param name="items">Товары.</param>
        void Update(IEnumerable<Item> items);
    }
}
