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

        public MainForm()
        {
            InitializeComponent();

            this.listBoxEnums.Items.AddRange(_enums.Select(e => e.Name).ToArray());
            this.listBoxEnums.SelectedIndex = 0;

            this.comboBoxSeason.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
        }

        private void listBoxEnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selected = _enums[this.listBoxEnums.SelectedIndex];
            //Array array = Enum.GetValues(selected);

            this.listBoxValues.Items.Clear();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    this.listBoxValues.Items.Add(array.GetValue(i));
            //}

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
    }
}