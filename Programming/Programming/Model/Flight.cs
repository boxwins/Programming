namespace Programming.Model
{
    public class Flight
    {
        private int _duration = 0;
        private string _origin = string.Empty;
        private string _destination = string.Empty;

        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value < 0) throw new ArgumentException("Value cannot be negative");
                _duration = value;
            }
        }

        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public Flight() { }

        public Flight(string origin, string destination, int duration)
        {
            Origin = origin;
            Destination = destination;
            Duration = duration;
        }
    }
}
