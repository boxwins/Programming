namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генерирует идентификаторы для объектов.
    /// </summary>
    public static class IdGenerator
    {
        private static Dictionary<Type, int> _ids = new Dictionary<Type, int>();

        /// <summary>
        /// Генерирует идентификатор для объекта.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <returns>Уникальный идентификатор.</returns>
        public static int GetNextId<T>()
        {
            if (!_ids.ContainsKey(typeof(T)))
            {
                _ids.Add(typeof(T), 0);
            }

            return _ids[typeof(T)]++;
        }

        /// <summary>
        /// Генерирует идентификатор для объекта.
        /// </summary>
        /// <param name="obj">Объект.</param>
        /// <returns>Уникальный идентификатор.</returns>
        public static int GetNextId(object obj)
        {
            Type type = obj.GetType();

            if (!_ids.ContainsKey(type))
            {
                _ids.Add(type, 0);
            }

            return _ids[type]++;
        }
    }
}
