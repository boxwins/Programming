namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс реализующий методы по обработки данных.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Фильтрует элементы коллекции.
        /// </summary>
        /// <param name="items">Коллекция.</param>
        /// <param name="selector">Условие выбора элемента.</param>
        /// <returns>Отфильтрованная коллекция.</returns>
        public static List<T> Filter<T>(List<T> items, Func<T,bool> selector)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < items.Count; i++)
            {
                if (selector(items[i])) result.Add(items[i]);
            }

            return result;
        }

        /// <summary>
        /// Сортирует коллекцию по определенному параметру.
        /// </summary>
        /// <param name="items">Коллекция.</param>
        /// <param name="selector">Условие выбора параметра.</param>
        /// <param name="comparer">Условие сортировки.</param>
        public static List<T> Sort<T,V>(List<T> items, Func<T,V> selector, Func<V,V,int> comparer)
        {
            T[] sorted = new T[items.Count];
            int[] locations = new int[items.Count];

            for (int i1 = 0; i1 < items.Count; i1++)
            {
                for (int i2 = i1 + 1; i2 < items.Count; i2++)
                {
                    int comparison = comparer(selector(items[i1]), selector(items[i2]));

                    if (comparison > 0) locations[i1]++;
                    if (comparison < 0) locations[i2]++;

                    if (comparison == 0) locations[i2]++;
                }
            }

            for (int i = 0; i < items.Count; i++)
            {
                sorted[locations[i]] = items[i];
            }

            return sorted.ToList();
        }
    }
}
