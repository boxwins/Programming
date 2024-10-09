namespace ObjectOrientedPractics.Model.Data.Serialization
{
    /// <summary>
    /// Данные для сериализации класса <see cref="Store"/>.
    /// </summary>
    public class StoreSerializationData
    {
        /// <summary>
        /// [GET / SET] Товары.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// [GET / SET] Данные покупателей.
        /// </summary>
        public List<CustomerSerializationData> Customers { get; set; }
    }
}
