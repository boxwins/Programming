using Lab8.Model;
using System.Text.Json;

namespace Lab8.View
{
    /// <summary>
    /// Панель информационной системы песен.
    /// </summary>
    public partial class SongListPanel : UserControl
    {
        /// <summary>
        /// Относительный путь сохранения данных.
        /// </summary>
        private const string FILE_PATH = @"\data.txt";

        private List<Song> _songList = new List<Song>();
        private List<Song> _shownSongList = new List<Song>();

        public SongListPanel()
        {
            InitializeComponent();

            comboBoxGenre.Items.AddRange(Enum.GetValues(typeof(Genre)).Cast<object>().ToArray());
        }

        /// <summary>
        /// Загружает данные информационной системы из файла.
        /// </summary>
        public void SaveData()
        {
            string path = Environment.CurrentDirectory + FILE_PATH;
            string data = JsonSerializer.Serialize(_songList);

            File.WriteAllText(path, data);
        }

        /// <summary>
        /// Сохраняет данные информационной системы в файл.
        /// </summary>
        public void LoadData()
        {
            string path = Environment.CurrentDirectory + FILE_PATH;

            if (!File.Exists(path)) return;

            string data = File.ReadAllText(path);

            _songList = JsonSerializer.Deserialize<List<Song>>(data);

            UpdateShown();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Song song = new Song();
            _songList.Add(song);

            UpdateShown();

            ChangeSelectedSafe(_shownSongList.IndexOf(song));
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0) return;

            _songList.Remove(_shownSongList[listBox.SelectedIndex]);

            int index = listBox.SelectedIndex > 0 ? listBox.SelectedIndex - 1 : listBox.SelectedIndex;

            UpdateShown();

            ChangeSelectedSafe(index);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0)
            {
                textBoxName.Text = string.Empty;
                textBoxArtist.Text = string.Empty;
                textBoxDuration.Text = string.Empty;

                comboBoxGenre.SelectedIndex = 0;
            }
            else
            {
                textBoxName.Text = _shownSongList[listBox.SelectedIndex].Name;
                textBoxArtist.Text = _shownSongList[listBox.SelectedIndex].Artist;
                textBoxDuration.Text = $"{_shownSongList[listBox.SelectedIndex].Duration}";

                comboBoxGenre.SelectedIndex = (int)_shownSongList[listBox.SelectedIndex].Genre;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0) return;
            try
            {
                _shownSongList[listBox.SelectedIndex].Name = textBoxName.Text;

                UpdateShownTextBoxFix(textBoxName);

                textBoxName.BackColor = AppColors.TextBoxColor;
            }
            catch (ArgumentException)
            {
                textBoxName.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        private void textBoxArtist_TextChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0) return;
            try
            {
                _shownSongList[listBox.SelectedIndex].Artist = textBoxArtist.Text;

                UpdateShownTextBoxFix(textBoxArtist);

                textBoxArtist.BackColor = AppColors.TextBoxColor;
            }
            catch (ArgumentException)
            {
                textBoxArtist.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        private void textBoxDuration_TextChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0) return;
            try
            {
                int duration = int.Parse(textBoxDuration.Text);
                _shownSongList[listBox.SelectedIndex].Duration = duration;

                textBoxDuration.BackColor = AppColors.TextBoxColor;
            }
            catch (Exception)
            {
                textBoxDuration.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0) return;
            if (comboBoxGenre.SelectedIndex < 0) return;

            _shownSongList[listBox.SelectedIndex].Genre = (Genre)comboBoxGenre.SelectedIndex;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateShown();
        }

        /// <summary>
        /// Обновляет отображение списка песен.
        /// </summary>
        private void UpdateShown()
        {
            UnsubscribeTextBoxes();

            Song selectedSong = listBox.SelectedIndex >= 0 ? _shownSongList[listBox.SelectedIndex] : null;

            listBox.ClearSelected();
            listBox.Items.Clear();
            _shownSongList.Clear();

            for (int i = 0; i < _songList.Count; i++)
            {
                if (!_songList[i].Name.Contains(textBoxSearch.Text, StringComparison.CurrentCultureIgnoreCase) &&
                    !_songList[i].Artist.Contains(textBoxSearch.Text, StringComparison.CurrentCultureIgnoreCase)) continue;

                _shownSongList.Add(_songList[i]);
            }

            _shownSongList = _shownSongList.OrderBy(s => s.Artist).ThenBy(s => s.Name).ToList();

            for (int i = 0; i < _shownSongList.Count; i++)
            {
                listBox.Items.Add($"{_shownSongList[i].Artist} - {_shownSongList[i].Name}");
            }

            int index = selectedSong == null ? -1 : _shownSongList.IndexOf(selectedSong);
            listBox.SelectedIndex = index;

            SubscribeTextBoxes();
        }

        /// <summary>
        /// Обертка для <see cref="UpdateShown"/>.
        /// Исправляет баг при котором курсор в TextBox возвращался в начало после вызова <see cref="UpdateShown"/>.
        /// </summary>
        /// <param name="textBox">Текстовое поле, которое требует обновление выбранной песни в списке.</param>
        private void UpdateShownTextBoxFix(TextBox textBox)
        {
            int caretIndex = textBox.SelectionStart;

            UpdateShown();

            textBox.Select(caretIndex, 0);
        }

        /// <summary>
        /// Изменяет выбранный индекс listBox не вызывая события при изменения текста TextBox'ов.
        /// </summary>
        private void ChangeSelectedSafe(int index)
        {
            if (index < 0 || index >= listBox.Items.Count) return;

            UnsubscribeTextBoxes();

            listBox.SelectedIndex = index;

            SubscribeTextBoxes();
        }

        /// <summary>
        /// Подписывает TextBox'ы на событие изменения текста.
        /// </summary>
        private void SubscribeTextBoxes()
        {
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxArtist.TextChanged += textBoxArtist_TextChanged;
        }

        /// <summary>
        /// Отписывает TextBox'ы от события изменения текста.
        /// </summary>
        private void UnsubscribeTextBoxes()
        {
            textBoxName.TextChanged -= textBoxName_TextChanged;
            textBoxArtist.TextChanged -= textBoxArtist_TextChanged;
        }
    }
}
