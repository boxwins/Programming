using Programming.Model.Enums;

namespace Programming
{
    /// <summary>
    /// Главное окно программы.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.seasonParsingPanel.SeasonGoPressed += OnSeasonGoPressed;
        }

        /// <summary>
        /// Обработчик события SeasonGoPressed панели <see cref="seasonParsingPanel"/>.
        /// </summary>
        private void OnSeasonGoPressed(Season season)
        {
            switch (season)
            {
                case Season.Autumn:
                    this.BackColor = Color.Orange;
                    break;
                case Season.Spring:
                    this.BackColor = Color.LightGreen;
                    break;
            }
        }
    }
}