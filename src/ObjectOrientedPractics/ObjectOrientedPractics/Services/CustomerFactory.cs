using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генерирует случайных поекпателей.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Путь к данным для генерации.
        /// </summary>
        public static string PATH = @$"{Environment.CurrentDirectory}\Services\Data";

        /// <summary>
        /// Генерирует случайного покупателя.
        /// </summary>
        /// <returns>Случайгый покупатель.</returns>
        public static Customer GenerateRandom()
        {
            return GenerateRandom(1)[0];
        }

        /// <summary>
        /// Генерирует случайных покупателей.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <returns>Случайные покупатели.</returns>
        public static Customer[] GenerateRandom(int count)
        {
            Customer[] result = new Customer[count];

            string[] fullNames = Serializer.Deserialize(@$"{PATH}\FullNames.txt");
            string[] countries = Serializer.Deserialize(@$"{PATH}\Countries.txt");
            string[] cities = Serializer.Deserialize(@$"{PATH}\Cities.txt");
            string[] streets = Serializer.Deserialize(@$"{PATH}\Streets.txt");

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                string fullName = fullNames[random.Next(fullNames.Length)];

                Address address = new Address();

                address.Country = countries[random.Next(countries.Length)];
                address.City = cities[random.Next(cities.Length)];
                address.Street = streets[random.Next(streets.Length)];

                address.Index = random.Next(100_000, 1_000_000);
                address.Building = random.Next(1, 30).ToString();
                address.Apartment = random.Next(1, 100).ToString();

                result[i] = new Customer(fullName, address);
            }

            return result;
        }
    }
}
