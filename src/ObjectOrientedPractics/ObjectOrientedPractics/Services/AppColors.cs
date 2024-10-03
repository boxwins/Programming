namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Основные цвета программы.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// [GET] Цвет элемента TextBox.
        /// </summary>
        public static Color TextBoxColor => Color.FromKnownColor(KnownColor.Window);

        /// <summary>
        /// [GET] Цвет элемента TextBox с ошибкой.
        /// </summary>
        public static Color TextBoxErrorColor => Color.FromArgb(255, 128, 128);
    }
}
