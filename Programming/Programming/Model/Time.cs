namespace Programming.Model
{
    /// <summary>
    /// Время.
    /// </summary>
    public class Time
    {
        private int _hours = 0;
        private int _minutes = 0;
        private int _seconds = 0;

        /// <summary>
        /// [GET / SET] Количество часов. Значение в диапазоне от 0 до 23.
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set
            {
                Validator.OnlyInRange(0, 23, value, nameof(Hours));
                _hours = value;
            }
        }

        /// <summary>
        /// [GET / SET] Количество минут. Значение в диапазоне от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                Validator.OnlyInRange(0, 59, value, nameof(Minutes));
                _minutes = value;
            }
        }

        /// <summary>
        /// [GET / SET] Количество секунд. Значение в диапазоне от 0 до 23.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.OnlyInRange(0, 59, value, nameof(Seconds));
                _seconds = value;
            }
        }

        public Time() { }

        /// <param name="hours"><see cref="Hours">.</param>
        /// <param name="minutes"><see cref="Minutes">.</param>
        /// <param name="seconds"><see cref="Seconds">.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
