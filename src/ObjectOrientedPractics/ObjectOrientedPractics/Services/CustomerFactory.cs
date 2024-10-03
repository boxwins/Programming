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
            string[] addresses = Serializer.Deserialize(@$"{PATH}\Addresses.txt");

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                string fullName = fullNames[random.Next(fullNames.Length)];
                string address = addresses[random.Next(addresses.Length)];

                result[i] = new Customer(fullName, address);
            }

            return result;
        }
    }
}
