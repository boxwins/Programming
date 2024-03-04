using Programming.Model.Enums;

namespace Programming.View.Panels
{
    public partial class SeasonParsingPanel : UserControl
    {
        public event Action<Season> SeasonGoPressed = null;

        public SeasonParsingPanel()
        {
            InitializeComponent();

            this.comboBoxSeason.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
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
            }

            SeasonGoPressed?.Invoke((Season)comboBoxSeason.SelectedItem);
        }
    }
}
