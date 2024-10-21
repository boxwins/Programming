using System.Collections.ObjectModel;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генератор объектов.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Путь к данным для генерации.
        /// </summary>
        public static string PATH = @$"{Environment.CurrentDirectory}\Services\Data";

        /// <summary>
        /// Генерирует случайный товар.
        /// </summary>
        /// <returns></returns>
        public static Item GenerateItem()
        {
            return GenerateItems(1)[0];
        }

        /// <summary>
        /// Генерирует случайные товары.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <returns>Случайные товары.</returns>
        public static Item[] GenerateItems(int count)
        {
            Item[] result = new Item[count];

            string[] names = Serializer.Deserialize(@$"{PATH}\Names.txt");
            string[] infos = Serializer.Deserialize(@$"{PATH}\Descriptions.txt");

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                string name = names[random.Next(names.Length)];
                string info = infos[random.Next(infos.Length)];
                double cost = random.Next(100);

                Array categories = Enum.GetValues(typeof(Category));
                Category category = (Category)categories.GetValue(random.Next(categories.Length));

                result[i] = new Item(name, info, cost, category);
            }

            return result;
        }

        /// <summary>
        /// Генерирует случайного покупателя.
        /// </summary>
        /// <returns>Случайный покупатель.</returns>
        public static Customer GenerateCustomer()
        {
            return GenerateCustomers(1)[0];
        }

        /// <summary>
        /// Генерирует случайных покупателей.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <returns>Случайные покупатели.</returns>
        public static Customer[] GenerateCustomers(int count)
        {
            Customer[] result = new Customer[count];

            string[] fullNames = Serializer.Deserialize(@$"{PATH}\FullNames.txt");
            Address[] addresses = GenerateAddresses(count);

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                string fullName = fullNames[random.Next(fullNames.Length)];

                int birthdayYear = random.Next(1970, 2008);
                DateTime birthday = new DateTime(birthdayYear, 1, 1);
                birthday = birthday.AddDays(random.Next(365));

                Customer customer = new Customer(fullName, addresses[i], birthday);
                customer.IsPriority = random.Next() % 2 == 0;

                Order[] orders = customer.IsPriority ? GeneratePriorityOrders(1) : GenerateOrders(1);
                customer.Orders.AddRange(orders);


                result[i] = customer;
            }

            return result;
        }

        /// <summary>
        /// Генерирует случайный адрес.
        /// </summary>
        /// <returns>Случайный адрес.</returns>
        public static Address GenerateAddress()
        {
            return GenerateAddresses(1)[0];
        }

        /// <summary>
        /// Генерирует случайные адреса.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <returns>Случайные адреса.</returns>
        public static Address[] GenerateAddresses(int count)
        {
            Address[] result = new Address[count];

            string[] countries = Serializer.Deserialize(@$"{PATH}\Countries.txt");
            string[] cities = Serializer.Deserialize(@$"{PATH}\Cities.txt");
            string[] streets = Serializer.Deserialize(@$"{PATH}\Streets.txt");

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                Address address = new Address();

                address.Country = countries[random.Next(countries.Length)];
                address.City = cities[random.Next(cities.Length)];
                address.Street = streets[random.Next(streets.Length)];

                address.Index = random.Next(100_000, 1_000_000);
                address.Building = random.Next(1, 30).ToString();
                address.Apartment = random.Next(1, 100).ToString();

                result[i] = address;
            }

            return result;
        }

        /// <summary>
        /// Генерирует случайный заказ.
        /// </summary>
        /// <returns>Случайный заказ.</returns>
        public static Order GenerateOrder()
        {
            return GenerateOrders(1)[0];
        }

        /// <summary>
        /// Генерирует случайные заказы.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <returns>Случайные заказы.</returns>
        public static Order[] GenerateOrders(int count)
        {
            Order[] result = new Order[count];

            Address[] addresses = GenerateAddresses(count);

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                Order order = new Order();

                order.Items = new ObservableCollection<Item>(GenerateItems(4));
                order.Address = addresses[i];

                result[i] = order;
            }

            return result;
        }

        /// <summary>
        /// Генерирует случайный приоритетный заказ.
        /// </summary>
        /// <returns>Случайный приоритетный заказ.</returns>
        public static PriorityOrder GeneratePriorityOrder()
        {
            return GeneratePriorityOrders(1)[0];
        }

        /// <summary>
        /// Генерирует случайные приоритетные заказы.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <returns>Случайные приоритетные заказы.</returns>
        public static PriorityOrder[] GeneratePriorityOrders(int count)
        {
            Order[] orders = GenerateOrders(count);
            PriorityOrder[] result = new PriorityOrder[count];

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                PriorityOrder priorityOrder = new PriorityOrder(DateTime.Today, random.Next(PriorityOrder.DeliveryTimes.Length));

                priorityOrder.Items = orders[i].Items;
                priorityOrder.Address = orders[i].Address;

                result[i] = priorityOrder;
            }

            return result;
        }
    }
}
