using Programming.Model.Enums;

namespace Programming.View.Panels
{
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

        private void listBoxEnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selected = _enums[this.listBoxEnums.SelectedIndex];

            this.listBoxValues.Items.Clear();
            this.listBoxValues.Items.AddRange(Enum.GetValues(selected).Cast<object>().ToArray());
        }

        private void listBoxValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxValue.Text = ((int)this.listBoxValues.SelectedItem).ToString();
        }
    }
}
