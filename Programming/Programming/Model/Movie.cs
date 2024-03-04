namespace Programming.Model
{
    /// <summary>
    /// Фильм.
    /// </summary>
    public class Movie
    {
        private int _rating = 0;
        private int _duration = 0;
        private int _releaseYear = 0;
        private string _name = string.Empty;
        private string _genre = string.Empty;

        /// <summary>
        /// [GET / SET] Рейтинг фильма. Значение в диапазоне от 0 до 10.
        /// </summary>
        public int Rating
        {
            get { return _rating; }
            set
            {
                Validator.OnlyInRange(0, 10, value, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// [GET / SET] Длительность фильма.
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
        /// [GET / SET] Год выпуска фильма.
        /// </summary>
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.BottomLimit(1900, value, nameof(Duration));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// [GET / SET] Название фильма.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// [GET / SET] Жанр фильма.
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public Movie() { }

        /// <param name="name"><see cref="Name">.</param>
        /// <param name="genre"><see cref="Genre">.</param>
        /// <param name="releaseYear"><see cref="ReleaseYear">.</param>
        /// <param name="duration"><see cref="Duration">.</param>
        /// <param name="rating"><see cref="Rating">.</param>
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
