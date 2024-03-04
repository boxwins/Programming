using Programming.Model.Enums;

namespace Programming.View.Panels
{
    /// <summary>
    /// Панель перечислений.
    /// </summary>
    public partial class EnumerationPanel : UserControl
    {
        private static Type[] _enums = new Type[]
        {
            typeof(CustomColor),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Season),
            typeof(Weekday),
        };

        public EnumerationPanel()
        {
            InitializeComponent();

            this.listBoxEnums.Items.AddRange(_enums.Select(e => e.Name).ToArray());
            this.listBoxEnums.SelectedIndex = 0;
        }

        /// <summary>
        /// Обработчик события SelectedIndexChanged элемента <see cref="listBoxEnums"/>.
        /// </summary>
        private void ListBoxEnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selected = _enums[this.listBoxEnums.SelectedIndex];

            this.listBoxValues.Items.Clear();
            this.listBoxValues.Items.AddRange(Enum.GetValues(selected).Cast<object>().ToArray());
        }

        /// <summary>
        /// Обработчик события SelectedIndexChanged элемента <see cref="listBoxValues"/>.
        /// </summary>
        private void ListBoxValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxValue.Text = ((int)this.listBoxValues.SelectedItem).ToString();
        }
    }
}
