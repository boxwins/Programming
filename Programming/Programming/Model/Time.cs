namespace Programming.Model
{
    public class Time
    {
        private int _hours = 0;
        private int _minutes = 0;
        private int _seconds = 0;

        public int Hours
        {
            get { return _hours; }
            set
            {
                Validator.OnlyInRange(0, 24, value, nameof(Hours));
                _hours = value;
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                Validator.OnlyInRange(0, 60, value, nameof(Minutes));
                _minutes = value;
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.OnlyInRange(0, 60, value, nameof(Seconds));
                _seconds = value;
            }
        }

        public Time() { }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
