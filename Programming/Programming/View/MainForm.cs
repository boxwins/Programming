using Programming.Model.Enums;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.seasonParsingPanel.SeasonGoPressed += OnSeasonGoPressed;
        }

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