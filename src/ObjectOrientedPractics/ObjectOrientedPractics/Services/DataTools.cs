using System.Collections.ObjectModel;

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
        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Func<T,bool> selector)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < items.Count(); i++)
            {
                if (selector(items.ElementAt(i))) result.Add(items.ElementAt(i));
            }

            return result;
        }

        /// <summary>
        /// Сортирует коллекцию по определенному параметру.
        /// </summary>
        /// <param name="items">Коллекция.</param>
        /// <param name="selector">Условие выбора параметра.</param>
        /// <param name="comparer">Условие сортировки.</param>
        public static IEnumerable<T> Sort<T,V>(IEnumerable<T> items, Func<T,V> selector, Func<V,V,int> comparer)
        {
            T[] sorted = new T[items.Count()];
            int[] locations = new int[items.Count()];

            for (int i1 = 0; i1 < items.Count(); i1++)
            {
                for (int i2 = i1 + 1; i2 < items.Count(); i2++)
                {
                    int comparison = comparer(selector(items.ElementAt(i1)), selector(items.ElementAt(i2)));

                    if (comparison > 0) locations[i1]++;
                    if (comparison < 0) locations[i2]++;

                    if (comparison == 0) locations[i2]++;
                }
            }

            for (int i = 0; i < items.Count(); i++)
            {
                sorted[locations[i]] = items.ElementAt(i);
            }

            return sorted.ToList();
        }

        /// <summary>
        /// Добавляет список элементов в коллекцию.
        /// </summary>
        /// <param name="collection">Коллекция.</param>
        /// <param name="elements">Список элементов.</param>
        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> elements)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                collection.Add(elements.ElementAt(i));
            }
        }
    }
}
