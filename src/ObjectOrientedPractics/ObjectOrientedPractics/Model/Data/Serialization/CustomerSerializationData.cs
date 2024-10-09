namespace ObjectOrientedPractics.Model.Data.Serialization
{
    /// <summary>
    /// Данные для сериализации класса <see cref="Customer"/>.
    /// </summary>
    public class CustomerSerializationData
    {
        /// <summary>
        /// [GET / SET] Имя покупателя.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// [GET / SET] Адрес.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// [GET / SET] Данные о корзине.
        /// </summary>
        public ItemListSerializationData Cart { get; set; }

        /// <summary>
        /// [GET / SET] Данные о списке заказов.
        /// </summary>
        public List<OrderSerializationData> Orders { get; set; }
    }
}
