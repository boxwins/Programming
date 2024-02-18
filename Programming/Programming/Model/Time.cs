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
                if (value < 0) throw new ArgumentException("Value cannot be negative");
                if (value > 24) throw new ArgumentException("Value cannot be higher than 24");
                _hours = value;
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0) throw new ArgumentException("Value cannot be negative");
                if (value > 60) throw new ArgumentException("Value cannot be higher than 60");
                _minutes = value;
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0) throw new ArgumentException("Value cannot be negative");
                if (value > 60) throw new ArgumentException("Value cannot be higher than 60");
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
