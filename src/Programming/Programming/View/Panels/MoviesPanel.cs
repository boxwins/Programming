using Programming.Model;

namespace Programming.View.Panels
{
    /// <summary>
    /// Панель фильмов.
    /// </summary>
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

        /// <summary>
        /// Создает массив фильмов указанного размера.
        /// </summary>
        /// <param name="count">Количество фильмов в массиве.</param>
        /// <returns>Массив фильмов.</returns>
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

        /// <summary>
        /// Обновляет элемент <see cref="listBoxMovies"/> заполняя его указанным количеством фильмов.
        /// </summary>
        /// <param name="count">Количество фильмов.</param>
        private void UpdateMovieBox(int count)
        {
            this.listBoxMovies.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                this.listBoxMovies.Items.Add($"Movie {i + 1}");
            }
        }

        /// <summary>
        /// Обработчик события SelectedIndexChanged элемента <see cref="listBoxMovies"/>.
        /// </summary>
        private void ListBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[listBoxMovies.SelectedIndex];

            textBoxName.Text = _currentMovie.Name;
            textBoxGenre.Text = _currentMovie.Genre;
            textBoxRating.Text = _currentMovie.Rating.ToString();
            textBoxDuration.Text = _currentMovie.Duration.ToString();
            textBoxYear.Text = _currentMovie.ReleaseYear.ToString();
        }

        /// <summary>
        /// Обработчик события TextChanged элемента <see cref="textBoxName"/>.
        /// </summary>
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            _currentMovie.Name = textBoxName.Text;
        }

        /// <summary>
        /// Обработчик события TextChanged элемента <see cref="textBoxGenre"/>.
        /// </summary>
        private void TextBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            _currentMovie.Genre = textBoxGenre.Text;
        }

        /// <summary>
        /// Обработчик события TextChanged элемента <see cref="textBoxRating"/>.
        /// </summary>
        private void TextBoxRating_TextChanged(object sender, EventArgs e)
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

        /// <summary>
        /// Обработчик события TextChanged элемента <see cref="textBoxDuration"/>.
        /// </summary>
        private void TextBoxDuration_TextChanged(object sender, EventArgs e)
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

        /// <summary>
        /// Обработчик события TextChanged элемента <see cref="textBoxYear"/>.
        /// </summary>
        private void TextBoxYear_TextChanged(object sender, EventArgs e)
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

        /// <summary>
        /// Обработчик события Click элемента <see cref="buttonFind"/>.
        /// </summary>
        private void ButtonFind_Click(object sender, EventArgs e)
        {
            this.listBoxMovies.SelectedIndex = FindMaxRatingIndex(_movies);
        }

        /// <summary>
        /// Находит фильм с максимальным рейтингом в переданном массиве.
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
        /// <returns>Индекс фильма с максимальным рейтингом.</returns>
        /// <exception cref="ArgumentException"></exception>
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
