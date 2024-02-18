namespace Programming.Model
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
            private set { _center = value; }
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
    }
}
