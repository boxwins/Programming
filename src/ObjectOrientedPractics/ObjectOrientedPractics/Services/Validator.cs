namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Выполняет проверку значений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет максимальную длину строки.
        /// </summary>
        /// <param name="limit">Максимальная длина строки.</param>
        /// <param name="value">Строка.</param>
        public static void StringLimit(int limit, string value)
        {
            if (value.Length > limit) throw new ArgumentException($"Длина строки не может быть больше {limit} символов.");
        }

        /// <summary>
        /// Проверяет область значения числа.
        /// </summary>
        /// <param name="bottomLimit">Минимальное значение.</param>
        /// <param name="topLimit">Максимальное значение.</param>
        /// <param name="value">Число.</param>
        public static void Limit(int bottomLimit, int topLimit, int value)
        {
            TopLimit(topLimit, value);
            BottomLimit(bottomLimit, value);
        }

        /// <summary>
        /// Проверяет максимальное значение числа.
        /// </summary>
        /// <param name="limit">Максимальное значение.</param>
        /// <param name="value">Число.</param>
        public static void TopLimit(int limit, int value)
        {
            if (value > limit) throw new ArgumentException($"Значение не может быть больше {limit}.");
        }

        /// <summary>
        /// Проверяет минимальное значение числа.
        /// </summary>
        /// <param name="limit">Минимальное значение.</param>
        /// <param name="value">Число.</param>
        public static void BottomLimit(int limit, int value)
        {
            if (value < limit) throw new ArgumentException($"Значение не может быть меньше {limit}.");
        }

        /// <summary>
        /// Проверяет область значения числа.
        /// </summary>
        /// <param name="bottomLimit">Минимальное значение.</param>
        /// <param name="topLimit">Максимальное значение.</param>
        /// <param name="value">Число.</param>
        public static void Limit(double bottomLimit, double topLimit, double value)
        {
            TopLimit(topLimit, value);
            BottomLimit(bottomLimit, value);
        }

        /// <summary>
        /// Проверяет максимальное значение числа.
        /// </summary>
        /// <param name="limit">Максимальное значение.</param>
        /// <param name="value">Число.</param>
        public static void TopLimit(double limit, double value)
        {
            if (value > limit) throw new ArgumentException($"Значение не может быть больше {limit}.");
        }

        /// <summary>
        /// Проверяет минимальное значение числа.
        /// </summary>
        /// <param name="limit">Минимальное значение.</param>
        /// <param name="value">Число.</param>
        public static void BottomLimit(double limit, double value)
        {
            if (value < limit) throw new ArgumentException($"Значение не может быть меньше {limit}.");
        }
    }
}
