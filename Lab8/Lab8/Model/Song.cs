namespace Lab8.Model
{
    /// <summary>
    /// Песня
    /// </summary>
    public class Song
    {
        private string _name = "New Song";
        private string _artist = "Artist";
        private int _duration = 0;
        private Genre _genre = Genre.None;
        private string _imagePath = string.Empty;

        /// <summary>
        /// [GET / SET] Название песни.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.CharLimit(50, value, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// [GET / SET] Имя исполнителя.
        /// </summary>
        public string Artist
        {
            get { return _artist; }
            set
            {
                Validator.CharLimit(50, value, nameof(Artist));
                _artist = value;
            }
        }

        /// <summary>
        /// [GET / SET] Длительность в секундах.
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.TopLimit(7200, value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// [GET / SET] Жанр.
        /// </summary>
        public Genre Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        /// <summary>
        /// [GET / SET] Изображение.
        /// </summary>
        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }
    }
}