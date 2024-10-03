namespace Programming.Model.Geometry
{
    /// <summary>
    /// Кольцо.
    /// </summary>
    public class Ring
    {
        private double _innerRadius = 0;
        private double _outerRadius = 0;
        private Point2D _center = Point2D.Empty;

        /// <summary>
        /// [GET / SET] Внутренний радиус кольца. Значение не может быть ниже нуля и превышать значение внешнего радиуса.
        /// </summary>
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

        /// <summary>
        /// [GET / SET] Внежний радиус кольца. Значение не может быть ниже нуля и значения внутреннего радиуса.
        /// </summary>
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

        /// <summary>
        /// [GET / SET] Центр кольца.
        /// </summary>
        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        /// <summary>
        /// [GET] Площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(_outerRadius, 2) - Math.PI * Math.Pow(_innerRadius, 2);
            }
        }

        /// <param name="center"><see cref="Center"/>.</param>
        /// <param name="innerRadius"><see cref="InnerRadius"/>.</param>
        /// <param name="outerRadius"><see cref="OuterRadius"/>.</param>
        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
    }
}
