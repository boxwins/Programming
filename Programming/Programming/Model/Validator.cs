using System.Text.RegularExpressions;

namespace Programming.Model
{
    public static class Validator
    {
        public static void OnlyPositive(int value, string name)
        {
            if (value < 0) throw new ArgumentException($"Value can't be negative: '{name}' = '{value}'.");
        }

        public static void OnlyPositive(double value, string name)
        {
            if (value < 0) throw new ArgumentException($"Value can't be negative: '{name}' = '{value}'.");
        }

        public static void TopLimit(int limit, int value, string name)
        {
            if (value > limit) throw new ArgumentException($"Value can't be higher than {limit}: '{name}' = '{value}'.");
        }

        public static void TopLimit(double limit, double value, string name)
        {
            if (value > limit) throw new ArgumentException($"Value can't be higher than {limit}: '{name}' = '{value}'.");
        }

        public static void BottomLimit(int limit, int value, string name)
        {
            if (value < limit) throw new ArgumentException($"Value can't be lower than {limit}: '{name}' = '{value}'.");
        }

        public static void BottomLimit(double limit, double value, string name)
        {
            if (value < limit) throw new ArgumentException($"Value can't be lower than {limit}: '{name}' = '{value}'.");
        }

        public static void OnlyInRange(int min, int max, int value, string name)
        {
            TopLimit(max, value, name);
            BottomLimit(min, value, name);
        }

        public static void OnlyInRange(double min, double max, double value, string name)
        {
            TopLimit(max, value, name);
            BottomLimit(min, value, name);
        }

        public static void OnlyLatin(string value, string name)
        {
            if (Regex.IsMatch(value, "^[a-zA-Z0-9]*$")) return;
            throw new ArgumentException($"String can only consist of latin characters: '{name}' = '{value}'.");
        }
    }
}
