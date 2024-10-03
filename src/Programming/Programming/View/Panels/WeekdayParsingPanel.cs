using Programming.Model.Enums;

namespace Programming.View.Panels
{
    /// <summary>
    /// Панель конвертации дней недели.
    /// </summary>
    public partial class WeekdayParsingPanel : UserControl
    {
        public WeekdayParsingPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события Click кнопки <see cref="buttonParse"/>.
        /// </summary>
        private void ButtonParse_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(typeof(Weekday), this.textBoxParsing.Text, out object result)
                && (int)result < typeof(Weekday).GetEnumValues().Length)
            {
                this.labelParseValue.Text = $"Это день недели ({result} = {(int)result})";
            }
            else this.labelParseValue.Text = $"Нет такого дня недели";
        }
    }
}
