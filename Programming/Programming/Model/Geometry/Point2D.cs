namespace Programming.Model.Geometry
{
    public class Point2D
    {
        private int _x = 0;
        private int _y = 0;

        public static Point2D Empty => new Point2D(0, 0);

        public int X
        {
            get { return _x; }
            private set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            private set { _y = value; }
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool TryParse(string str, out Point2D point)
        {
            point = Point2D.Empty;

            string[] split = str.Split(',');
            if (split.Length != 2) return false;

            if (!int.TryParse(split[0].Replace("X:", string.Empty), out int x)) return false;
            if (!int.TryParse(split[1].Replace("Y:", string.Empty), out int y)) return false;

            point = new Point2D(x, y);
            return true;
        }

        public override string ToString()
        {
            return $"X:{_x},Y:{_y}";
        }

        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
        }

        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
        }
    }
}
