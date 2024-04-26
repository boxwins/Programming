namespace Programming.Model.Geometry
{
    /// <summary>
    /// Вспомогательный класс для работы с коллизией.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Определяет пересекаются ли два прямоугольника.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>В случае пересечения <see langword="true"/>, иначе <see langword="false"/>.</returns>
        public static bool IsCollision(MyRectangle rectangle1, MyRectangle rectangle2)
        {
            Point2D region = new Point2D(
                Math.Abs(rectangle2.Center.X - rectangle1.Center.X),
                Math.Abs(rectangle2.Center.Y - rectangle1.Center.Y));

            Point2D rect1Half = new Point2D(rectangle1.Width / 2, rectangle1.Height / 2);
            Point2D rect2Half = new Point2D(rectangle2.Width / 2, rectangle2.Height / 2);

            Point2D minRegion = rect1Half + rect2Half;

            return region.X < minRegion.X && region.Y < minRegion.Y;
        }

        /// <summary>
        /// Определяет пересекаются ли два кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>В случае пересечения <see langword="true"/>, иначе <see langword="false"/>.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            Point2D region = new Point2D(
                Math.Abs(ring2.Center.X - ring1.Center.X),
                Math.Abs(ring2.Center.Y - ring1.Center.Y));

            double distance = Math.Sqrt(Math.Pow(region.X, 2) + Math.Pow(region.Y, 2));
            double minDistance = ring1.OuterRadius + ring2.OuterRadius;

            if (distance >= minDistance) return false;

            return !(
                ring1.OuterRadius + distance < ring2.InnerRadius ||
                ring2.OuterRadius + distance < ring1.InnerRadius);
        }
    }
}
