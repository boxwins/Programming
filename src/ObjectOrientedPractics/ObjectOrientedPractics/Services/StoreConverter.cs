using ObjectOrientedPractics.Model.Data.Serialization;
using ObjectOrientedPractics.Model;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// JSON конвертер для объекта <see cref="Store"/>>.
    /// </summary>
    public class StoreConverter : JsonConverter<Store>
    {
        public override Store Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            StoreSerializationData storeData = JsonSerializer.Deserialize<StoreSerializationData>(ref reader);

            Store store = new Store();
            store.Items = storeData.Items;

            for (int i = 0; i < storeData.Customers.Count; i++)
            {
                Customer customer = new Customer(
                    storeData.Customers[i].FullName,
                    storeData.Customers[i].Address);

                customer.Cart.Items.AddRange(
                    ReadItemIndexes(store.Items, storeData.Customers[i].Cart.Indexes));

                for (int j = 0; j < storeData.Customers[i].Orders.Count; j++)
                {
                    Order order = new Order();
                    order.Address = storeData.Customers[i].Orders[j].Address;
                    order.StatusLog = storeData.Customers[i].Orders[j].StatusLog;

                    order.Items.AddRange(
                        ReadItemIndexes(store.Items, storeData.Customers[i].Orders[j].Items.Indexes));

                    customer.Orders.Add(order);
                }

                store.Сustomers.Add(customer);
            }

            return store;
        }

        public override void Write(Utf8JsonWriter writer, Store store, JsonSerializerOptions options)
        {
            StoreSerializationData storeData = new StoreSerializationData();

            storeData.Items = store.Items;
            storeData.Customers = new List<CustomerSerializationData>();

            for (int i = 0; i < store.Сustomers.Count; i++)
            {
                CustomerSerializationData customerData = new CustomerSerializationData();
                customerData.Address = store.Сustomers[i].Address;
                customerData.FullName = store.Сustomers[i].FullName;

                customerData.Cart = new ItemListSerializationData();
                customerData.Cart.Indexes = WriteItemIndexes(storeData.Items, store.Сustomers[i].Cart.Items);

                customerData.Orders = new List<OrderSerializationData>();

                for (int j = 0; j < store.Сustomers[i].Orders.Count; j++)
                {
                    OrderSerializationData orderData = new OrderSerializationData();
                    orderData.Address = store.Сustomers[i].Orders[j].Address;
                    orderData.StatusLog = store.Сustomers[i].Orders[j].StatusLog;

                    orderData.Items = new ItemListSerializationData();
                    orderData.Items.Indexes = WriteItemIndexes(storeData.Items, store.Сustomers[i].Orders[j].Items);

                    customerData.Orders.Add(orderData);
                }

                storeData.Customers.Add(customerData);
            }

            writer.WriteRawValue(JsonSerializer.Serialize(storeData, options));
        }

        /// <summary>
        /// Возвращает список товаров относительно переданных товаров и индексов.
        /// </summary>
        /// <param name="storeItems">Товары.</param>
        /// <param name="currentIndexes">Текущие индексы.</param>
        /// <returns>Список товаров.</returns>
        private List<Item> ReadItemIndexes(List<Item> storeItems, int[] currentIndexes)
        {
            return currentIndexes.Select(c =>
            {
                if (c >= 0) return storeItems[c];
                else return ItemFactory.GenerateRandom();
            })
                .ToList();
        }

        /// <summary>
        /// Возвращает список индексов относительно переданных товаров.
        /// </summary>
        /// <param name="storeItems">Товары.</param>
        /// <param name="currentItems">Текущие товары.</param>
        /// <returns>Список индексов.</returns>
        private int[] WriteItemIndexes(List<Item> storeItems, List<Item> currentItems)
        {
            return currentItems.
                Select(c =>
                {
                    if (!storeItems.Contains(c))
                        storeItems.Add(c);
                    return storeItems.IndexOf(c);
                })
                .ToArray();
        }
    }
}
