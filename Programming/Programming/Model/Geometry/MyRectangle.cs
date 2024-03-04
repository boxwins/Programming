namespace Programming.Model.Geometry
{
    /// <summary>
    /// Прямоугольник.
    /// </summary>
    public class MyRectangle
    {
        private static int _rectanglesCount = 0;

        private int _id = 0;
        private int _width = 0;
        private int _height = 0;
        private Color _color = Color.White;
        private Point2D _center = Point2D.Empty;

        /// <summary>
        /// [GET] Количество созданных экземпляров класса <see cref="MyRectangle"/>.
        /// </summary>
        public static int RectanglesCount
        {
            get { return _rectanglesCount; }
        }

        /// <summary>
        /// [GET] Идентификатор прямоугольника.
        /// </summary>
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// [GET / SET] Ширина прямоугольника.
        /// </summary>
        public int Width
        {
            get { return _width; }
            set
            {
                Validator.OnlyPositive(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// [GET / SET] Высота прямоугольника.
        /// </summary>
        public int Height
        {
            get { return _height; }
            set
            {
                Validator.OnlyPositive(value, nameof(Height));
                _height = value;
            }
        }

        /// <summary>
        /// [GET / SET] Цвет прямоугольника.
        /// </summary>
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// [GET / SET] Центр прямоугольника.
        /// </summary>
        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public MyRectangle()
        {
            ID = _rectanglesCount++;
        }

        /// <param name="center"><see cref="Center"/>.</param>
        /// <param name="width"><see cref="Width"/>.</param>
        /// <param name="height"><see cref="Height"/>.</param>
        /// <param name="color"><see cref="Color"/>.</param>
        public MyRectangle(Point2D center, int width, int height, Color color) : this()
        {
            Width = width;
            Height = height;
            Color = color;
            Center = center;
        }

        /// <summary>
        /// Создает случайный прямоугольник.
        /// </summary>
        /// <returns>Прямоугольник со случайным размером и центром.</returns>
        public static MyRectangle GetRandomRentangle()
        {
            Random random = new Random();

            int x = random.Next(0, 100);
            int y = random.Next(0, 100);
            int width = random.Next(10, 100);
            int height = random.Next(10, 100);

            return new MyRectangle(new Point2D(x, y), width, height, Color.White);
        }

        /// <summary>
        /// Создает случайный прямоугольник в указанном пределе, с указанным минимальным отступом от края.
        /// </summary>
        /// <param name="bounds">Область создания прямоугольника.</param>
        /// <param name="border">Минимальный отступ от края.</param>
        /// <returns>Прямоугольник со случайным размером и центром, внутри указанной области.</returns>
        public static MyRectangle GetRandomAtBounds(Rectangle bounds, int border)
        {
            Random random = new Random();

            int width = random.Next(20, 200);
            int height = random.Next(20, 200);

            int widthHalf = width / 2;
            int heightHalf = height / 2;

            int x = random.Next(border + widthHalf, bounds.Width - border * 2 - widthHalf);
            int y = random.Next(border + heightHalf, bounds.Height - border * 2 - heightHalf);

            return new MyRectangle(new Point2D(x, y), width, height, Color.White);
        }

        public override string ToString()
        {
            return $"{_id}: (X={_center.X}; Y={_center.Y}; W={_width}; H={_height})";
        }
    }
}
