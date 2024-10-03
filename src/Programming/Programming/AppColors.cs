namespace Programming
{
    /// <summary>
    /// Вспомогательны класс, содержащий все цвета программы.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// [GET] Цвет ошибки в текстовом поле.
        /// </summary>
        public static Color ErrorColor => Color.LightPink;

        /// <summary>
        /// [GET] Цвет текстового поля.
        /// </summary>
        public static Color NormalColor => Color.FromKnownColor(KnownColor.Window);

        /// <summary>
        /// [GET] Цвет прямоугольника.
        /// </summary>
        public static Color RectangleColor => Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// [GET] Цвет пересекающегося прямоугольника.
        /// </summary>
        public static Color IntersectionColor => Color.FromArgb(127, 255, 127, 127);
    }
}
