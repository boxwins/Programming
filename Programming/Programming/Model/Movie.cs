namespace Programming.Model
{
    public class Movie
    {
        private int _rating = 0;
        private int _duration = 0;
        private int _releaseYear = 0;
        private string _name = string.Empty;
        private string _genre = string.Empty;

        public int Rating
        {
            get { return _rating; }
            set
            {
                Validator.OnlyInRange(0, 10, value, nameof(Rating));
                _rating = value;
            }
        }

        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.OnlyPositive(value, nameof(Duration));
                _duration = value;
            }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.BottomLimit(1900, value, nameof(Duration));
                _releaseYear = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public Movie() { }

        public Movie(string name, string genre, int releaseYear, int duration, int rating)
        {
            Name = name;
            Genre = genre;
            ReleaseYear = releaseYear;
            Duration = duration;
            Rating = rating;
        }
    }
}
