using System.Text.RegularExpressions;

namespace Programming.Model
{
    /// <summary>
    /// Вспомогательный класс для проверки значений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Вызывает <see cref="ArgumentException"/> если значение меньше чем 0.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя свойства, в которое значение устанавливается.</param>
        public static void OnlyPositive(int value, string name)
        {
            if (value < 0) throw new ArgumentException($"Value can't be negative: '{name}' = '{value}'.");
        }

        /// <summary>
        /// Вызывает <see cref="ArgumentException"/> если значение меньше чем 0.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя свойства, в которое значение устанавливается.</param>
        public static void OnlyPositive(double value, string name)
        {
            if (value < 0) throw new ArgumentException($"Value can't be negative: '{name}' = '{value}'.");
        }

        /// <summary>
        /// Вызывает <see cref="ArgumentException"/> если значение больше указанного лимита.
        /// </summary>
        /// <param name="limit">Лимит значения.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя свойства, в которое значение устанавливается.</param>
        public static void TopLimit(int limit, int value, string name)
        {
            if (value > limit) throw new ArgumentException($"Value can't be higher than {limit}: '{name}' = '{value}'.");
        }

        /// <summary>
        /// Вызывает <see cref="ArgumentException"/> если значение больше указанного лимита.
        /// </summary>
        /// <param name="limit">Лимит значения.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя свойства, в которое значение устанавливается.</param>
        public static void TopLimit(double limit, double value, string name)
        {
            if (value > limit) throw new ArgumentException($"Value can't be higher than {limit}: '{name}' = '{value}'.");
        }

        /// <summary>
        /// Вызывает <see cref="ArgumentException"/> если значение меньше указанного лимита.
        /// </summary>
        /// <param name="limit">Лимит значения.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя свойства, в которое значение устанавливается.</param>
        public static void BottomLimit(int limit, int value, string name)
        {
            if (value < limit) throw new ArgumentException($"Value can't be lower than {limit}: '{name}' = '{value}'.");
        }

        /// <summary>
        /// Вызывает <see cref="ArgumentException"/> если значение меньше указанного лимита.
        /// </summary>
        /// <param name="limit">Лимит значения.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя свойства, в которое значение устанавливается.</param>
        public static void BottomLimit(double limit, double value, string name)
        {
            if (value < limit) throw new ArgumentException($"Value can't be lower than {limit}: '{name}' = '{value}'.");
        }

        /// <summary>
        /// Вызывает <see cref="ArgumentException"/> если значение не находится в указанном диапазоне.
        /// </summary>
        /// <param name="min">Минимальное значение диапазона.</param>
        /// <param name="max">Максимальное значение диапазона.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя свойства, в которое значение устанавливается.</param>
        public static void OnlyInRange(int min, int max, int value, string name)
        {
            TopLimit(max, value, name);
            BottomLimit(min, value, name);
        }

        /// <summary>
        /// Вызывает <see cref="ArgumentException"/> если значение не находится в указанном диапазоне.
        /// </summary>
        /// <param name="min">Минимальное значение диапазона.</param>
        /// <param name="max">Максимальное значение диапазона.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя свойства, в которое значение устанавливается.</param>
        public static void OnlyInRange(double min, double max, double value, string name)
        {
            TopLimit(max, value, name);
            BottomLimit(min, value, name);
        }

        /// <summary>
        /// Вызывает <see cref="ArgumentException"/> если строка содержит не только латинские символы.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="name">Имя свойства, в которое значение устанавливается.</param>
        public static void OnlyLatin(string value, string name)
        {
            if (Regex.IsMatch(value, "^[a-zA-Z0-9]*$")) return;
            throw new ArgumentException($"String can only consist of latin characters: '{name}' = '{value}'.");
        }
    }
}
