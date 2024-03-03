using Programming.Model;
using Programming.Model.Enums;
using Programming.Model.Geometry;
using Programming.Properties;
using System.Diagnostics;

namespace Programming
{
    public partial class MainForm : Form
    {
        // enums
        private static Type[] _enums = new Type[]
        {
            typeof(CustomColor),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Season),
            typeof(Weekday),
        };

        // classes
        private MyRectangle[] _rectangles = null;
        private MyRectangle _currentRectangle = null;

        private Movie[] _movies = null;
        private Movie _currentMovie = null;

        private Color _errorColor = Color.LightPink;
        private Color _normalColor = Color.FromKnownColor(KnownColor.Window);

        // rectangles
        private MyRectangle _selectedRectangle = null;
        private List<MyRectangle> _rectangleList = new List<MyRectangle>();
        private List<Panel> _renctanglePanels = new List<Panel>();

        private Color _rectangleColor = Color.FromArgb(127, 127, 255, 127);
        private Color _intersectionColor = Color.FromArgb(127, 255, 127, 127);

        public MainForm()
        {
            InitializeComponent();

            // enums
            this.listBoxEnums.Items.AddRange(_enums.Select(e => e.Name).ToArray());
            this.listBoxEnums.SelectedIndex = 0;

            this.comboBoxSeason.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());

            // classes::rectangles
            _rectangles = GetRectangles(5);
            UpdateListBoxRectangles(_rectangles.Length);
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
            if (Enum.TryParse(typeof(Weekday), this.textBoxParsing.Text, out object result)
                && (int)result < typeof(Weekday).GetEnumValues().Length)
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
            MyRectangle[] result = new MyRectangle[count];

            for (int i = 0; i < count; i++)
                result[i] = GetRandomRentangle();

            return result;
        }

        private void UpdateListBoxRectangles(int count)
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

        #region Rectangles

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            MyRectangle rectangle = GetRandomAtBounds(panelCanvas.Bounds, 15);

            _rectangleList.Add(rectangle);
            rectangleBox.Items.Add(rectangle.ToString());

            Panel panel = new Panel();

            panel.Width = rectangle.Width;
            panel.Height = rectangle.Height;
            panel.Location = new Point(
                rectangle.Center.X - panel.Width / 2,
                rectangle.Center.Y - panel.Height / 2);
            panel.BackColor = _rectangleColor;
            panel.BorderStyle = BorderStyle.FixedSingle;

            _renctanglePanels.Add(panel);
            panelCanvas.Controls.Add(panel);

            CollisionOnAdd(_rectangleList.Count - 1);
        }

        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            int index = rectangleBox.SelectedIndex;
            if (index < 0) return;

            CollisionOnRemove(index);

            panelCanvas.Controls.Remove(_renctanglePanels[index]);
            _renctanglePanels.RemoveAt(index);

            _rectangleList.RemoveAt(index);
            rectangleBox.Items.RemoveAt(index);
        }

        private void rectangleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectangleBox.SelectedIndex < 0)
            {
                _selectedRectangle = null;

                textBoxSelectedWidth.Text = string.Empty;
                textBoxSelectedHeight.Text = string.Empty;
                textBoxSelectedColor.Text = string.Empty;
                textBoxSelectedCenter.Text = string.Empty;
                textBoxSelectedID.Text = string.Empty;

                return;
            }

            _selectedRectangle = _rectangleList[rectangleBox.SelectedIndex];

            textBoxSelectedWidth.Text = _selectedRectangle.Width.ToString();
            textBoxSelectedHeight.Text = _selectedRectangle.Height.ToString();
            textBoxSelectedColor.Text = _selectedRectangle.Color.Name;
            textBoxSelectedCenter.Text = _selectedRectangle.Center.ToString();
            textBoxSelectedID.Text = _selectedRectangle.ID.ToString();

            HighlightAsync(_renctanglePanels[rectangleBox.SelectedIndex].Bounds, 500);
        }

        private void textBoxSelectedWidth_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;
            try
            {
                CollisionOnRemove(rectangleBox.SelectedIndex);

                _selectedRectangle.Width = int.Parse(textBoxSelectedWidth.Text);
                textBoxSelectedWidth.BackColor = _normalColor;

                int cursor = textBoxSelectedWidth.SelectionStart;
                rectangleBox.Items[rectangleBox.SelectedIndex] = _selectedRectangle.ToString();
                textBoxSelectedWidth.Select(cursor, 0);

                _renctanglePanels[rectangleBox.SelectedIndex].Width = _selectedRectangle.Width;

                CollisionOnAdd(rectangleBox.SelectedIndex);
            }
            catch (Exception)
            {
                textBoxSelectedWidth.BackColor = _errorColor;
            }
        }

        private void textBoxSelectedHeight_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;
            try
            {
                CollisionOnRemove(rectangleBox.SelectedIndex);

                _selectedRectangle.Height = int.Parse(textBoxSelectedHeight.Text);
                textBoxSelectedHeight.BackColor = _normalColor;

                int cursor = textBoxSelectedHeight.SelectionStart;
                rectangleBox.Items[rectangleBox.SelectedIndex] = _selectedRectangle.ToString();
                textBoxSelectedHeight.Select(cursor, 0);

                _renctanglePanels[rectangleBox.SelectedIndex].Height = _selectedRectangle.Height;

                CollisionOnAdd(rectangleBox.SelectedIndex);
            }
            catch (Exception)
            {
                textBoxSelectedHeight.BackColor = _errorColor;
            }
        }

        private void textBoxSelectedColor_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;
            Color value = Color.FromName(textBoxSelectedColor.Text);
            if (value.A == 0)
                textBoxSelectedColor.BackColor = _errorColor;
            else
            {
                _selectedRectangle.Color = value;
                textBoxSelectedColor.BackColor = _normalColor;
            }
        }

        private void textBoxSelectedCenter_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;
            if (Point2D.TryParse(textBoxSelectedCenter.Text, out Point2D point))
            {
                CollisionOnRemove(rectangleBox.SelectedIndex);

                _selectedRectangle.Center = point;
                textBoxSelectedCenter.BackColor = _normalColor;

                int cursor = textBoxSelectedCenter.SelectionStart;
                rectangleBox.Items[rectangleBox.SelectedIndex] = _selectedRectangle.ToString();
                textBoxSelectedCenter.Select(cursor, 0);

                _renctanglePanels[rectangleBox.SelectedIndex].Location = new Point(
                    _selectedRectangle.Center.X - _selectedRectangle.Width / 2,
                    _selectedRectangle.Center.Y - _selectedRectangle.Height / 2);

                CollisionOnAdd(rectangleBox.SelectedIndex);
            }
            else textBoxSelectedCenter.BackColor = _errorColor;
        }

        private int[] GetIntersections(int index)
        {
            List<int> intersections = new List<int>();

            for (int i = 0; i < _rectangleList.Count; i++)
            {
                if (i == index) continue;
                if (!CollisionManager.IsCollision(_rectangleList[i], _rectangleList[index])) continue;

                intersections.Add(i);
            }

            return intersections.ToArray();
        }

        private void CollisionOnAdd(int index)
        {
            int[] intersections = GetIntersections(index);

            for (int i = 0; i < intersections.Length; i++)
                _renctanglePanels[intersections[i]].BackColor = _intersectionColor;
            if (intersections.Length > 0) _renctanglePanels[index].BackColor = _intersectionColor;
        }

        private void CollisionOnRemove(int index)
        {
            int[] intersections = GetIntersections(index);

            for (int i = 0; i < intersections.Length; i++)
            {
                if (GetIntersections(intersections[i]).Length > 1)
                    _renctanglePanels[intersections[i]].BackColor = _intersectionColor;
                else _renctanglePanels[intersections[i]].BackColor = _rectangleColor;
            }

            _renctanglePanels[index].BackColor = _rectangleColor;
        }

        #region ButtonEvents

        private void pictureBoxAdd_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxAdd.Image = Resources.add_hovered;
        }

        private void pictureBoxAdd_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAdd.Image = Resources.add_normal;
        }

        private void pictureBoxAdd_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxAdd.Image = Resources.add_pressed;
        }

        private void pictureBoxAdd_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxAdd.Image = Resources.add_hovered;
        }

        private void pictureBoxRemove_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRemove.Image = Resources.remove_hovered;
        }

        private void pictureBoxRemove_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRemove.Image = Resources.remove_normal;
        }

        private void pictureBoxRemove_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxRemove.Image = Resources.remove_pressed;
        }

        private void pictureBoxRemove_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxRemove.Image = Resources.remove_hovered;
        }

        #endregion


        #endregion

        private MyRectangle GetRandomRentangle()
        {
            Random random = new Random();

            int x = random.Next(0, 100);
            int y = random.Next(0, 100);
            int width = random.Next(10, 100);
            int height = random.Next(10, 100);

            return new MyRectangle(new Point2D(x, y), width, height, Color.White);
        }

        private MyRectangle GetRandomAtBounds(Rectangle bounds, int border)
        {
            Random random = new Random();

            int width = random.Next(20, 200);
            int height = random.Next(20, 200);

            int widthHalf = width / 2;
            int heightHalf = height / 2;

            int x = random.Next(border + widthHalf, bounds.Width - border * 2 - widthHalf);
            int y = random.Next(border + heightHalf, bounds.Height - border * 2 - heightHalf);

            return new MyRectangle(new Point2D(x, y), width, height, Color.White);
        }

        private async void HighlightAsync(Rectangle area, int time)
        {
            await Task.Run(() =>
            {
                Panel panel = new Panel();
                panel.Bounds = area;

                panelCanvas.Invoke(() => panelCanvas.Controls.Add(panel));
                panel.BringToFront();

                Stopwatch timer = new Stopwatch();
                timer.Start();

                int nextUpdate = 0;
                int updateStep = 50;
                while (timer.ElapsedMilliseconds < time)
                {
                    if (timer.ElapsedMilliseconds < nextUpdate) continue;

                    int a = 255 - (int)(timer.ElapsedMilliseconds / (double)time * 255);
                    panel.BackColor = Color.FromArgb(a, Color.Yellow);

                    nextUpdate += updateStep;
                }

                panelCanvas.Invoke(() => panelCanvas.Controls.Remove(panel));
            });
        }
    }
}