namespace Programming.Model
{
    public class Song
    {
        private string _album = string.Empty;
        private string _name = string.Empty;
        private string _author = string.Empty;

        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public Song() { }

        public Song(string name, string author, string album)
        {
            Name = name;
            Author = author;
            Album = album;
        }
    }
}
