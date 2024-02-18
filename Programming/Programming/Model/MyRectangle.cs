using System.Xml.Linq;

namespace Programming.Model
{
    public class MyRectangle
    {
        private int _width = 0;
        private int _height = 0;
        private Color _color = Color.White;

        public int Width
        {
            get { return _width; }
            set
            {
                if (value < 0) throw new ArgumentException("Value cannot be negative");
                _width = value;
            }
        }

        public int Height
        {
            get { return _height; }
            set
            {
                if (value < 0) throw new ArgumentException("Value cannot be negative");
                _height = value;
            }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public MyRectangle() { }

        public MyRectangle(int width, int height, Color color)
        {
            Width = width;
            Height = height;
            Color = color;
        }
    }
}
