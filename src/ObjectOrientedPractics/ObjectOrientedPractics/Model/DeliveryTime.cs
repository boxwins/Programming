namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Время доставки.
    /// </summary>
    public class DeliveryTime
    {
        /// <summary>
        /// Время доставки ОТ.
        /// </summary>
        public TimeOnly From { get; set; }

        /// <summary>
        /// Время доставки ДО.
        /// </summary>
        public TimeOnly To { get; set; }

        public DeliveryTime() { }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public DeliveryTime(TimeOnly from, TimeOnly to)
        {
            From = from;
            To = to;
        }
    }
}
