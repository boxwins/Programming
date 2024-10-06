using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генерирует случайные товары.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Путь к данным для генерации.
        /// </summary>
        public static string PATH = @$"{Environment.CurrentDirectory}\Services\Data";

        /// <summary>
        /// Генерирует случайный товар.
        /// </summary>
        /// <returns></returns>
        public static Item GenerateRandom()
        {
            return GenerateRandom(1)[0];
        }

        /// <summary>
        /// Генерирует случайные товары.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <returns>Случайные товары.</returns>
        public static Item[] GenerateRandom(int count)
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
    }
}
