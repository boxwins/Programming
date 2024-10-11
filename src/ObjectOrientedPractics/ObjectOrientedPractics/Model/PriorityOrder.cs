using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Приоритетный заказ.
    /// </summary>
    public class PriorityOrder : Order
    {
        private int _desiredTime = 0;
        private DateTime _desiredDate = DateTime.Now;

        /// <summary>
        /// [GET] Список доступного для выбора времени заказа.
        /// </summary>
        public static (TimeOnly from, TimeOnly to)[] DeliveryTimes { get; } = 
        [
            (new TimeOnly(9, 0), new TimeOnly(11, 0)),
            (new TimeOnly(11, 0), new TimeOnly(13, 0)),
            (new TimeOnly(13, 0), new TimeOnly(15, 0)),
            (new TimeOnly(15, 0), new TimeOnly(17, 0)),
            (new TimeOnly(17, 0), new TimeOnly(19, 0)),
            (new TimeOnly(19, 0), new TimeOnly(21, 0)),
        ];

        /// <summary>
        /// Желаемое время доставки заказа (индекс).
        /// </summary>
        public int DesiredTime
        {
            get { return _desiredTime; }
            set 
            {
                Validator.Limit(0, DeliveryTimes.Length - 1, value);

                _desiredTime = value; 
            }
        }

        /// <summary>
        /// Желаемая дата доставки заказа.
        /// </summary>
        public DateTime DesiredDate
        {
            get { return _desiredDate; }
            set { _desiredDate = value; }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="desiredDate">Желаемая дата достаки.</param>
        /// <param name="desiredTime">Желаемое время доставки.</param>
        public PriorityOrder(DateTime desiredDate, int desiredTime) : base()
        {
            DesiredDate = desiredDate;
            DesiredTime = desiredTime;
        }
    }
}
