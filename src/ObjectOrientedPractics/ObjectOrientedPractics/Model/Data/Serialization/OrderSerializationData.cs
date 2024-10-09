namespace ObjectOrientedPractics.Model.Data.Serialization
{
    /// <summary>
    /// Данные для сериализации класса <see cref="Order"/>.
    /// </summary>
    public class OrderSerializationData
    {
        /// <summary>
        /// [GET / SET] Адрес доставки.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// [GET / SET] Данные о товарах.
        /// </summary>
        public ItemListSerializationData Items { get; set; }

        /// <summary>
        /// [GET / SET] Статус заказа.
        /// </summary>
        public Dictionary<DateTime, OrderStatus> StatusLog { get; set; }
    }
}
