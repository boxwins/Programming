using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        private static Type[] _enums = new Type[]
        {
            typeof(CustomColor),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Season),
            typeof(Weekday),
        };

        private MyRectangle[] _rectangles = null;
        private MyRectangle _currentRectangle = null;

        private Movie[] _movies = null;
        private Movie _currentMovie = null;

        private Color _errorColor = Color.LightPink;
        private Color _normalColor = Color.FromKnownColor(KnownColor.Window);

        public MainForm()
        {
            InitializeComponent();

            // enums
            this.listBoxEnums.Items.AddRange(_enums.Select(e => e.Name).ToArray());
            this.listBoxEnums.SelectedIndex = 0;

            this.comboBoxSeason.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());

            // classes::rectangles
            _rectangles = GetRectangles(5);
            UpdateRectangleBox(_rectangles.Length);
            this.listBoxRectangles.SelectedIndex = 0;

            // classes::movies
            _movies = GetMovies(5);
            UpdateMovieBox(_movies.Length);
            this.listBoxMovies.SelectedIndex = 0;
        }

        #region Enums

        private void listBoxEnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selected = _enums[this.listBoxEnums.SelectedIndex];

            this.listBoxValues.Items.Clear();
            this.listBoxValues.Items.AddRange(Enum.GetValues(selected).Cast<object>().ToArray());
        }

        private void listBoxValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox.Text = ((int)this.listBoxValues.SelectedItem).ToString();
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(typeof(Weekday), this.textBoxParsing.Text, out object result))
            {
                this.labelParseValue.Text = $"Это день недели ({result} = {(int)result})";
            }
            else this.labelParseValue.Text = $"Нет такого дня недели";
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            switch (comboBoxSeason.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Autumn:
                    this.groupBoxSeason.BackColor = Color.Orange;
                    break;
                case Season.Spring:
                    this.groupBoxSeason.BackColor = Color.LightGreen;
                    break;
            }
        }

        #endregion

        #region Classes

        // rectangles
        private MyRectangle[] GetRectangles(int count)
        {
            Random random = new Random();
            MyRectangle[] result = new MyRectangle[count];

            for (int i = 0; i < count; i++)
            {
                MyRectangle rectangle = new MyRectangle();
                rectangle.Width = random.Next(0, 100);
                rectangle.Height = random.Next(0, 100);

                result[i] = rectangle;
            }

            return result;
        }

        private void UpdateRectangleBox(int count)
        {
            this.listBoxRectangles.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                this.listBoxRectangles.Items.Add($"Rectangle {i + 1}");
            }
        }

        private void listBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[listBoxRectangles.SelectedIndex];

            textBoxWidth.Text = _currentRectangle.Width.ToString();
            textBoxHeight.Text = _currentRectangle.Height.ToString();
            textBoxColor.Text = _currentRectangle.Color.Name;
            textBoxCenter.Text = _currentRectangle.Center.ToString();
            textBoxID.Text = _currentRectangle.ID.ToString();
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            try
            {
                _currentRectangle.Width = int.Parse(textBoxWidth.Text);
                textBoxWidth.BackColor = _normalColor;
            }
            catch (Exception)
            {
                textBoxWidth.BackColor = _errorColor;
            }
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            try
            {
                _currentRectangle.Height = int.Parse(textBoxHeight.Text);
                textBoxHeight.BackColor = _normalColor;
            }
            catch (Exception)
            {
                textBoxHeight.BackColor = _errorColor;
            }
        }

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            Color value = Color.FromName(textBoxColor.Text);
            if (value.A == 0)
                textBoxColor.BackColor = _errorColor;
            else
            {
                _currentRectangle.Color = value;
                textBoxColor.BackColor = _normalColor;
            }
        }

        private void buttonRectFind_Click(object sender, EventArgs e)
        {
            this.listBoxRectangles.SelectedIndex = FindMaxWidthIndex(_rectangles);
        }

        private int FindMaxWidthIndex(MyRectangle[] rectangles)
        {
            if (rectangles == null && rectangles.Length < 1) throw new ArgumentException("rectangles");

            int index = 0;
            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > rectangles[index].Width) index = i;
            }
            return index;
        }

        // movies
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
                textBoxRating.BackColor = _normalColor;
            }
            catch (Exception)
            {
                textBoxRating.BackColor = _errorColor;
            }
        }

        private void textBoxDuration_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                _currentMovie.Duration = int.Parse(textBoxDuration.Text);
                textBoxDuration.BackColor = _normalColor;
            }
            catch (Exception)
            {
                textBoxDuration.BackColor = _errorColor;
            }
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                _currentMovie.ReleaseYear = int.Parse(textBoxYear.Text);
                textBoxYear.BackColor = _normalColor;
            }
            catch (Exception)
            {
                textBoxYear.BackColor = _errorColor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        #endregion        
    }
}