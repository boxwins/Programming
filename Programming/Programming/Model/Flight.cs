namespace Programming.Model
{
    /// <summary>
    /// Рейс.
    /// </summary>
    public class Flight
    {
        private int _duration = 0;
        private string _origin = string.Empty;
        private string _destination = string.Empty;

        /// <summary>
        /// [GET / SET] Длительность рейса.
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.OnlyPositive(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// [GET / SET] Точка отправления.
        /// </summary>
        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        /// <summary>
        /// [GET / SET] Точка назначения.
        /// </summary>
        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public Flight() { }

        /// <param name="origin"><see cref="Origin">.</param>
        /// <param name="destination"><see cref="Destination">.</param>
        /// <param name="duration"><see cref="Duration">.</param>
        public Flight(string origin, string destination, int duration)
        {
            Origin = origin;
            Destination = destination;
            Duration = duration;
        }
    }
}
