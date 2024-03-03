namespace Programming.Model.Geometry
{
    public class Ring
    {
        private double _innerRadius = 0;
        private double _outerRadius = 0;
        private Point2D _center = Point2D.Empty;

        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                Validator.OnlyPositive(value, nameof(InnerRadius));
                Validator.TopLimit(_outerRadius, value, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.OnlyPositive(value, nameof(OuterRadius));
                Validator.BottomLimit(_innerRadius, value, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(_outerRadius, 2) - Math.PI * Math.Pow(_innerRadius, 2);
            }
        }

        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
    }
}
