namespace Programming.Model.Geometry
{
    public class MyRectangle
    {
        private static int _rectanglesCount = 0;

        private int _id = 0;
        private int _width = 0;
        private int _height = 0;
        private Color _color = Color.White;
        private Point2D _center = Point2D.Empty;

        public static int RectanglesCount
        {
            get { return _rectanglesCount; }
        }

        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public int Width
        {
            get { return _width; }
            set
            {
                Validator.OnlyPositive(value, nameof(Width));
                _width = value;
            }
        }

        public int Height
        {
            get { return _height; }
            set
            {
                Validator.OnlyPositive(value, nameof(Height));
                _height = value;
            }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public MyRectangle()
        {
            ID = _rectanglesCount++;
        }

        public MyRectangle(Point2D center, int width, int height, Color color) : this()
        {
            Width = width;
            Height = height;
            Color = color;
            Center = center;
        }

        public static MyRectangle GetRandomRentangle()
        {
            Random random = new Random();

            int x = random.Next(0, 100);
            int y = random.Next(0, 100);
            int width = random.Next(10, 100);
            int height = random.Next(10, 100);

            return new MyRectangle(new Point2D(x, y), width, height, Color.White);
        }

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
