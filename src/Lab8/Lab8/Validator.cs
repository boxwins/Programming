namespace Lab8
{
    public static class Validator
    {
        public static void CharLimit(int limit, string value, string name)
        {
            if (value.Length > limit) throw new ArgumentException($"'{name}'\nДлина строки не может превышать {limit} символов.");
        }

        public static void TopLimit(int limit, int value, string name)
        {
            if (value > limit) throw new ArgumentException($"'{name}'\nЗначение не может превышать {limit}.");
        }
    }
}
