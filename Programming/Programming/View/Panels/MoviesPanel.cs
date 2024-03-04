using Programming.Model;

namespace Programming.View.Panels
{
    public partial class MoviesPanel : UserControl
    {
        private Movie[] _movies = null;
        private Movie _currentMovie = null;

        public MoviesPanel()
        {
            InitializeComponent();

            _movies = GetMovies(5);
            UpdateMovieBox(_movies.Length);
            this.listBoxMovies.SelectedIndex = 0;
        }

        private Movie[] GetMovies(int count)
        {
            Random random = new Random();
            Movie[] result = new Movie[count];

            for (int i = 0; i < count; i++)
            {
                Movie movie = new Movie();

                movie.Name = "<name>";
                movie.Genre = "<genre>";

                movie.Rating = random.Next(0, 10);
                movie.Duration = random.Next(30, 180);
                movie.ReleaseYear = random.Next(1980, 2024);

                result[i] = movie;
            }

            return result;
        }

        private void UpdateMovieBox(int count)
        {
            this.listBoxMovies.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                this.listBoxMovies.Items.Add($"Movie {i + 1}");
            }
        }

        private void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[listBoxMovies.SelectedIndex];

            textBoxName.Text = _currentMovie.Name;
            textBoxGenre.Text = _currentMovie.Genre;
            textBoxRating.Text = _currentMovie.Rating.ToString();
            textBoxDuration.Text = _currentMovie.Duration.ToString();
            textBoxYear.Text = _currentMovie.ReleaseYear.ToString();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            _currentMovie.Name = textBoxName.Text;
        }

        private void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            _currentMovie.Genre = textBoxGenre.Text;
        }

        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                _currentMovie.Rating = int.Parse(textBoxRating.Text);
                textBoxRating.BackColor = AppColors.NormalColor;
            }
            catch (Exception)
            {
                textBoxRating.BackColor = AppColors.ErrorColor;
            }
        }

        private void textBoxDuration_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                _currentMovie.Duration = int.Parse(textBoxDuration.Text);
                textBoxDuration.BackColor = AppColors.NormalColor;
            }
            catch (Exception)
            {
                textBoxDuration.BackColor = AppColors.ErrorColor;
            }
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                _currentMovie.ReleaseYear = int.Parse(textBoxYear.Text);
                textBoxYear.BackColor = AppColors.NormalColor;
            }
            catch (Exception)
            {
                textBoxYear.BackColor = AppColors.ErrorColor;
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            this.listBoxMovies.SelectedIndex = FindMaxRatingIndex(_movies);
        }

        private int FindMaxRatingIndex(Movie[] movies)
        {
            if (movies == null && movies.Length < 1) throw new ArgumentException("movies");

            int index = 0;
            for (int i = 1; i < movies.Length; i++)
            {
                if (movies[i].Rating > movies[index].Rating) index = i;
            }
            return index;
        }
    }
}
