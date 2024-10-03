namespace Programming.Model
{
    /// <summary>
    /// Песня.
    /// </summary>
    public class Song
    {
        private string _album = string.Empty;
        private string _name = string.Empty;
        private string _author = string.Empty;

        /// <summary>
        /// [GET / SET] Льбом.
        /// </summary>
        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }

        /// <summary>
        /// [GET / SET] Название песни.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// [GET / SET] Автор песни.
        /// </summary>
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public Song() { }

        /// <param name="name"><see cref="Name">.</param>
        /// <param name="author"><see cref="Author">.</param>
        /// <param name="album"><see cref="Album">.</param>
        public Song(string name, string author, string album)
        {
            Name = name;
            Author = author;
            Album = album;
        }
    }
}
